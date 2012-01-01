﻿using System;
using System.Collections.Generic;
using Lextm.SharpSnmpLib.Mib.Ast;

namespace Lextm.SharpSnmpLib.Mib
{
    /// <summary>
    /// Definition class.
    /// </summary>
    internal sealed class Definition : IDefinition
    {
        private readonly uint[] _id;
        private string _name;
        private readonly string _module;
        private readonly string _parent;
        private uint _value;
        private readonly IDictionary<uint, IDefinition> _children = new Dictionary<uint, IDefinition>();
        private Definition _parentNode;
        private readonly string _typeString;
        
        private Definition()
        {
        }
        
        internal Definition(uint[] id, string name, string parent, string module, string typeString)
        {
            _id = id;
            _name = name;
            _parent = parent;
            _module = module;
            _value = id[id.Length - 1];
            _typeString = typeString;
        }
        
        /// <summary>
        /// Creates a <see cref="Definition"/> instance.
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="entity"></param>
        internal Definition(IEntity entity, Definition parent)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            if (parent == null)
            {
                throw new ArgumentNullException("parent");
            }

            _parentNode = parent;
            uint[] id = string.IsNullOrEmpty(parent.Name) ?
                null : parent._id; // null for root node    (use _id rather than GetNumericalForm to avoid the Clone)
            _id = AppendTo(id, entity.Value);
            _parent = parent.Name;
            _name = entity.Name;
            _module = entity.ModuleName;
            _value = entity.Value;
            _parentNode.Append(this);
            Type = DetermineType(entity.GetType().ToString(), _name, _parentNode);
        }

        internal void DetermineType(IDefinition parent)
        {
            Type = DetermineType(_typeString, _name, parent);
        }
        
        private static DefinitionType DetermineType(string type, string name, IDefinition parent)
        {
            if (type == typeof(ObjectIdentifierType).ToString()) 
            {
                return DefinitionType.OidValueAssignment;
            }

            if (type != typeof(ObjectTypeMacro).ToString())
            {
                return DefinitionType.Unknown;
            }

            if (name.EndsWith("Table", StringComparison.Ordinal))
            {
                return DefinitionType.Table;
            }

            if (name.EndsWith("Entry", StringComparison.Ordinal)) 
            {
                return DefinitionType.Entry;
            }

            return parent.Type == DefinitionType.Entry ? DefinitionType.Column : DefinitionType.Scalar;
        }
        
        /// <summary>
        /// Value.
        /// </summary>
        public uint Value
        {
            get { return _value; }
            set { }
        }
        
        public string Parent
        {
            get { return _parent; }
            set { }
        }
        
        public IDefinition ParentDefinition
        {
            get
            {
                return _parentNode;
            }

            internal set
            {
                _parentNode = (Definition)value;
                _parentNode.Append(this);
            }
        }

        /// <summary>
        /// Children definitions.
        /// </summary>
        public IEnumerable<IDefinition> Children
        {
            get { return _children.Values; }
        }

        public DefinitionType Type { get; private set; }

        internal static Definition RootDefinition
        {
            get { return new Definition(); }
        }
        
        /// <summary>
        /// Returns the textual form.
        /// </summary>
        internal string TextualForm
        {
            get { return _module + "::" + _name; }
        }

        /// <summary>
        /// Indexer.
        /// </summary>
        public IDefinition GetChildAt(uint index)
        {
            // Since this method is very often used (when parsing OID, and so when displaying a MIB tree),
            // we avoid to call d.GetNumericalForm (which clones the uint[] of the OID) but cast 'd' as a Definition
            // and then call directly it _id field (without modifying it of course).
            // Assume all IDefinition are Definition
            foreach (Definition d in _children.Values)   
            {
                uint[] id = d._id;    // use _id rather than GetNumericalForm to avoid the Clone.
                if (id[id.Length - 1] == index)
                {
                    return d;
                }
            }
            
            return null;
        }

        /// <summary>
        /// Module name.
        /// </summary>
        public string ModuleName
        {
            get { return _module; }
            set { }
        }
        
        /// <summary>
        /// Name.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { }
        }

        /// <summary>
        /// Gets the numerical form.
        /// </summary>
        /// <returns></returns>
        public uint[] GetNumericalForm()
        {
            return (uint[])_id.Clone();
        }
        
        /// <summary>
        /// Add an <see cref="IEntity"/> node.
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Definition Add(IEntity node)
        {
            // * algorithm 1: recursive
            if (_name == node.Parent)
            {
                return new Definition(node, this);
            }

            foreach (Definition d in _children.Values)
            {
                Definition result = d.Add(node);
                if (result != null)
                {
                    return result;
                }
            }

            return null;
            
            // */

            /* algorithm 2: put parent locating task outside. slower, so dropped.
            if (_name != node.Parent)
            {
                throw new ArgumentException("this node is not child of mine", "node");
            }
            return new Definition(node, this);
            // */
        }
        
        /// <summary>
        /// Adds a <see cref="Definition"/> child to this <see cref="Definition"/>.
        /// </summary>
        /// <param name="def"></param>
        private void Append(IDefinition def)
        {
            if (!_children.ContainsKey(def.Value))
            {
                _children.Add(def.Value, def);
            }
        }
        
        internal static uint[] AppendTo(uint[] parentId, uint value)
        {
            if (parentId == null)
            {
                return new[] { value };
            }

            // Old method with List<uint> dropped as it incurred two copies of the array (vs 1 for this method).
            int length = parentId.Length;
            uint[] tmp = new uint[length + 1];
            Array.Copy(parentId, tmp, length);
            tmp[length] = value;
            return tmp;
        }
        
        internal static uint[] GetParent(IDefinition definition)    // Assume all IDefinition are Definition
        {
            uint[] self = ((Definition)definition)._id;        // use _id rather than GetNumericalForm to avoid the Clone.
            uint[] result = new uint[self.Length - 1];
            Array.Copy(self, result, self.Length - 1);            
            return result;
        }
    }
}