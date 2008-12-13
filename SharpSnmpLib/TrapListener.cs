/*
 * Created by SharpDevelop.
 * User: lextm
 * Date: 2008/4/23
 * Time: 19:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace Lextm.SharpSnmpLib
{
    /// <summary>
    /// Trap listener component.
    /// </summary>
    /// <remarks>
    /// <para>Drag this component into your form in designer, or create an instance in code.</para>
    /// <para>Use <see cref="Manager"></see> component if you need to do all SNMP operations.</para>
    /// <para>This component is for TRAP operation only.</para>
    /// <para>Currently only SNMP v1 TRAP is supported.</para>
    /// </remarks>
    public class TrapListener : Component
    {
        private Socket _watcher;
        private int _port = DEFAULTPORT;
        private BackgroundWorker worker;
        private const int DEFAULTPORT = 162;
        private readonly IPEndPoint defaultEndPoint = new IPEndPoint(IPAddress.Any, DEFAULTPORT);
        
        /// <summary>
        /// Creates a <see cref="TrapListener" /> instance.
        /// </summary>
        public TrapListener()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Occurs when a <see cref="TrapV1Message" /> is received.
        /// </summary>
        public event EventHandler<TrapV1ReceivedEventArgs> TrapV1Received;
        
        /// <summary>
        /// Occurs when a <see cref="TrapV2Message"/> is received.
        /// </summary>
        public event EventHandler<TrapV2ReceivedEventArgs> TrapV2Received;
        
        /// <summary>
        /// Occurs when a <see cref="InformRequestMessage"/> is received.
        /// </summary>
        public event EventHandler<InformRequestReceivedEventArgs> InformRequestReceived;

        /// <summary>
        /// Occurs when a <see cref="GetRequestMessage"/> is received.
        /// </summary>
        public event EventHandler<GetRequestReceivedEventArgs> GetRequestReceived;

        /// <summary>
        /// Occurs when a SET request is received.
        /// </summary>
        public event EventHandler<SetRequestReceivedEventArgs> SetRequestReceived;

        /// <summary>
        /// Occurs when a GET NEXT request is received.
        /// </summary>
        public event EventHandler<GetNextRequestReceivedEventArgs> GetNextRequestReceived;

        /// <summary>
        /// Occurs when a GET BULK request is received.
        /// </summary>
        public event EventHandler<GetBulkRequestReceivedEventArgs> GetBulkRequestReceived;

        /// <summary>
        /// Occurs when an exception is raised.
        /// </summary>
        public event EventHandler<ExceptionRaisedEventArgs> ExceptionRaised;

        /// <summary>
        /// Port number.
        /// </summary>
        public int Port
        {
            get
            {
                return _port;
            }
            
            set
            {
                _port = value;
            }
        }
        
        /// <summary>
        /// Starts.
        /// </summary>
        public void Start()
        {
            Start(defaultEndPoint);
        }

        /// <summary>
        /// Starts on a specific port number.
        /// </summary>
        /// <param name="port">Port number.</param>
        public void Start(int port)
        {
            Start(new IPEndPoint(IPAddress.Any, port));
        }
        
        /// <summary>
        /// Starts on a specific end point.
        /// </summary>
        /// <param name="endpoint">End point.</param>
        public void Start(IPEndPoint endpoint)
        {
            if (worker.IsBusy)
            {
                return;
            }
            
            _port = endpoint.Port;
            IPEndPoint _sender = new IPEndPoint(endpoint.Address, endpoint.Port);
            _watcher = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            try
            {
                _watcher.Bind(_sender);
                worker.RunWorkerAsync();
            }
            catch (SocketException ex)
            {
                if (ex.ErrorCode == 10048)
                {
                    throw new SharpSnmpException("Port is already used: " + endpoint.Port.ToString(CultureInfo.InvariantCulture), ex);
                }
            }
        }
        
        /// <summary>
        /// Stops.
        /// </summary>
        public void Stop()
        {
            if (_watcher == null)
            {
                return;
            }
            
            _watcher.Close();
            if (worker.IsBusy)
            {
                worker.CancelAsync();
            }
        }

        private void InitializeComponent()
        {
            this.worker = new BackgroundWorker();
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(Worker_DoWork);
            this.worker.ProgressChanged += new ProgressChangedEventHandler(TrapListener_ProgressChanged);
            this.worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(TrapListener_RunWorkerCompleted);
        } 

        private void TrapListener_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            MessageParams param = (MessageParams)e.UserState;
            HandleMessage(param);
        }

        private void TrapListener_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {                        
            if (e.Error != null && ExceptionRaised != null)
            {
                ExceptionRaised(this, new ExceptionRaisedEventArgs(e.Error));
            }
        }
        
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            IPEndPoint agent = new IPEndPoint(IPAddress.Any, 0);
            EndPoint senderRemote = (EndPoint)agent;
            byte[] msg = new byte[_watcher.ReceiveBufferSize];
            uint loops = 0;
            while (!worker.CancellationPending && worker.IsBusy)
            {
                int number = _watcher.Available;
                if (number == 0)
                {
                    if (Environment.ProcessorCount == 1 || unchecked(++loops % 100) == 0)
                    {
                        Thread.Sleep(1);
                    }
                    else
                    {
                        Thread.SpinWait(20);
                    }
                    
                    continue;
                }
                
                _watcher.ReceiveFrom(msg, ref senderRemote);      
                worker.ReportProgress(0, new MessageParams(msg, number, senderRemote));
            }
        }
        
        private void HandleMessage(MessageParams param)
        {
            ByteTool.Capture(param.Bytes, param.Number);
            
            // *
            foreach (ISnmpMessage message in MessageFactory.ParseMessages(param.Bytes, 0, param.Number))
            {
                switch (message.TypeCode)
                {
                    case SnmpType.TrapV1Pdu:
                        {
                            if (TrapV1Received != null)
                            {
                                TrapV1Received(this, new TrapV1ReceivedEventArgs(param.Sender, (TrapV1Message)message));
                            }
                            
                            break;
                        }
                        
                    case SnmpType.TrapV2Pdu:
                        {
                            if (TrapV2Received != null)
                            {
                                TrapV2Received(this, new TrapV2ReceivedEventArgs(param.Sender, (TrapV2Message)message));
                            }
                            
                            break;
                        }
                        
                    case SnmpType.InformRequestPdu:
                        {
                            InformRequestMessage inform = (InformRequestMessage)message;
                            inform.SendResponse(param.Sender);
                            
                            if (InformRequestReceived != null)
                            {
                                InformRequestReceived(this, new InformRequestReceivedEventArgs(param.Sender, inform));
                            }
                            
                            break;
                        }
                        
                    case SnmpType.GetRequestPdu:
                        {
                            if (GetRequestReceived != null)
                            {
                                GetRequestReceived(this, new GetRequestReceivedEventArgs(param.Sender, (GetRequestMessage)message));
                            }
                            
                            break;
                        }

                    case SnmpType.SetRequestPdu:
                        {
                            if (SetRequestReceived != null)
                            {
                                SetRequestReceived(this, new SetRequestReceivedEventArgs(param.Sender, (SetRequestMessage)message));
                            }

                            break;
                        }

                    case SnmpType.GetNextRequestPdu:
                        {
                            if (GetNextRequestReceived != null)
                            {
                                GetNextRequestReceived(this, new GetNextRequestReceivedEventArgs(param.Sender, (GetNextRequestMessage)message));
                            }

                            break;
                        }

                    case SnmpType.GetBulkRequestPdu:
                        {
                            if (GetBulkRequestReceived != null)
                            {
                                GetBulkRequestReceived(this, new GetBulkRequestReceivedEventArgs(param.Sender, (GetBulkRequestMessage)message));
                            }

                            break;
                        }
                        
                    default:
                        break;
                }
            }
            // */
        }        
        
        /// <summary>
        /// Returns a <see cref="String"/> that represents a <see cref="TrapListener"/>.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trap listener: port: " + _port.ToString(CultureInfo.InvariantCulture);
        }
        
        /// <summary>
        /// Returns a value if the listener is still working.
        /// </summary>
        public bool Active
        {
            get
            {
                return worker.IsBusy;
            }
        }
        
        private class MessageParams
        {
            internal int Number;
            internal byte[] Bytes;
            internal IPEndPoint Sender;
            
            public MessageParams(byte[] bytes, int number, EndPoint sender)
            {
                Bytes = bytes;
                Number = number;
                Sender = (IPEndPoint)sender;
            }
        }
    }
}
