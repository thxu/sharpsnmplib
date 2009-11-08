// $ANTLR 3.1.2 Smi.g 2009-11-08 17:44:53

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162


#pragma warning disable 3001, 3003, 3005, 3009, 1591 


using System;
using Antlr.Runtime;
using IList 		= System.Collections.IList;
using ArrayList 	= System.Collections.ArrayList;
using Stack 		= Antlr.Runtime.Collections.StackList;

using IDictionary	= System.Collections.IDictionary;
using Hashtable 	= System.Collections.Hashtable;

using Antlr.Runtime.Tree;

namespace  Lextm.SharpSnmpLib.Mib.Ast.ANTLR 
{
public partial class SmiParser : Parser
{
    public static readonly string[] tokenNames = new string[] 
	{
        "<invalid>", 
		"<EOR>", 
		"<DOWN>", 
		"<UP>", 
		"ABSENT_KW", 
		"ABSTRACT_SYNTAX_KW", 
		"ALL_KW", 
		"ANY_KW", 
		"APPLICATION_KW", 
		"ARGUMENT_KW", 
		"ASSIGN_OP", 
		"AUTOMATIC_KW", 
		"B_OR_H_STRING", 
		"B_STRING", 
		"BAR", 
		"BASED_NUM_KW", 
		"BDIG", 
		"BEGIN_KW", 
		"BIT_KW", 
		"BMP_STR_KW", 
		"BOOLEAN_KW", 
		"BY_KW", 
		"C_STRING", 
		"CHARACTER_KW", 
		"CHARB", 
		"CHARH", 
		"CHOICE_KW", 
		"CLASS_KW", 
		"COLON", 
		"COMMA", 
		"COMMENT", 
		"COMPONENT_KW", 
		"COMPONENTS_KW", 
		"CONSTRAINED_KW", 
		"DEFAULT_KW", 
		"DEFINED_KW", 
		"DEFINITIONS_KW", 
		"DOT", 
		"DOTDOT", 
		"DOTDOTDOT", 
		"EMBEDDED_KW", 
		"END_KW", 
		"ENUMERATED_KW", 
		"ERROR_KW", 
		"ERRORS_KW", 
		"EXCEPT_KW", 
		"EXCLAMATION", 
		"EXPLICIT_KW", 
		"EXPORTS_KW", 
		"EXTENSIBILITY_KW", 
		"EXTERNAL_KW", 
		"FALSE_KW", 
		"FROM_KW", 
		"GENERAL_STR_KW", 
		"GENERALIZED_TIME_KW", 
		"GRAPHIC_STR_KW", 
		"H_STRING", 
		"HDIG", 
		"IA5_STRING_KW", 
		"IDENTIFIER_KW", 
		"IMPLICIT_KW", 
		"IMPLIED_KW", 
		"IMPORTS_KW", 
		"INCLUDES_KW", 
		"INSTANCE_KW", 
		"INTEGER_KW", 
		"INTERSECTION", 
		"INTERSECTION_KW", 
		"ISO646_STR_KW", 
		"L_BRACE", 
		"L_BRACKET", 
		"L_PAREN", 
		"LESS", 
		"LINKED_KW", 
		"LOWER", 
		"MAX_KW", 
		"MIN_KW", 
		"MINUS", 
		"MINUS_INFINITY_KW", 
		"NULL_KW", 
		"NUMBER", 
		"NUMERIC_STR_KW", 
		"OBJECT_DESCRIPTOR_KW", 
		"OBJECT_KW", 
		"OCTET_KW", 
		"OF_KW", 
		"OID_KW", 
		"OPERATION_KW", 
		"OPTIONAL_KW", 
		"PARAMETER_KW", 
		"PATTERN_KW", 
		"PDV_KW", 
		"PLUS", 
		"PLUS_INFINITY_KW", 
		"PRESENT_KW", 
		"PRINTABLE_STR_KW", 
		"PRIVATE_KW", 
		"R_BRACE", 
		"R_BRACKET", 
		"R_PAREN", 
		"REAL_KW", 
		"RELATIVE_KW", 
		"RESULT_KW", 
		"SEMI", 
		"SEQUENCE_KW", 
		"SET_KW", 
		"SINGLE_QUOTE", 
		"SIZE_KW", 
		"SL_COMMENT", 
		"STRING_KW", 
		"T61_STR_KW", 
		"TAGS_KW", 
		"TELETEX_STR_KW", 
		"TRUE_KW", 
		"TYPE_IDENTIFIER_KW", 
		"UNION_KW", 
		"UNIQUE_KW", 
		"UNIVERSAL_KW", 
		"UNIVERSAL_STR_KW", 
		"UPPER", 
		"UTC_TIME_KW", 
		"UTF8_STR_KW", 
		"VIDEOTEX_STR_KW", 
		"VISIBLE_STR_KW", 
		"WITH_KW", 
		"WS", 
		"'ABSTRACT-BIND'", 
		"'ABSTRACT-ERROR'", 
		"'ABSTRACT-OPERATION'", 
		"'ABSTRACT-UNBIND'", 
		"'ACCESS'", 
		"'AGENT-CAPABILITIES'", 
		"'ALGORITHM'", 
		"'APPLICATION-CONTEXT'", 
		"'APPLICATION-SERVICE-ELEMENT'", 
		"'AUGMENTS'", 
		"'BIND'", 
		"'BITS'", 
		"'CONTACT-INFO'", 
		"'CREATION-REQUIRES'", 
		"'DEFVAL'", 
		"'DESCRIPTION'", 
		"'DISPLAY-HINT'", 
		"'ENCRYPTED'", 
		"'ENTERPRISE'", 
		"'EXTENDS'", 
		"'EXTENSION'", 
		"'EXTENSION-ATTRIBUTE'", 
		"'EXTENSIONS'", 
		"'GROUP'", 
		"'INDEX'", 
		"'INSTALL-ERRORS'", 
		"'LAST-UPDATED'", 
		"'MACRO'", 
		"'MANDATORY-GROUPS'", 
		"'MAX-ACCESS'", 
		"'MIN-ACCESS'", 
		"'MODULE'", 
		"'MODULE-COMPLIANCE'", 
		"'MODULE-IDENTITY'", 
		"'NOTIFICATION-GROUP'", 
		"'NOTIFICATIONS'", 
		"'NOTIFICATION-TYPE'", 
		"'OBJECT-GROUP'", 
		"'OBJECT-IDENTITY'", 
		"'OBJECTS'", 
		"'OBJECT-TYPE'", 
		"'ORGANIZATION'", 
		"'PIB-ACCESS'", 
		"'PIB-DEFINITIONS'", 
		"'PIB-INDEX'", 
		"'PIB-MIN-ACCESS'", 
		"'PIB-REFERENCES'", 
		"'PIB-TAG'", 
		"'PORT'", 
		"'PRODUCT-RELEASE'", 
		"'PROTECTED'", 
		"'REFERENCE'", 
		"'REFINE'", 
		"'RELATIVE-OID'", 
		"'REVISION'", 
		"'SECURITY-CATEGORY'", 
		"'SIGNATURE'", 
		"'SIGNED'", 
		"'STATUS'", 
		"'SUBJECT-CATEGORIES'", 
		"'SUPPORTS'", 
		"'SYNTAX'", 
		"'TEXTUAL-CONVENTION'", 
		"'TOKEN'", 
		"'TOKEN-DATA'", 
		"'TRAP-TYPE'", 
		"'UNBIND'", 
		"'UNIQUENESS'", 
		"'UNITS'", 
		"'VARIABLES'", 
		"'VARIATION'", 
		"'WRITE-SYNTAX'"
    };

    public const int EOF = -1;
    public const int T__126 = 126;
    public const int T__127 = 127;
    public const int T__128 = 128;
    public const int T__129 = 129;
    public const int T__130 = 130;
    public const int T__131 = 131;
    public const int T__132 = 132;
    public const int T__133 = 133;
    public const int T__134 = 134;
    public const int T__135 = 135;
    public const int T__136 = 136;
    public const int T__137 = 137;
    public const int T__138 = 138;
    public const int T__139 = 139;
    public const int T__140 = 140;
    public const int T__141 = 141;
    public const int T__142 = 142;
    public const int T__143 = 143;
    public const int T__144 = 144;
    public const int T__145 = 145;
    public const int T__146 = 146;
    public const int T__147 = 147;
    public const int T__148 = 148;
    public const int T__149 = 149;
    public const int T__150 = 150;
    public const int T__151 = 151;
    public const int T__152 = 152;
    public const int T__153 = 153;
    public const int T__154 = 154;
    public const int T__155 = 155;
    public const int T__156 = 156;
    public const int T__157 = 157;
    public const int T__158 = 158;
    public const int T__159 = 159;
    public const int T__160 = 160;
    public const int T__161 = 161;
    public const int T__162 = 162;
    public const int T__163 = 163;
    public const int T__164 = 164;
    public const int T__165 = 165;
    public const int T__166 = 166;
    public const int T__167 = 167;
    public const int T__168 = 168;
    public const int T__169 = 169;
    public const int T__170 = 170;
    public const int T__171 = 171;
    public const int T__172 = 172;
    public const int T__173 = 173;
    public const int T__174 = 174;
    public const int T__175 = 175;
    public const int T__176 = 176;
    public const int T__177 = 177;
    public const int T__178 = 178;
    public const int T__179 = 179;
    public const int T__180 = 180;
    public const int T__181 = 181;
    public const int T__182 = 182;
    public const int T__183 = 183;
    public const int T__184 = 184;
    public const int T__185 = 185;
    public const int T__186 = 186;
    public const int T__187 = 187;
    public const int T__188 = 188;
    public const int T__189 = 189;
    public const int T__190 = 190;
    public const int T__191 = 191;
    public const int T__192 = 192;
    public const int T__193 = 193;
    public const int T__194 = 194;
    public const int T__195 = 195;
    public const int T__196 = 196;
    public const int T__197 = 197;
    public const int ABSENT_KW = 4;
    public const int ABSTRACT_SYNTAX_KW = 5;
    public const int ALL_KW = 6;
    public const int ANY_KW = 7;
    public const int APPLICATION_KW = 8;
    public const int ARGUMENT_KW = 9;
    public const int ASSIGN_OP = 10;
    public const int AUTOMATIC_KW = 11;
    public const int B_OR_H_STRING = 12;
    public const int B_STRING = 13;
    public const int BAR = 14;
    public const int BASED_NUM_KW = 15;
    public const int BDIG = 16;
    public const int BEGIN_KW = 17;
    public const int BIT_KW = 18;
    public const int BMP_STR_KW = 19;
    public const int BOOLEAN_KW = 20;
    public const int BY_KW = 21;
    public const int C_STRING = 22;
    public const int CHARACTER_KW = 23;
    public const int CHARB = 24;
    public const int CHARH = 25;
    public const int CHOICE_KW = 26;
    public const int CLASS_KW = 27;
    public const int COLON = 28;
    public const int COMMA = 29;
    public const int COMMENT = 30;
    public const int COMPONENT_KW = 31;
    public const int COMPONENTS_KW = 32;
    public const int CONSTRAINED_KW = 33;
    public const int DEFAULT_KW = 34;
    public const int DEFINED_KW = 35;
    public const int DEFINITIONS_KW = 36;
    public const int DOT = 37;
    public const int DOTDOT = 38;
    public const int DOTDOTDOT = 39;
    public const int EMBEDDED_KW = 40;
    public const int END_KW = 41;
    public const int ENUMERATED_KW = 42;
    public const int ERROR_KW = 43;
    public const int ERRORS_KW = 44;
    public const int EXCEPT_KW = 45;
    public const int EXCLAMATION = 46;
    public const int EXPLICIT_KW = 47;
    public const int EXPORTS_KW = 48;
    public const int EXTENSIBILITY_KW = 49;
    public const int EXTERNAL_KW = 50;
    public const int FALSE_KW = 51;
    public const int FROM_KW = 52;
    public const int GENERAL_STR_KW = 53;
    public const int GENERALIZED_TIME_KW = 54;
    public const int GRAPHIC_STR_KW = 55;
    public const int H_STRING = 56;
    public const int HDIG = 57;
    public const int IA5_STRING_KW = 58;
    public const int IDENTIFIER_KW = 59;
    public const int IMPLICIT_KW = 60;
    public const int IMPLIED_KW = 61;
    public const int IMPORTS_KW = 62;
    public const int INCLUDES_KW = 63;
    public const int INSTANCE_KW = 64;
    public const int INTEGER_KW = 65;
    public const int INTERSECTION = 66;
    public const int INTERSECTION_KW = 67;
    public const int ISO646_STR_KW = 68;
    public const int L_BRACE = 69;
    public const int L_BRACKET = 70;
    public const int L_PAREN = 71;
    public const int LESS = 72;
    public const int LINKED_KW = 73;
    public const int LOWER = 74;
    public const int MAX_KW = 75;
    public const int MIN_KW = 76;
    public const int MINUS = 77;
    public const int MINUS_INFINITY_KW = 78;
    public const int NULL_KW = 79;
    public const int NUMBER = 80;
    public const int NUMERIC_STR_KW = 81;
    public const int OBJECT_DESCRIPTOR_KW = 82;
    public const int OBJECT_KW = 83;
    public const int OCTET_KW = 84;
    public const int OF_KW = 85;
    public const int OID_KW = 86;
    public const int OPERATION_KW = 87;
    public const int OPTIONAL_KW = 88;
    public const int PARAMETER_KW = 89;
    public const int PATTERN_KW = 90;
    public const int PDV_KW = 91;
    public const int PLUS = 92;
    public const int PLUS_INFINITY_KW = 93;
    public const int PRESENT_KW = 94;
    public const int PRINTABLE_STR_KW = 95;
    public const int PRIVATE_KW = 96;
    public const int R_BRACE = 97;
    public const int R_BRACKET = 98;
    public const int R_PAREN = 99;
    public const int REAL_KW = 100;
    public const int RELATIVE_KW = 101;
    public const int RESULT_KW = 102;
    public const int SEMI = 103;
    public const int SEQUENCE_KW = 104;
    public const int SET_KW = 105;
    public const int SINGLE_QUOTE = 106;
    public const int SIZE_KW = 107;
    public const int SL_COMMENT = 108;
    public const int STRING_KW = 109;
    public const int T61_STR_KW = 110;
    public const int TAGS_KW = 111;
    public const int TELETEX_STR_KW = 112;
    public const int TRUE_KW = 113;
    public const int TYPE_IDENTIFIER_KW = 114;
    public const int UNION_KW = 115;
    public const int UNIQUE_KW = 116;
    public const int UNIVERSAL_KW = 117;
    public const int UNIVERSAL_STR_KW = 118;
    public const int UPPER = 119;
    public const int UTC_TIME_KW = 120;
    public const int UTF8_STR_KW = 121;
    public const int VIDEOTEX_STR_KW = 122;
    public const int VISIBLE_STR_KW = 123;
    public const int WITH_KW = 124;
    public const int WS = 125;

    // delegates
    // delegators



        public SmiParser(ITokenStream input)
    		: this(input, new RecognizerSharedState()) {
        }

        public SmiParser(ITokenStream input, RecognizerSharedState state)
    		: base(input, state) {
            InitializeCyclicDFAs();

             
        }
        
    protected ITreeAdaptor adaptor = new CommonTreeAdaptor();

    public ITreeAdaptor TreeAdaptor
    {
        get { return this.adaptor; }
        set {
    	this.adaptor = value;
    	}
    }

    override public string[] TokenNames {
		get { return SmiParser.tokenNames; }
    }

    override public string GrammarFileName {
		get { return "Smi.g"; }
    }


    public class statement_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "statement"
    // Smi.g:593:0: statement : ( SL_COMMENT )* ( module_definition )* ;
    public SmiParser.statement_return statement() // throws RecognitionException [1]
    {   
        SmiParser.statement_return retval = new SmiParser.statement_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SL_COMMENT1 = null;
        SmiParser.module_definition_return module_definition2 = default(SmiParser.module_definition_return);


        CommonTree SL_COMMENT1_tree=null;

        try 
    	{
            // Smi.g:594:7: ( ( SL_COMMENT )* ( module_definition )* )
            // Smi.g:594:7: ( SL_COMMENT )* ( module_definition )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:594:7: ( SL_COMMENT )*
            	do 
            	{
            	    int alt1 = 2;
            	    int LA1_0 = input.LA(1);

            	    if ( (LA1_0 == SL_COMMENT) )
            	    {
            	        alt1 = 1;
            	    }


            	    switch (alt1) 
            		{
            			case 1 :
            			    // Smi.g:594:8: SL_COMMENT
            			    {
            			    	SL_COMMENT1=(IToken)Match(input,SL_COMMENT,FOLLOW_SL_COMMENT_in_statement1862); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{SL_COMMENT1_tree = (CommonTree)adaptor.Create(SL_COMMENT1);
            			    		adaptor.AddChild(root_0, SL_COMMENT1_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop1;
            	    }
            	} while (true);

            	loop1:
            		;	// Stops C# compiler whining that label 'loop1' has no statements

            	// Smi.g:594:21: ( module_definition )*
            	do 
            	{
            	    int alt2 = 2;
            	    int LA2_0 = input.LA(1);

            	    if ( (LA2_0 == UPPER) )
            	    {
            	        alt2 = 1;
            	    }


            	    switch (alt2) 
            		{
            			case 1 :
            			    // Smi.g:594:22: module_definition
            			    {
            			    	PushFollow(FOLLOW_module_definition_in_statement1867);
            			    	module_definition2 = module_definition();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_definition2.Tree);

            			    }
            			    break;

            			default:
            			    goto loop2;
            	    }
            	} while (true);

            	loop2:
            		;	// Stops C# compiler whining that label 'loop2' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "statement"

    public class module_definition_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_definition"
    // Smi.g:600:0: module_definition : module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW ;
    public SmiParser.module_definition_return module_definition() // throws RecognitionException [1]
    {   
        SmiParser.module_definition_return retval = new SmiParser.module_definition_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set4 = null;
        IToken set5 = null;
        IToken TAGS_KW6 = null;
        IToken EXTENSIBILITY_KW7 = null;
        IToken IMPLIED_KW8 = null;
        IToken ASSIGN_OP9 = null;
        IToken BEGIN_KW10 = null;
        IToken END_KW12 = null;
        SmiParser.module_identifier_return module_identifier3 = default(SmiParser.module_identifier_return);

        SmiParser.module_body_return module_body11 = default(SmiParser.module_body_return);


        CommonTree set4_tree=null;
        CommonTree set5_tree=null;
        CommonTree TAGS_KW6_tree=null;
        CommonTree EXTENSIBILITY_KW7_tree=null;
        CommonTree IMPLIED_KW8_tree=null;
        CommonTree ASSIGN_OP9_tree=null;
        CommonTree BEGIN_KW10_tree=null;
        CommonTree END_KW12_tree=null;

        try 
    	{
            // Smi.g:600:20: ( module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW )
            // Smi.g:600:20: module_identifier ( 'PIB-DEFINITIONS' | DEFINITIONS_KW ) ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )? ( EXTENSIBILITY_KW IMPLIED_KW )? ASSIGN_OP BEGIN_KW module_body END_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_module_identifier_in_module_definition1884);
            	module_identifier3 = module_identifier();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_identifier3.Tree);
            	set4 = (IToken)input.LT(1);
            	if ( input.LA(1) == DEFINITIONS_KW || input.LA(1) == 169 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set4));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}

            	// Smi.g:601:3: ( ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW )?
            	int alt3 = 2;
            	int LA3_0 = input.LA(1);

            	if ( (LA3_0 == AUTOMATIC_KW || LA3_0 == EXPLICIT_KW || LA3_0 == IMPLICIT_KW) )
            	{
            	    alt3 = 1;
            	}
            	switch (alt3) 
            	{
            	    case 1 :
            	        // Smi.g:601:5: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW ) TAGS_KW
            	        {
            	        	set5 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set5));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	TAGS_KW6=(IToken)Match(input,TAGS_KW,FOLLOW_TAGS_KW_in_module_definition1911); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{TAGS_KW6_tree = (CommonTree)adaptor.Create(TAGS_KW6);
            	        		adaptor.AddChild(root_0, TAGS_KW6_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:602:3: ( EXTENSIBILITY_KW IMPLIED_KW )?
            	int alt4 = 2;
            	int LA4_0 = input.LA(1);

            	if ( (LA4_0 == EXTENSIBILITY_KW) )
            	{
            	    alt4 = 1;
            	}
            	switch (alt4) 
            	{
            	    case 1 :
            	        // Smi.g:602:4: EXTENSIBILITY_KW IMPLIED_KW
            	        {
            	        	EXTENSIBILITY_KW7=(IToken)Match(input,EXTENSIBILITY_KW,FOLLOW_EXTENSIBILITY_KW_in_module_definition1920); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXTENSIBILITY_KW7_tree = (CommonTree)adaptor.Create(EXTENSIBILITY_KW7);
            	        		adaptor.AddChild(root_0, EXTENSIBILITY_KW7_tree);
            	        	}
            	        	IMPLIED_KW8=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_module_definition1922); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{IMPLIED_KW8_tree = (CommonTree)adaptor.Create(IMPLIED_KW8);
            	        		adaptor.AddChild(root_0, IMPLIED_KW8_tree);
            	        	}

            	        }
            	        break;

            	}

            	ASSIGN_OP9=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_module_definition1928); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ASSIGN_OP9_tree = (CommonTree)adaptor.Create(ASSIGN_OP9);
            		adaptor.AddChild(root_0, ASSIGN_OP9_tree);
            	}
            	BEGIN_KW10=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_module_definition1930); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BEGIN_KW10_tree = (CommonTree)adaptor.Create(BEGIN_KW10);
            		adaptor.AddChild(root_0, BEGIN_KW10_tree);
            	}
            	PushFollow(FOLLOW_module_body_in_module_definition1932);
            	module_body11 = module_body();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, module_body11.Tree);
            	END_KW12=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_module_definition1934); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{END_KW12_tree = (CommonTree)adaptor.Create(END_KW12);
            		adaptor.AddChild(root_0, END_KW12_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_definition"

    public class module_identifier_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_identifier"
    // Smi.g:605:0: module_identifier : UPPER ( obj_id_comp_lst )? ;
    public SmiParser.module_identifier_return module_identifier() // throws RecognitionException [1]
    {   
        SmiParser.module_identifier_return retval = new SmiParser.module_identifier_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER13 = null;
        SmiParser.obj_id_comp_lst_return obj_id_comp_lst14 = default(SmiParser.obj_id_comp_lst_return);


        CommonTree UPPER13_tree=null;

        try 
    	{
            // Smi.g:605:20: ( UPPER ( obj_id_comp_lst )? )
            // Smi.g:605:20: UPPER ( obj_id_comp_lst )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	UPPER13=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_module_identifier1941); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER13_tree = (CommonTree)adaptor.Create(UPPER13);
            		adaptor.AddChild(root_0, UPPER13_tree);
            	}
            	// Smi.g:605:26: ( obj_id_comp_lst )?
            	int alt5 = 2;
            	int LA5_0 = input.LA(1);

            	if ( (LA5_0 == L_BRACE) )
            	{
            	    alt5 = 1;
            	}
            	switch (alt5) 
            	{
            	    case 1 :
            	        // Smi.g:605:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_module_identifier1944);
            	        	obj_id_comp_lst14 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst14.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_identifier"

    public class module_body_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "module_body"
    // Smi.g:607:0: module_body : ( exports )? ( imports )? ( assignment )* ;
    public SmiParser.module_body_return module_body() // throws RecognitionException [1]
    {   
        SmiParser.module_body_return retval = new SmiParser.module_body_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.exports_return exports15 = default(SmiParser.exports_return);

        SmiParser.imports_return imports16 = default(SmiParser.imports_return);

        SmiParser.assignment_return assignment17 = default(SmiParser.assignment_return);



        try 
    	{
            // Smi.g:607:14: ( ( exports )? ( imports )? ( assignment )* )
            // Smi.g:607:14: ( exports )? ( imports )? ( assignment )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:607:14: ( exports )?
            	int alt6 = 2;
            	int LA6_0 = input.LA(1);

            	if ( (LA6_0 == EXPORTS_KW) )
            	{
            	    alt6 = 1;
            	}
            	switch (alt6) 
            	{
            	    case 1 :
            	        // Smi.g:607:15: exports
            	        {
            	        	PushFollow(FOLLOW_exports_in_module_body1955);
            	        	exports15 = exports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exports15.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:607:25: ( imports )?
            	int alt7 = 2;
            	int LA7_0 = input.LA(1);

            	if ( (LA7_0 == IMPORTS_KW) )
            	{
            	    alt7 = 1;
            	}
            	switch (alt7) 
            	{
            	    case 1 :
            	        // Smi.g:607:26: imports
            	        {
            	        	PushFollow(FOLLOW_imports_in_module_body1960);
            	        	imports16 = imports();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, imports16.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:607:36: ( assignment )*
            	do 
            	{
            	    int alt8 = 2;
            	    int LA8_0 = input.LA(1);

            	    if ( (LA8_0 == ERROR_KW || LA8_0 == LOWER || LA8_0 == OBJECT_KW || LA8_0 == OPERATION_KW || LA8_0 == UPPER || (LA8_0 >= 126 && LA8_0 <= 129) || (LA8_0 >= 131 && LA8_0 <= 134) || LA8_0 == 136 || LA8_0 == 143 || (LA8_0 >= 146 && LA8_0 <= 148) || (LA8_0 >= 158 && LA8_0 <= 160) || (LA8_0 >= 162 && LA8_0 <= 164) || LA8_0 == 166 || LA8_0 == 174 || LA8_0 == 176 || LA8_0 == 178 || (LA8_0 >= 181 && LA8_0 <= 183) || (LA8_0 >= 188 && LA8_0 <= 192)) )
            	    {
            	        alt8 = 1;
            	    }


            	    switch (alt8) 
            		{
            			case 1 :
            			    // Smi.g:607:37: assignment
            			    {
            			    	PushFollow(FOLLOW_assignment_in_module_body1965);
            			    	assignment17 = assignment();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, assignment17.Tree);

            			    }
            			    break;

            			default:
            			    goto loop8;
            	    }
            	} while (true);

            	loop8:
            		;	// Stops C# compiler whining that label 'loop8' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "module_body"

    public class obj_id_comp_lst_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "obj_id_comp_lst"
    // Smi.g:610:0: obj_id_comp_lst : L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE ;
    public SmiParser.obj_id_comp_lst_return obj_id_comp_lst() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_comp_lst_return retval = new SmiParser.obj_id_comp_lst_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE18 = null;
        IToken R_BRACE21 = null;
        SmiParser.defined_value_return defined_value19 = default(SmiParser.defined_value_return);

        SmiParser.obj_id_component_return obj_id_component20 = default(SmiParser.obj_id_component_return);


        CommonTree L_BRACE18_tree=null;
        CommonTree R_BRACE21_tree=null;

        try 
    	{
            // Smi.g:610:18: ( L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE )
            // Smi.g:610:18: L_BRACE (=> defined_value )? ( obj_id_component )+ R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE18=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_obj_id_comp_lst1977); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE18_tree = (CommonTree)adaptor.Create(L_BRACE18);
            		adaptor.AddChild(root_0, L_BRACE18_tree);
            	}
            	// Smi.g:610:26: (=> defined_value )?
            	int alt9 = 2;
            	int LA9_0 = input.LA(1);

            	if ( (LA9_0 == UPPER) && (synpred1_Smi()) )
            	{
            	    alt9 = 1;
            	}
            	else if ( (LA9_0 == LOWER) )
            	{
            	    int LA9_2 = input.LA(2);

            	    if ( (synpred1_Smi()) )
            	    {
            	        alt9 = 1;
            	    }
            	}
            	switch (alt9) 
            	{
            	    case 1 :
            	        // Smi.g:610:27: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_obj_id_comp_lst1992);
            	        	defined_value19 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value19.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:610:69: ( obj_id_component )+
            	int cnt10 = 0;
            	do 
            	{
            	    int alt10 = 2;
            	    int LA10_0 = input.LA(1);

            	    if ( (LA10_0 == LOWER || LA10_0 == NUMBER) )
            	    {
            	        alt10 = 1;
            	    }


            	    switch (alt10) 
            		{
            			case 1 :
            			    // Smi.g:610:70: obj_id_component
            			    {
            			    	PushFollow(FOLLOW_obj_id_component_in_obj_id_comp_lst1997);
            			    	obj_id_component20 = obj_id_component();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_component20.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt10 >= 1 ) goto loop10;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee10 =
            		                new EarlyExitException(10, input);
            		            throw eee10;
            	    }
            	    cnt10++;
            	} while (true);

            	loop10:
            		;	// Stops C# compiler whining that label 'loop10' has no statements

            	R_BRACE21=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_obj_id_comp_lst2001); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE21_tree = (CommonTree)adaptor.Create(R_BRACE21);
            		adaptor.AddChild(root_0, R_BRACE21_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_comp_lst"

    public class defined_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defined_value"
    // Smi.g:613:0: protected defined_value : ( UPPER DOT )? LOWER ;
    public SmiParser.defined_value_return defined_value() // throws RecognitionException [1]
    {   
        SmiParser.defined_value_return retval = new SmiParser.defined_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER22 = null;
        IToken DOT23 = null;
        IToken LOWER24 = null;

        CommonTree UPPER22_tree=null;
        CommonTree DOT23_tree=null;
        CommonTree LOWER24_tree=null;

        try 
    	{
            // Smi.g:613:26: ( ( UPPER DOT )? LOWER )
            // Smi.g:613:26: ( UPPER DOT )? LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:613:26: ( UPPER DOT )?
            	int alt11 = 2;
            	int LA11_0 = input.LA(1);

            	if ( (LA11_0 == UPPER) )
            	{
            	    alt11 = 1;
            	}
            	switch (alt11) 
            	{
            	    case 1 :
            	        // Smi.g:613:27: UPPER DOT
            	        {
            	        	UPPER22=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_value2012); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER22_tree = (CommonTree)adaptor.Create(UPPER22);
            	        		adaptor.AddChild(root_0, UPPER22_tree);
            	        	}
            	        	DOT23=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_value2014); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT23_tree = (CommonTree)adaptor.Create(DOT23);
            	        		adaptor.AddChild(root_0, DOT23_tree);
            	        	}

            	        }
            	        break;

            	}

            	LOWER24=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_defined_value2018); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER24_tree = (CommonTree)adaptor.Create(LOWER24);
            		adaptor.AddChild(root_0, LOWER24_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_value"

    public class obj_id_component_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "obj_id_component"
    // Smi.g:616:0: obj_id_component : ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? );
    public SmiParser.obj_id_component_return obj_id_component() // throws RecognitionException [1]
    {   
        SmiParser.obj_id_component_return retval = new SmiParser.obj_id_component_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUMBER25 = null;
        IToken LOWER26 = null;
        IToken L_PAREN27 = null;
        IToken NUMBER28 = null;
        IToken R_PAREN29 = null;

        CommonTree NUMBER25_tree=null;
        CommonTree LOWER26_tree=null;
        CommonTree L_PAREN27_tree=null;
        CommonTree NUMBER28_tree=null;
        CommonTree R_PAREN29_tree=null;

        try 
    	{
            // Smi.g:616:19: ( NUMBER | LOWER ( L_PAREN NUMBER R_PAREN )? )
            int alt13 = 2;
            int LA13_0 = input.LA(1);

            if ( (LA13_0 == NUMBER) )
            {
                alt13 = 1;
            }
            else if ( (LA13_0 == LOWER) )
            {
                alt13 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d13s0 =
                    new NoViableAltException("", 13, 0, input);

                throw nvae_d13s0;
            }
            switch (alt13) 
            {
                case 1 :
                    // Smi.g:616:19: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER25=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component2028); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER25_tree = (CommonTree)adaptor.Create(NUMBER25);
                    		adaptor.AddChild(root_0, NUMBER25_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:617:19: LOWER ( L_PAREN NUMBER R_PAREN )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER26=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_obj_id_component2049); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER26_tree = (CommonTree)adaptor.Create(LOWER26);
                    		adaptor.AddChild(root_0, LOWER26_tree);
                    	}
                    	// Smi.g:617:25: ( L_PAREN NUMBER R_PAREN )?
                    	int alt12 = 2;
                    	int LA12_0 = input.LA(1);

                    	if ( (LA12_0 == L_PAREN) )
                    	{
                    	    alt12 = 1;
                    	}
                    	switch (alt12) 
                    	{
                    	    case 1 :
                    	        // Smi.g:617:26: L_PAREN NUMBER R_PAREN
                    	        {
                    	        	L_PAREN27=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_obj_id_component2052); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_PAREN27_tree = (CommonTree)adaptor.Create(L_PAREN27);
                    	        		adaptor.AddChild(root_0, L_PAREN27_tree);
                    	        	}
                    	        	NUMBER28=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_obj_id_component2054); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{NUMBER28_tree = (CommonTree)adaptor.Create(NUMBER28);
                    	        		adaptor.AddChild(root_0, NUMBER28_tree);
                    	        	}
                    	        	R_PAREN29=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_obj_id_component2056); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_PAREN29_tree = (CommonTree)adaptor.Create(R_PAREN29);
                    	        		adaptor.AddChild(root_0, R_PAREN29_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "obj_id_component"

    public class tag_default_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tag_default"
    // Smi.g:623:0: tag_default : ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW );
    public SmiParser.tag_default_return tag_default() // throws RecognitionException [1]
    {   
        SmiParser.tag_default_return retval = new SmiParser.tag_default_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set30 = null;

        CommonTree set30_tree=null;

        try 
    	{
            // Smi.g:623:14: ( EXPLICIT_KW | IMPLICIT_KW | AUTOMATIC_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set30 = (IToken)input.LT(1);
            	if ( input.LA(1) == AUTOMATIC_KW || input.LA(1) == EXPLICIT_KW || input.LA(1) == IMPLICIT_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set30));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag_default"

    public class exports_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exports"
    // Smi.g:625:0: exports : EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI ;
    public SmiParser.exports_return exports() // throws RecognitionException [1]
    {   
        SmiParser.exports_return retval = new SmiParser.exports_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXPORTS_KW31 = null;
        IToken ALL_KW33 = null;
        IToken SEMI34 = null;
        SmiParser.symbol_list_return symbol_list32 = default(SmiParser.symbol_list_return);


        CommonTree EXPORTS_KW31_tree=null;
        CommonTree ALL_KW33_tree=null;
        CommonTree SEMI34_tree=null;

        try 
    	{
            // Smi.g:625:10: ( EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI )
            // Smi.g:625:10: EXPORTS_KW ( ( symbol_list )? | ALL_KW ) SEMI
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXPORTS_KW31=(IToken)Match(input,EXPORTS_KW,FOLLOW_EXPORTS_KW_in_exports2084); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXPORTS_KW31_tree = (CommonTree)adaptor.Create(EXPORTS_KW31);
            		adaptor.AddChild(root_0, EXPORTS_KW31_tree);
            	}
            	// Smi.g:625:21: ( ( symbol_list )? | ALL_KW )
            	int alt15 = 2;
            	int LA15_0 = input.LA(1);

            	if ( (LA15_0 == ERROR_KW || LA15_0 == LOWER || LA15_0 == OBJECT_KW || LA15_0 == OPERATION_KW || LA15_0 == SEMI || LA15_0 == UPPER || (LA15_0 >= 126 && LA15_0 <= 129) || (LA15_0 >= 131 && LA15_0 <= 134) || LA15_0 == 136 || LA15_0 == 143 || (LA15_0 >= 146 && LA15_0 <= 148) || (LA15_0 >= 158 && LA15_0 <= 160) || (LA15_0 >= 162 && LA15_0 <= 164) || LA15_0 == 166 || LA15_0 == 174 || LA15_0 == 176 || LA15_0 == 178 || (LA15_0 >= 181 && LA15_0 <= 183) || (LA15_0 >= 188 && LA15_0 <= 192)) )
            	{
            	    alt15 = 1;
            	}
            	else if ( (LA15_0 == ALL_KW) )
            	{
            	    alt15 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d15s0 =
            	        new NoViableAltException("", 15, 0, input);

            	    throw nvae_d15s0;
            	}
            	switch (alt15) 
            	{
            	    case 1 :
            	        // Smi.g:625:23: ( symbol_list )?
            	        {
            	        	// Smi.g:625:23: ( symbol_list )?
            	        	int alt14 = 2;
            	        	int LA14_0 = input.LA(1);

            	        	if ( (LA14_0 == ERROR_KW || LA14_0 == LOWER || LA14_0 == OBJECT_KW || LA14_0 == OPERATION_KW || LA14_0 == UPPER || (LA14_0 >= 126 && LA14_0 <= 129) || (LA14_0 >= 131 && LA14_0 <= 134) || LA14_0 == 136 || LA14_0 == 143 || (LA14_0 >= 146 && LA14_0 <= 148) || (LA14_0 >= 158 && LA14_0 <= 160) || (LA14_0 >= 162 && LA14_0 <= 164) || LA14_0 == 166 || LA14_0 == 174 || LA14_0 == 176 || LA14_0 == 178 || (LA14_0 >= 181 && LA14_0 <= 183) || (LA14_0 >= 188 && LA14_0 <= 192)) )
            	        	{
            	        	    alt14 = 1;
            	        	}
            	        	switch (alt14) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:625:24: symbol_list
            	        	        {
            	        	        	PushFollow(FOLLOW_symbol_list_in_exports2089);
            	        	        	symbol_list32 = symbol_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list32.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:625:40: ALL_KW
            	        {
            	        	ALL_KW33=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_exports2095); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ALL_KW33_tree = (CommonTree)adaptor.Create(ALL_KW33);
            	        		adaptor.AddChild(root_0, ALL_KW33_tree);
            	        	}

            	        }
            	        break;

            	}

            	SEMI34=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_exports2099); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI34_tree = (CommonTree)adaptor.Create(SEMI34);
            		adaptor.AddChild(root_0, SEMI34_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exports"

    public class imports_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "imports"
    // Smi.g:627:0: imports : IMPORTS_KW ( symbols_from_module )* SEMI ;
    public SmiParser.imports_return imports() // throws RecognitionException [1]
    {   
        SmiParser.imports_return retval = new SmiParser.imports_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken IMPORTS_KW35 = null;
        IToken SEMI37 = null;
        SmiParser.symbols_from_module_return symbols_from_module36 = default(SmiParser.symbols_from_module_return);


        CommonTree IMPORTS_KW35_tree=null;
        CommonTree SEMI37_tree=null;

        try 
    	{
            // Smi.g:627:10: ( IMPORTS_KW ( symbols_from_module )* SEMI )
            // Smi.g:627:10: IMPORTS_KW ( symbols_from_module )* SEMI
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	IMPORTS_KW35=(IToken)Match(input,IMPORTS_KW,FOLLOW_IMPORTS_KW_in_imports2106); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IMPORTS_KW35_tree = (CommonTree)adaptor.Create(IMPORTS_KW35);
            		adaptor.AddChild(root_0, IMPORTS_KW35_tree);
            	}
            	// Smi.g:627:21: ( symbols_from_module )*
            	do 
            	{
            	    int alt16 = 2;
            	    int LA16_0 = input.LA(1);

            	    if ( (LA16_0 == ERROR_KW || LA16_0 == LOWER || LA16_0 == OBJECT_KW || LA16_0 == OPERATION_KW || LA16_0 == UPPER || (LA16_0 >= 126 && LA16_0 <= 129) || (LA16_0 >= 131 && LA16_0 <= 134) || LA16_0 == 136 || LA16_0 == 143 || (LA16_0 >= 146 && LA16_0 <= 148) || (LA16_0 >= 158 && LA16_0 <= 160) || (LA16_0 >= 162 && LA16_0 <= 164) || LA16_0 == 166 || LA16_0 == 174 || LA16_0 == 176 || LA16_0 == 178 || (LA16_0 >= 181 && LA16_0 <= 183) || (LA16_0 >= 188 && LA16_0 <= 192)) )
            	    {
            	        alt16 = 1;
            	    }


            	    switch (alt16) 
            		{
            			case 1 :
            			    // Smi.g:627:22: symbols_from_module
            			    {
            			    	PushFollow(FOLLOW_symbols_from_module_in_imports2109);
            			    	symbols_from_module36 = symbols_from_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbols_from_module36.Tree);

            			    }
            			    break;

            			default:
            			    goto loop16;
            	    }
            	} while (true);

            	loop16:
            		;	// Stops C# compiler whining that label 'loop16' has no statements

            	SEMI37=(IToken)Match(input,SEMI,FOLLOW_SEMI_in_imports2113); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEMI37_tree = (CommonTree)adaptor.Create(SEMI37);
            		adaptor.AddChild(root_0, SEMI37_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "imports"

    public class assignment_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "assignment"
    // Smi.g:630:0: assignment : ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW );
    public SmiParser.assignment_return assignment() // throws RecognitionException [1]
    {   
        SmiParser.assignment_return retval = new SmiParser.assignment_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER38 = null;
        IToken ASSIGN_OP39 = null;
        IToken LOWER41 = null;
        IToken ASSIGN_OP43 = null;
        IToken UPPER45 = null;
        IToken string_literal47 = null;
        IToken ASSIGN_OP48 = null;
        IToken BEGIN_KW49 = null;
        IToken set50 = null;
        IToken END_KW51 = null;
        SmiParser.type_return type40 = default(SmiParser.type_return);

        SmiParser.type_return type42 = default(SmiParser.type_return);

        SmiParser.value_return value44 = default(SmiParser.value_return);

        SmiParser.macroName_return macroName46 = default(SmiParser.macroName_return);


        CommonTree UPPER38_tree=null;
        CommonTree ASSIGN_OP39_tree=null;
        CommonTree LOWER41_tree=null;
        CommonTree ASSIGN_OP43_tree=null;
        CommonTree UPPER45_tree=null;
        CommonTree string_literal47_tree=null;
        CommonTree ASSIGN_OP48_tree=null;
        CommonTree BEGIN_KW49_tree=null;
        CommonTree set50_tree=null;
        CommonTree END_KW51_tree=null;

        try 
    	{
            // Smi.g:630:13: ( UPPER ASSIGN_OP type | LOWER type ASSIGN_OP value | ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW )
            int alt19 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                int LA19_1 = input.LA(2);

                if ( (LA19_1 == ASSIGN_OP) )
                {
                    alt19 = 1;
                }
                else if ( (LA19_1 == 153) )
                {
                    alt19 = 3;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d19s1 =
                        new NoViableAltException("", 19, 1, input);

                    throw nvae_d19s1;
                }
                }
                break;
            case LOWER:
            	{
                alt19 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt19 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d19s0 =
            	        new NoViableAltException("", 19, 0, input);

            	    throw nvae_d19s0;
            }

            switch (alt19) 
            {
                case 1 :
                    // Smi.g:630:13: UPPER ASSIGN_OP type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER38=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2123); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER38_tree = (CommonTree)adaptor.Create(UPPER38);
                    		adaptor.AddChild(root_0, UPPER38_tree);
                    	}
                    	ASSIGN_OP39=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2125); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP39_tree = (CommonTree)adaptor.Create(ASSIGN_OP39);
                    		adaptor.AddChild(root_0, ASSIGN_OP39_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2127);
                    	type40 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type40.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:631:13: LOWER type ASSIGN_OP value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER41=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_assignment2142); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER41_tree = (CommonTree)adaptor.Create(LOWER41);
                    		adaptor.AddChild(root_0, LOWER41_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_assignment2144);
                    	type42 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type42.Tree);
                    	ASSIGN_OP43=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2146); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP43_tree = (CommonTree)adaptor.Create(ASSIGN_OP43);
                    		adaptor.AddChild(root_0, ASSIGN_OP43_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_assignment2148);
                    	value44 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value44.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:632:13: ( UPPER | macroName ) 'MACRO' ASSIGN_OP BEGIN_KW (~ ( END_KW ) )* END_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:632:13: ( UPPER | macroName )
                    	int alt17 = 2;
                    	int LA17_0 = input.LA(1);

                    	if ( (LA17_0 == UPPER) )
                    	{
                    	    alt17 = 1;
                    	}
                    	else if ( (LA17_0 == ERROR_KW || LA17_0 == OBJECT_KW || LA17_0 == OPERATION_KW || (LA17_0 >= 126 && LA17_0 <= 129) || (LA17_0 >= 131 && LA17_0 <= 134) || LA17_0 == 136 || LA17_0 == 143 || (LA17_0 >= 146 && LA17_0 <= 148) || (LA17_0 >= 158 && LA17_0 <= 160) || (LA17_0 >= 162 && LA17_0 <= 164) || LA17_0 == 166 || LA17_0 == 174 || LA17_0 == 176 || LA17_0 == 178 || (LA17_0 >= 181 && LA17_0 <= 183) || (LA17_0 >= 188 && LA17_0 <= 192)) )
                    	{
                    	    alt17 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d17s0 =
                    	        new NoViableAltException("", 17, 0, input);

                    	    throw nvae_d17s0;
                    	}
                    	switch (alt17) 
                    	{
                    	    case 1 :
                    	        // Smi.g:632:14: UPPER
                    	        {
                    	        	UPPER45=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_assignment2164); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{UPPER45_tree = (CommonTree)adaptor.Create(UPPER45);
                    	        		adaptor.AddChild(root_0, UPPER45_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:632:22: macroName
                    	        {
                    	        	PushFollow(FOLLOW_macroName_in_assignment2168);
                    	        	macroName46 = macroName();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName46.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal47=(IToken)Match(input,153,FOLLOW_153_in_assignment2171); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal47_tree = (CommonTree)adaptor.Create(string_literal47);
                    		adaptor.AddChild(root_0, string_literal47_tree);
                    	}
                    	ASSIGN_OP48=(IToken)Match(input,ASSIGN_OP,FOLLOW_ASSIGN_OP_in_assignment2173); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ASSIGN_OP48_tree = (CommonTree)adaptor.Create(ASSIGN_OP48);
                    		adaptor.AddChild(root_0, ASSIGN_OP48_tree);
                    	}
                    	BEGIN_KW49=(IToken)Match(input,BEGIN_KW,FOLLOW_BEGIN_KW_in_assignment2175); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{BEGIN_KW49_tree = (CommonTree)adaptor.Create(BEGIN_KW49);
                    		adaptor.AddChild(root_0, BEGIN_KW49_tree);
                    	}
                    	// Smi.g:632:60: (~ ( END_KW ) )*
                    	do 
                    	{
                    	    int alt18 = 2;
                    	    int LA18_0 = input.LA(1);

                    	    if ( ((LA18_0 >= ABSENT_KW && LA18_0 <= EMBEDDED_KW) || (LA18_0 >= ENUMERATED_KW && LA18_0 <= 197)) )
                    	    {
                    	        alt18 = 1;
                    	    }


                    	    switch (alt18) 
                    		{
                    			case 1 :
                    			    // Smi.g:
                    			    {
                    			    	set50 = (IToken)input.LT(1);
                    			    	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= EMBEDDED_KW) || (input.LA(1) >= ENUMERATED_KW && input.LA(1) <= 197) ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set50));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}


                    			    }
                    			    break;

                    			default:
                    			    goto loop18;
                    	    }
                    	} while (true);

                    	loop18:
                    		;	// Stops C# compiler whining that label 'loop18' has no statements

                    	END_KW51=(IToken)Match(input,END_KW,FOLLOW_END_KW_in_assignment2185); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{END_KW51_tree = (CommonTree)adaptor.Create(END_KW51);
                    		adaptor.AddChild(root_0, END_KW51_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "assignment"

    public class symbol_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbol_list"
    // Smi.g:640:0: symbol_list : symbol ( COMMA symbol )* ;
    public SmiParser.symbol_list_return symbol_list() // throws RecognitionException [1]
    {   
        SmiParser.symbol_list_return retval = new SmiParser.symbol_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA53 = null;
        SmiParser.symbol_return symbol52 = default(SmiParser.symbol_return);

        SmiParser.symbol_return symbol54 = default(SmiParser.symbol_return);


        CommonTree COMMA53_tree=null;

        try 
    	{
            // Smi.g:640:14: ( symbol ( COMMA symbol )* )
            // Smi.g:640:14: symbol ( COMMA symbol )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_in_symbol_list2199);
            	symbol52 = symbol();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol52.Tree);
            	// Smi.g:640:21: ( COMMA symbol )*
            	do 
            	{
            	    int alt20 = 2;
            	    int LA20_0 = input.LA(1);

            	    if ( (LA20_0 == COMMA) )
            	    {
            	        alt20 = 1;
            	    }


            	    switch (alt20) 
            		{
            			case 1 :
            			    // Smi.g:640:22: COMMA symbol
            			    {
            			    	COMMA53=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_symbol_list2202); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA53_tree = (CommonTree)adaptor.Create(COMMA53);
            			    		adaptor.AddChild(root_0, COMMA53_tree);
            			    	}
            			    	PushFollow(FOLLOW_symbol_in_symbol_list2204);
            			    	symbol54 = symbol();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol54.Tree);

            			    }
            			    break;

            			default:
            			    goto loop20;
            	    }
            	} while (true);

            	loop20:
            		;	// Stops C# compiler whining that label 'loop20' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol_list"

    public class symbols_from_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbols_from_module"
    // Smi.g:642:0: symbols_from_module : symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? ;
    public SmiParser.symbols_from_module_return symbols_from_module() // throws RecognitionException [1]
    {   
        SmiParser.symbols_from_module_return retval = new SmiParser.symbols_from_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken FROM_KW56 = null;
        IToken UPPER57 = null;
        SmiParser.symbol_list_return symbol_list55 = default(SmiParser.symbol_list_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst58 = default(SmiParser.obj_id_comp_lst_return);

        SmiParser.defined_value_return defined_value59 = default(SmiParser.defined_value_return);


        CommonTree FROM_KW56_tree=null;
        CommonTree UPPER57_tree=null;

        try 
    	{
            // Smi.g:642:22: ( symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )? )
            // Smi.g:642:22: symbol_list FROM_KW UPPER ( obj_id_comp_lst |=> defined_value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_symbol_list_in_symbols_from_module2214);
            	symbol_list55 = symbol_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, symbol_list55.Tree);
            	FROM_KW56=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_symbols_from_module2216); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{FROM_KW56_tree = (CommonTree)adaptor.Create(FROM_KW56);
            		adaptor.AddChild(root_0, FROM_KW56_tree);
            	}
            	UPPER57=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbols_from_module2218); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER57_tree = (CommonTree)adaptor.Create(UPPER57);
            		adaptor.AddChild(root_0, UPPER57_tree);
            	}
            	// Smi.g:643:25: ( obj_id_comp_lst |=> defined_value )?
            	int alt21 = 3;
            	alt21 = dfa21.Predict(input);
            	switch (alt21) 
            	{
            	    case 1 :
            	        // Smi.g:643:27: obj_id_comp_lst
            	        {
            	        	PushFollow(FOLLOW_obj_id_comp_lst_in_symbols_from_module2247);
            	        	obj_id_comp_lst58 = obj_id_comp_lst();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst58.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:644:29: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_symbols_from_module2284);
            	        	defined_value59 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value59.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbols_from_module"

    public class symbol_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "symbol"
    // Smi.g:647:0: symbol : ( UPPER | LOWER | macroName );
    public SmiParser.symbol_return symbol() // throws RecognitionException [1]
    {   
        SmiParser.symbol_return retval = new SmiParser.symbol_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER60 = null;
        IToken LOWER61 = null;
        SmiParser.macroName_return macroName62 = default(SmiParser.macroName_return);


        CommonTree UPPER60_tree=null;
        CommonTree LOWER61_tree=null;

        try 
    	{
            // Smi.g:647:9: ( UPPER | LOWER | macroName )
            int alt22 = 3;
            switch ( input.LA(1) ) 
            {
            case UPPER:
            	{
                alt22 = 1;
                }
                break;
            case LOWER:
            	{
                alt22 = 2;
                }
                break;
            case ERROR_KW:
            case OBJECT_KW:
            case OPERATION_KW:
            case 126:
            case 127:
            case 128:
            case 129:
            case 131:
            case 132:
            case 133:
            case 134:
            case 136:
            case 143:
            case 146:
            case 147:
            case 148:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 174:
            case 176:
            case 178:
            case 181:
            case 182:
            case 183:
            case 188:
            case 189:
            case 190:
            case 191:
            case 192:
            	{
                alt22 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d22s0 =
            	        new NoViableAltException("", 22, 0, input);

            	    throw nvae_d22s0;
            }

            switch (alt22) 
            {
                case 1 :
                    // Smi.g:647:9: UPPER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER60=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_symbol2320); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER60_tree = (CommonTree)adaptor.Create(UPPER60);
                    		adaptor.AddChild(root_0, UPPER60_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:647:17: LOWER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER61=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_symbol2324); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER61_tree = (CommonTree)adaptor.Create(LOWER61);
                    		adaptor.AddChild(root_0, LOWER61_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:647:25: macroName
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macroName_in_symbol2328);
                    	macroName62 = macroName();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macroName62.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "symbol"

    public class macroName_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "macroName"
    // Smi.g:649:0: macroName : ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros );
    public SmiParser.macroName_return macroName() // throws RecognitionException [1]
    {   
        SmiParser.macroName_return retval = new SmiParser.macroName_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OPERATION_KW63 = null;
        IToken ERROR_KW64 = null;
        IToken string_literal65 = null;
        IToken string_literal66 = null;
        IToken string_literal67 = null;
        IToken string_literal68 = null;
        IToken string_literal69 = null;
        IToken string_literal70 = null;
        IToken string_literal71 = null;
        IToken string_literal72 = null;
        IToken string_literal73 = null;
        IToken string_literal74 = null;
        IToken string_literal75 = null;
        IToken string_literal76 = null;
        IToken string_literal77 = null;
        IToken string_literal78 = null;
        IToken string_literal79 = null;
        IToken string_literal80 = null;
        IToken string_literal81 = null;
        IToken string_literal82 = null;
        IToken string_literal83 = null;
        IToken string_literal84 = null;
        IToken string_literal85 = null;
        IToken string_literal86 = null;
        SmiParser.smi_macros_return smi_macros87 = default(SmiParser.smi_macros_return);


        CommonTree OPERATION_KW63_tree=null;
        CommonTree ERROR_KW64_tree=null;
        CommonTree string_literal65_tree=null;
        CommonTree string_literal66_tree=null;
        CommonTree string_literal67_tree=null;
        CommonTree string_literal68_tree=null;
        CommonTree string_literal69_tree=null;
        CommonTree string_literal70_tree=null;
        CommonTree string_literal71_tree=null;
        CommonTree string_literal72_tree=null;
        CommonTree string_literal73_tree=null;
        CommonTree string_literal74_tree=null;
        CommonTree string_literal75_tree=null;
        CommonTree string_literal76_tree=null;
        CommonTree string_literal77_tree=null;
        CommonTree string_literal78_tree=null;
        CommonTree string_literal79_tree=null;
        CommonTree string_literal80_tree=null;
        CommonTree string_literal81_tree=null;
        CommonTree string_literal82_tree=null;
        CommonTree string_literal83_tree=null;
        CommonTree string_literal84_tree=null;
        CommonTree string_literal85_tree=null;
        CommonTree string_literal86_tree=null;

        try 
    	{
            // Smi.g:649:12: ( OPERATION_KW | ERROR_KW | 'BIND' | 'UNBIND' | 'APPLICATION-SERVICE-ELEMENT' | 'APPLICATION-CONTEXT' | 'EXTENSION' | 'EXTENSIONS' | 'EXTENSION-ATTRIBUTE' | 'TOKEN' | 'TOKEN-DATA' | 'SECURITY-CATEGORY' | 'OBJECT' | 'PORT' | 'REFINE' | 'ABSTRACT-BIND' | 'ABSTRACT-UNBIND' | 'ABSTRACT-OPERATION' | 'ABSTRACT-ERROR' | 'ALGORITHM' | 'ENCRYPTED' | 'SIGNED' | 'SIGNATURE' | 'PROTECTED' | smi_macros )
            int alt23 = 25;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt23 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt23 = 2;
                }
                break;
            case 136:
            	{
                alt23 = 3;
                }
                break;
            case 192:
            	{
                alt23 = 4;
                }
                break;
            case 134:
            	{
                alt23 = 5;
                }
                break;
            case 133:
            	{
                alt23 = 6;
                }
                break;
            case 146:
            	{
                alt23 = 7;
                }
                break;
            case 148:
            	{
                alt23 = 8;
                }
                break;
            case 147:
            	{
                alt23 = 9;
                }
                break;
            case 189:
            	{
                alt23 = 10;
                }
                break;
            case 190:
            	{
                alt23 = 11;
                }
                break;
            case 181:
            	{
                alt23 = 12;
                }
                break;
            case OBJECT_KW:
            	{
                alt23 = 13;
                }
                break;
            case 174:
            	{
                alt23 = 14;
                }
                break;
            case 178:
            	{
                alt23 = 15;
                }
                break;
            case 126:
            	{
                alt23 = 16;
                }
                break;
            case 129:
            	{
                alt23 = 17;
                }
                break;
            case 128:
            	{
                alt23 = 18;
                }
                break;
            case 127:
            	{
                alt23 = 19;
                }
                break;
            case 132:
            	{
                alt23 = 20;
                }
                break;
            case 143:
            	{
                alt23 = 21;
                }
                break;
            case 183:
            	{
                alt23 = 22;
                }
                break;
            case 182:
            	{
                alt23 = 23;
                }
                break;
            case 176:
            	{
                alt23 = 24;
                }
                break;
            case 131:
            case 158:
            case 159:
            case 160:
            case 162:
            case 163:
            case 164:
            case 166:
            case 188:
            case 191:
            	{
                alt23 = 25;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d23s0 =
            	        new NoViableAltException("", 23, 0, input);

            	    throw nvae_d23s0;
            }

            switch (alt23) 
            {
                case 1 :
                    // Smi.g:649:12: OPERATION_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OPERATION_KW63=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_macroName2335); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OPERATION_KW63_tree = (CommonTree)adaptor.Create(OPERATION_KW63);
                    		adaptor.AddChild(root_0, OPERATION_KW63_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:649:27: ERROR_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ERROR_KW64=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_macroName2339); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ERROR_KW64_tree = (CommonTree)adaptor.Create(ERROR_KW64);
                    		adaptor.AddChild(root_0, ERROR_KW64_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:649:39: 'BIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal65=(IToken)Match(input,136,FOLLOW_136_in_macroName2344); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal65_tree = (CommonTree)adaptor.Create(string_literal65);
                    		adaptor.AddChild(root_0, string_literal65_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:649:48: 'UNBIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal66=(IToken)Match(input,192,FOLLOW_192_in_macroName2348); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal66_tree = (CommonTree)adaptor.Create(string_literal66);
                    		adaptor.AddChild(root_0, string_literal66_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:650:12: 'APPLICATION-SERVICE-ELEMENT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal67=(IToken)Match(input,134,FOLLOW_134_in_macroName2362); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal67_tree = (CommonTree)adaptor.Create(string_literal67);
                    		adaptor.AddChild(root_0, string_literal67_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:650:44: 'APPLICATION-CONTEXT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal68=(IToken)Match(input,133,FOLLOW_133_in_macroName2366); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal68_tree = (CommonTree)adaptor.Create(string_literal68);
                    		adaptor.AddChild(root_0, string_literal68_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:650:68: 'EXTENSION'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal69=(IToken)Match(input,146,FOLLOW_146_in_macroName2370); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal69_tree = (CommonTree)adaptor.Create(string_literal69);
                    		adaptor.AddChild(root_0, string_literal69_tree);
                    	}

                    }
                    break;
                case 8 :
                    // Smi.g:651:12: 'EXTENSIONS'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal70=(IToken)Match(input,148,FOLLOW_148_in_macroName2384); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal70_tree = (CommonTree)adaptor.Create(string_literal70);
                    		adaptor.AddChild(root_0, string_literal70_tree);
                    	}

                    }
                    break;
                case 9 :
                    // Smi.g:651:27: 'EXTENSION-ATTRIBUTE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal71=(IToken)Match(input,147,FOLLOW_147_in_macroName2388); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal71_tree = (CommonTree)adaptor.Create(string_literal71);
                    		adaptor.AddChild(root_0, string_literal71_tree);
                    	}

                    }
                    break;
                case 10 :
                    // Smi.g:651:51: 'TOKEN'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal72=(IToken)Match(input,189,FOLLOW_189_in_macroName2392); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal72_tree = (CommonTree)adaptor.Create(string_literal72);
                    		adaptor.AddChild(root_0, string_literal72_tree);
                    	}

                    }
                    break;
                case 11 :
                    // Smi.g:651:61: 'TOKEN-DATA'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal73=(IToken)Match(input,190,FOLLOW_190_in_macroName2396); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal73_tree = (CommonTree)adaptor.Create(string_literal73);
                    		adaptor.AddChild(root_0, string_literal73_tree);
                    	}

                    }
                    break;
                case 12 :
                    // Smi.g:652:5: 'SECURITY-CATEGORY'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal74=(IToken)Match(input,181,FOLLOW_181_in_macroName2403); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal74_tree = (CommonTree)adaptor.Create(string_literal74);
                    		adaptor.AddChild(root_0, string_literal74_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:652:27: 'OBJECT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal75=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_macroName2407); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal75_tree = (CommonTree)adaptor.Create(string_literal75);
                    		adaptor.AddChild(root_0, string_literal75_tree);
                    	}

                    }
                    break;
                case 14 :
                    // Smi.g:652:38: 'PORT'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal76=(IToken)Match(input,174,FOLLOW_174_in_macroName2411); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal76_tree = (CommonTree)adaptor.Create(string_literal76);
                    		adaptor.AddChild(root_0, string_literal76_tree);
                    	}

                    }
                    break;
                case 15 :
                    // Smi.g:652:47: 'REFINE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal77=(IToken)Match(input,178,FOLLOW_178_in_macroName2415); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal77_tree = (CommonTree)adaptor.Create(string_literal77);
                    		adaptor.AddChild(root_0, string_literal77_tree);
                    	}

                    }
                    break;
                case 16 :
                    // Smi.g:652:58: 'ABSTRACT-BIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal78=(IToken)Match(input,126,FOLLOW_126_in_macroName2419); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal78_tree = (CommonTree)adaptor.Create(string_literal78);
                    		adaptor.AddChild(root_0, string_literal78_tree);
                    	}

                    }
                    break;
                case 17 :
                    // Smi.g:653:5: 'ABSTRACT-UNBIND'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal79=(IToken)Match(input,129,FOLLOW_129_in_macroName2426); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal79_tree = (CommonTree)adaptor.Create(string_literal79);
                    		adaptor.AddChild(root_0, string_literal79_tree);
                    	}

                    }
                    break;
                case 18 :
                    // Smi.g:653:25: 'ABSTRACT-OPERATION'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal80=(IToken)Match(input,128,FOLLOW_128_in_macroName2430); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal80_tree = (CommonTree)adaptor.Create(string_literal80);
                    		adaptor.AddChild(root_0, string_literal80_tree);
                    	}

                    }
                    break;
                case 19 :
                    // Smi.g:653:48: 'ABSTRACT-ERROR'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal81=(IToken)Match(input,127,FOLLOW_127_in_macroName2434); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal81_tree = (CommonTree)adaptor.Create(string_literal81);
                    		adaptor.AddChild(root_0, string_literal81_tree);
                    	}

                    }
                    break;
                case 20 :
                    // Smi.g:654:5: 'ALGORITHM'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal82=(IToken)Match(input,132,FOLLOW_132_in_macroName2441); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal82_tree = (CommonTree)adaptor.Create(string_literal82);
                    		adaptor.AddChild(root_0, string_literal82_tree);
                    	}

                    }
                    break;
                case 21 :
                    // Smi.g:654:19: 'ENCRYPTED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal83=(IToken)Match(input,143,FOLLOW_143_in_macroName2445); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal83_tree = (CommonTree)adaptor.Create(string_literal83);
                    		adaptor.AddChild(root_0, string_literal83_tree);
                    	}

                    }
                    break;
                case 22 :
                    // Smi.g:654:33: 'SIGNED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal84=(IToken)Match(input,183,FOLLOW_183_in_macroName2449); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal84_tree = (CommonTree)adaptor.Create(string_literal84);
                    		adaptor.AddChild(root_0, string_literal84_tree);
                    	}

                    }
                    break;
                case 23 :
                    // Smi.g:654:44: 'SIGNATURE'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal85=(IToken)Match(input,182,FOLLOW_182_in_macroName2453); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal85_tree = (CommonTree)adaptor.Create(string_literal85);
                    		adaptor.AddChild(root_0, string_literal85_tree);
                    	}

                    }
                    break;
                case 24 :
                    // Smi.g:654:58: 'PROTECTED'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal86=(IToken)Match(input,176,FOLLOW_176_in_macroName2457); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal86_tree = (CommonTree)adaptor.Create(string_literal86);
                    		adaptor.AddChild(root_0, string_literal86_tree);
                    	}

                    }
                    break;
                case 25 :
                    // Smi.g:655:5: smi_macros
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_macros_in_macroName2464);
                    	smi_macros87 = smi_macros();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_macros87.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macroName"

    public class type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "type"
    // Smi.g:657:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );
    public SmiParser.type_return type() // throws RecognitionException [1]
    {   
        SmiParser.type_return retval = new SmiParser.type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.built_in_type_return built_in_type88 = default(SmiParser.built_in_type_return);

        SmiParser.defined_type_return defined_type89 = default(SmiParser.defined_type_return);

        SmiParser.selection_type_return selection_type90 = default(SmiParser.selection_type_return);

        SmiParser.macros_type_return macros_type91 = default(SmiParser.macros_type_return);

        SmiParser.smi_type_return smi_type92 = default(SmiParser.smi_type_return);



        try 
    	{
            // Smi.g:657:7: ( built_in_type | defined_type | selection_type | macros_type | smi_type )
            int alt24 = 5;
            alt24 = dfa24.Predict(input);
            switch (alt24) 
            {
                case 1 :
                    // Smi.g:657:7: built_in_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_built_in_type_in_type2471);
                    	built_in_type88 = built_in_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, built_in_type88.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:657:23: defined_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_type_in_type2475);
                    	defined_type89 = defined_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_type89.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:657:38: selection_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_selection_type_in_type2479);
                    	selection_type90 = selection_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, selection_type90.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:657:55: macros_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_macros_type_in_type2483);
                    	macros_type91 = macros_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, macros_type91.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:657:69: smi_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_smi_type_in_type2487);
                    	smi_type92 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type92.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type"

    public class value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value"
    // Smi.g:659:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );
    public SmiParser.value_return value() // throws RecognitionException [1]
    {   
        SmiParser.value_return retval = new SmiParser.value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken TRUE_KW93 = null;
        IToken FALSE_KW94 = null;
        IToken NULL_KW95 = null;
        IToken C_STRING96 = null;
        IToken PLUS_INFINITY_KW104 = null;
        IToken MINUS_INFINITY_KW105 = null;
        SmiParser.defined_value_return defined_value97 = default(SmiParser.defined_value_return);

        SmiParser.signed_number_return signed_number98 = default(SmiParser.signed_number_return);

        SmiParser.choice_value_return choice_value99 = default(SmiParser.choice_value_return);

        SmiParser.sequence_value_return sequence_value100 = default(SmiParser.sequence_value_return);

        SmiParser.sequenceof_value_return sequenceof_value101 = default(SmiParser.sequenceof_value_return);

        SmiParser.cstr_value_return cstr_value102 = default(SmiParser.cstr_value_return);

        SmiParser.obj_id_comp_lst_return obj_id_comp_lst103 = default(SmiParser.obj_id_comp_lst_return);


        CommonTree TRUE_KW93_tree=null;
        CommonTree FALSE_KW94_tree=null;
        CommonTree NULL_KW95_tree=null;
        CommonTree C_STRING96_tree=null;
        CommonTree PLUS_INFINITY_KW104_tree=null;
        CommonTree MINUS_INFINITY_KW105_tree=null;

        try 
    	{
            // Smi.g:659:8: (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW )
            int alt25 = 13;
            alt25 = dfa25.Predict(input);
            switch (alt25) 
            {
                case 1 :
                    // Smi.g:659:8: => TRUE_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	TRUE_KW93=(IToken)Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_value2500); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{TRUE_KW93_tree = (CommonTree)adaptor.Create(TRUE_KW93);
                    		adaptor.AddChild(root_0, TRUE_KW93_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:660:8: => FALSE_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	FALSE_KW94=(IToken)Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_value2516); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FALSE_KW94_tree = (CommonTree)adaptor.Create(FALSE_KW94);
                    		adaptor.AddChild(root_0, FALSE_KW94_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:661:8: => NULL_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	NULL_KW95=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_value2532); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NULL_KW95_tree = (CommonTree)adaptor.Create(NULL_KW95);
                    		adaptor.AddChild(root_0, NULL_KW95_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:662:8: => C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	C_STRING96=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_value2549); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING96_tree = (CommonTree)adaptor.Create(C_STRING96);
                    		adaptor.AddChild(root_0, C_STRING96_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:663:8: => defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_defined_value_in_value2565);
                    	defined_value97 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value97.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:664:8: => signed_number
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_signed_number_in_value2581);
                    	signed_number98 = signed_number();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number98.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:665:8: => choice_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_choice_value_in_value2596);
                    	choice_value99 = choice_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_value99.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:666:8: => sequence_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequence_value_in_value2612);
                    	sequence_value100 = sequence_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_value100.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:667:8: => sequenceof_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_sequenceof_value_in_value2628);
                    	sequenceof_value101 = sequenceof_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_value101.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:668:8: => cstr_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_cstr_value_in_value2644);
                    	cstr_value102 = cstr_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, cstr_value102.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:669:8: => obj_id_comp_lst
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_obj_id_comp_lst_in_value2660);
                    	obj_id_comp_lst103 = obj_id_comp_lst();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, obj_id_comp_lst103.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:670:8: => PLUS_INFINITY_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PLUS_INFINITY_KW104=(IToken)Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_value2676); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PLUS_INFINITY_KW104_tree = (CommonTree)adaptor.Create(PLUS_INFINITY_KW104);
                    		adaptor.AddChild(root_0, PLUS_INFINITY_KW104_tree);
                    	}

                    }
                    break;
                case 13 :
                    // Smi.g:671:8: => MINUS_INFINITY_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	MINUS_INFINITY_KW105=(IToken)Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_value2692); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{MINUS_INFINITY_KW105_tree = (CommonTree)adaptor.Create(MINUS_INFINITY_KW105);
                    		adaptor.AddChild(root_0, MINUS_INFINITY_KW105_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value"

    public class built_in_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "built_in_type"
    // Smi.g:673:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );
    public SmiParser.built_in_type_return built_in_type() // throws RecognitionException [1]
    {   
        SmiParser.built_in_type_return retval = new SmiParser.built_in_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EMBEDDED_KW112 = null;
        IToken PDV_KW113 = null;
        SmiParser.any_type_return any_type106 = default(SmiParser.any_type_return);

        SmiParser.bit_string_type_return bit_string_type107 = default(SmiParser.bit_string_type_return);

        SmiParser.boolean_type_return boolean_type108 = default(SmiParser.boolean_type_return);

        SmiParser.character_str_type_return character_str_type109 = default(SmiParser.character_str_type_return);

        SmiParser.choice_type_return choice_type110 = default(SmiParser.choice_type_return);

        SmiParser.embedded_type_return embedded_type111 = default(SmiParser.embedded_type_return);

        SmiParser.enum_type_return enum_type114 = default(SmiParser.enum_type_return);

        SmiParser.external_type_return external_type115 = default(SmiParser.external_type_return);

        SmiParser.integer_type_return integer_type116 = default(SmiParser.integer_type_return);

        SmiParser.null_type_return null_type117 = default(SmiParser.null_type_return);

        SmiParser.object_identifier_type_return object_identifier_type118 = default(SmiParser.object_identifier_type_return);

        SmiParser.octetString_type_return octetString_type119 = default(SmiParser.octetString_type_return);

        SmiParser.real_type_return real_type120 = default(SmiParser.real_type_return);

        SmiParser.relativeOid_type_return relativeOid_type121 = default(SmiParser.relativeOid_type_return);

        SmiParser.sequence_type_return sequence_type122 = default(SmiParser.sequence_type_return);

        SmiParser.sequenceof_type_return sequenceof_type123 = default(SmiParser.sequenceof_type_return);

        SmiParser.set_type_return set_type124 = default(SmiParser.set_type_return);

        SmiParser.setof_type_return setof_type125 = default(SmiParser.setof_type_return);

        SmiParser.tagged_type_return tagged_type126 = default(SmiParser.tagged_type_return);


        CommonTree EMBEDDED_KW112_tree=null;
        CommonTree PDV_KW113_tree=null;

        try 
    	{
            // Smi.g:673:16: ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type )
            int alt26 = 19;
            alt26 = dfa26.Predict(input);
            switch (alt26) 
            {
                case 1 :
                    // Smi.g:673:16: any_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_any_type_in_built_in_type2699);
                    	any_type106 = any_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, any_type106.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:674:16: bit_string_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_bit_string_type_in_built_in_type2717);
                    	bit_string_type107 = bit_string_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, bit_string_type107.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:675:16: boolean_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_boolean_type_in_built_in_type2735);
                    	boolean_type108 = boolean_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, boolean_type108.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:676:16: character_str_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_str_type_in_built_in_type2753);
                    	character_str_type109 = character_str_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_str_type109.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:677:16: choice_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_choice_type_in_built_in_type2771);
                    	choice_type110 = choice_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, choice_type110.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:678:16: embedded_type EMBEDDED_KW PDV_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_embedded_type_in_built_in_type2788);
                    	embedded_type111 = embedded_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, embedded_type111.Tree);
                    	EMBEDDED_KW112=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_built_in_type2790); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EMBEDDED_KW112_tree = (CommonTree)adaptor.Create(EMBEDDED_KW112);
                    		adaptor.AddChild(root_0, EMBEDDED_KW112_tree);
                    	}
                    	PDV_KW113=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_built_in_type2792); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PDV_KW113_tree = (CommonTree)adaptor.Create(PDV_KW113);
                    		adaptor.AddChild(root_0, PDV_KW113_tree);
                    	}

                    }
                    break;
                case 7 :
                    // Smi.g:679:16: enum_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_enum_type_in_built_in_type2810);
                    	enum_type114 = enum_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, enum_type114.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:680:16: external_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_external_type_in_built_in_type2827);
                    	external_type115 = external_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, external_type115.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:681:9: integer_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_integer_type_in_built_in_type2837);
                    	integer_type116 = integer_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, integer_type116.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:682:9: null_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_null_type_in_built_in_type2847);
                    	null_type117 = null_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, null_type117.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:683:9: object_identifier_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_object_identifier_type_in_built_in_type2857);
                    	object_identifier_type118 = object_identifier_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, object_identifier_type118.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:684:9: octetString_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_octetString_type_in_built_in_type2867);
                    	octetString_type119 = octetString_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, octetString_type119.Tree);

                    }
                    break;
                case 13 :
                    // Smi.g:685:9: real_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_real_type_in_built_in_type2877);
                    	real_type120 = real_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, real_type120.Tree);

                    }
                    break;
                case 14 :
                    // Smi.g:686:9: relativeOid_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_relativeOid_type_in_built_in_type2887);
                    	relativeOid_type121 = relativeOid_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, relativeOid_type121.Tree);

                    }
                    break;
                case 15 :
                    // Smi.g:687:9: sequence_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequence_type_in_built_in_type2897);
                    	sequence_type122 = sequence_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequence_type122.Tree);

                    }
                    break;
                case 16 :
                    // Smi.g:688:9: sequenceof_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_sequenceof_type_in_built_in_type2907);
                    	sequenceof_type123 = sequenceof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, sequenceof_type123.Tree);

                    }
                    break;
                case 17 :
                    // Smi.g:689:9: set_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_set_type_in_built_in_type2917);
                    	set_type124 = set_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, set_type124.Tree);

                    }
                    break;
                case 18 :
                    // Smi.g:690:9: setof_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_setof_type_in_built_in_type2927);
                    	setof_type125 = setof_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, setof_type125.Tree);

                    }
                    break;
                case 19 :
                    // Smi.g:691:9: tagged_type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_tagged_type_in_built_in_type2937);
                    	tagged_type126 = tagged_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tagged_type126.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "built_in_type"

    public class defined_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "defined_type"
    // Smi.g:693:0: defined_type : ( UPPER DOT )? UPPER ( constraint )? ;
    public SmiParser.defined_type_return defined_type() // throws RecognitionException [1]
    {   
        SmiParser.defined_type_return retval = new SmiParser.defined_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken UPPER127 = null;
        IToken DOT128 = null;
        IToken UPPER129 = null;
        SmiParser.constraint_return constraint130 = default(SmiParser.constraint_return);


        CommonTree UPPER127_tree=null;
        CommonTree DOT128_tree=null;
        CommonTree UPPER129_tree=null;

        try 
    	{
            // Smi.g:693:15: ( ( UPPER DOT )? UPPER ( constraint )? )
            // Smi.g:693:15: ( UPPER DOT )? UPPER ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:693:15: ( UPPER DOT )?
            	int alt27 = 2;
            	int LA27_0 = input.LA(1);

            	if ( (LA27_0 == UPPER) )
            	{
            	    int LA27_1 = input.LA(2);

            	    if ( (LA27_1 == DOT) )
            	    {
            	        alt27 = 1;
            	    }
            	}
            	switch (alt27) 
            	{
            	    case 1 :
            	        // Smi.g:693:16: UPPER DOT
            	        {
            	        	UPPER127=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2945); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER127_tree = (CommonTree)adaptor.Create(UPPER127);
            	        		adaptor.AddChild(root_0, UPPER127_tree);
            	        	}
            	        	DOT128=(IToken)Match(input,DOT,FOLLOW_DOT_in_defined_type2947); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOT128_tree = (CommonTree)adaptor.Create(DOT128);
            	        		adaptor.AddChild(root_0, DOT128_tree);
            	        	}

            	        }
            	        break;

            	}

            	UPPER129=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_defined_type2951); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{UPPER129_tree = (CommonTree)adaptor.Create(UPPER129);
            		adaptor.AddChild(root_0, UPPER129_tree);
            	}
            	// Smi.g:693:34: ( constraint )?
            	int alt28 = 2;
            	int LA28_0 = input.LA(1);

            	if ( (LA28_0 == L_PAREN) )
            	{
            	    alt28 = 1;
            	}
            	switch (alt28) 
            	{
            	    case 1 :
            	        // Smi.g:693:35: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_defined_type2954);
            	        	constraint130 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint130.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "defined_type"

    public class selection_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "selection_type"
    // Smi.g:695:0: selection_type : LOWER LESS type ;
    public SmiParser.selection_type_return selection_type() // throws RecognitionException [1]
    {   
        SmiParser.selection_type_return retval = new SmiParser.selection_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER131 = null;
        IToken LESS132 = null;
        SmiParser.type_return type133 = default(SmiParser.type_return);


        CommonTree LOWER131_tree=null;
        CommonTree LESS132_tree=null;

        try 
    	{
            // Smi.g:695:17: ( LOWER LESS type )
            // Smi.g:695:17: LOWER LESS type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER131=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_selection_type2964); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER131_tree = (CommonTree)adaptor.Create(LOWER131);
            		adaptor.AddChild(root_0, LOWER131_tree);
            	}
            	LESS132=(IToken)Match(input,LESS,FOLLOW_LESS_in_selection_type2966); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LESS132_tree = (CommonTree)adaptor.Create(LESS132);
            		adaptor.AddChild(root_0, LESS132_tree);
            	}
            	PushFollow(FOLLOW_type_in_selection_type2968);
            	type133 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type133.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "selection_type"

    public class any_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "any_type"
    // Smi.g:697:0: any_type : ANY_KW ( DEFINED_KW BY_KW LOWER )? ;
    public SmiParser.any_type_return any_type() // throws RecognitionException [1]
    {   
        SmiParser.any_type_return retval = new SmiParser.any_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ANY_KW134 = null;
        IToken DEFINED_KW135 = null;
        IToken BY_KW136 = null;
        IToken LOWER137 = null;

        CommonTree ANY_KW134_tree=null;
        CommonTree DEFINED_KW135_tree=null;
        CommonTree BY_KW136_tree=null;
        CommonTree LOWER137_tree=null;

        try 
    	{
            // Smi.g:697:11: ( ANY_KW ( DEFINED_KW BY_KW LOWER )? )
            // Smi.g:697:11: ANY_KW ( DEFINED_KW BY_KW LOWER )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ANY_KW134=(IToken)Match(input,ANY_KW,FOLLOW_ANY_KW_in_any_type2975); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ANY_KW134_tree = (CommonTree)adaptor.Create(ANY_KW134);
            		adaptor.AddChild(root_0, ANY_KW134_tree);
            	}
            	// Smi.g:697:18: ( DEFINED_KW BY_KW LOWER )?
            	int alt29 = 2;
            	int LA29_0 = input.LA(1);

            	if ( (LA29_0 == DEFINED_KW) )
            	{
            	    alt29 = 1;
            	}
            	switch (alt29) 
            	{
            	    case 1 :
            	        // Smi.g:697:19: DEFINED_KW BY_KW LOWER
            	        {
            	        	DEFINED_KW135=(IToken)Match(input,DEFINED_KW,FOLLOW_DEFINED_KW_in_any_type2978); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DEFINED_KW135_tree = (CommonTree)adaptor.Create(DEFINED_KW135);
            	        		adaptor.AddChild(root_0, DEFINED_KW135_tree);
            	        	}
            	        	BY_KW136=(IToken)Match(input,BY_KW,FOLLOW_BY_KW_in_any_type2980); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{BY_KW136_tree = (CommonTree)adaptor.Create(BY_KW136);
            	        		adaptor.AddChild(root_0, BY_KW136_tree);
            	        	}
            	        	LOWER137=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_any_type2982); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LOWER137_tree = (CommonTree)adaptor.Create(LOWER137);
            	        		adaptor.AddChild(root_0, LOWER137_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "any_type"

    public class bit_string_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "bit_string_type"
    // Smi.g:700:0: bit_string_type : BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? ;
    public SmiParser.bit_string_type_return bit_string_type() // throws RecognitionException [1]
    {   
        SmiParser.bit_string_type_return retval = new SmiParser.bit_string_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken BIT_KW138 = null;
        IToken STRING_KW139 = null;
        SmiParser.namedNumber_list_return namedNumber_list140 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint141 = default(SmiParser.constraint_return);


        CommonTree BIT_KW138_tree=null;
        CommonTree STRING_KW139_tree=null;

        try 
    	{
            // Smi.g:700:18: ( BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )? )
            // Smi.g:700:18: BIT_KW STRING_KW (=> namedNumber_list )? ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	BIT_KW138=(IToken)Match(input,BIT_KW,FOLLOW_BIT_KW_in_bit_string_type2994); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BIT_KW138_tree = (CommonTree)adaptor.Create(BIT_KW138);
            		adaptor.AddChild(root_0, BIT_KW138_tree);
            	}
            	STRING_KW139=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_bit_string_type2996); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW139_tree = (CommonTree)adaptor.Create(STRING_KW139);
            		adaptor.AddChild(root_0, STRING_KW139_tree);
            	}
            	// Smi.g:700:35: (=> namedNumber_list )?
            	int alt30 = 2;
            	int LA30_0 = input.LA(1);

            	if ( (LA30_0 == L_BRACE) && (synpred16_Smi()) )
            	{
            	    alt30 = 1;
            	}
            	switch (alt30) 
            	{
            	    case 1 :
            	        // Smi.g:700:36: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_bit_string_type3007);
            	        	namedNumber_list140 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list140.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:700:80: ( constraint )?
            	int alt31 = 2;
            	int LA31_0 = input.LA(1);

            	if ( (LA31_0 == L_PAREN) )
            	{
            	    alt31 = 1;
            	}
            	switch (alt31) 
            	{
            	    case 1 :
            	        // Smi.g:700:81: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_bit_string_type3012);
            	        	constraint141 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint141.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "bit_string_type"

    public class boolean_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "boolean_type"
    // Smi.g:703:0: boolean_type : BOOLEAN_KW ;
    public SmiParser.boolean_type_return boolean_type() // throws RecognitionException [1]
    {   
        SmiParser.boolean_type_return retval = new SmiParser.boolean_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken BOOLEAN_KW142 = null;

        CommonTree BOOLEAN_KW142_tree=null;

        try 
    	{
            // Smi.g:703:15: ( BOOLEAN_KW )
            // Smi.g:703:15: BOOLEAN_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	BOOLEAN_KW142=(IToken)Match(input,BOOLEAN_KW,FOLLOW_BOOLEAN_KW_in_boolean_type3023); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{BOOLEAN_KW142_tree = (CommonTree)adaptor.Create(BOOLEAN_KW142);
            		adaptor.AddChild(root_0, BOOLEAN_KW142_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "boolean_type"

    public class character_str_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "character_str_type"
    // Smi.g:705:0: character_str_type : ( CHARACTER_KW STRING_KW | character_set ( constraint )? );
    public SmiParser.character_str_type_return character_str_type() // throws RecognitionException [1]
    {   
        SmiParser.character_str_type_return retval = new SmiParser.character_str_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken CHARACTER_KW143 = null;
        IToken STRING_KW144 = null;
        SmiParser.character_set_return character_set145 = default(SmiParser.character_set_return);

        SmiParser.constraint_return constraint146 = default(SmiParser.constraint_return);


        CommonTree CHARACTER_KW143_tree=null;
        CommonTree STRING_KW144_tree=null;

        try 
    	{
            // Smi.g:705:21: ( CHARACTER_KW STRING_KW | character_set ( constraint )? )
            int alt33 = 2;
            int LA33_0 = input.LA(1);

            if ( (LA33_0 == CHARACTER_KW) )
            {
                alt33 = 1;
            }
            else if ( (LA33_0 == BMP_STR_KW || (LA33_0 >= GENERAL_STR_KW && LA33_0 <= GRAPHIC_STR_KW) || LA33_0 == IA5_STRING_KW || LA33_0 == ISO646_STR_KW || LA33_0 == NUMERIC_STR_KW || LA33_0 == PRINTABLE_STR_KW || LA33_0 == T61_STR_KW || LA33_0 == TELETEX_STR_KW || LA33_0 == UNIVERSAL_STR_KW || (LA33_0 >= UTC_TIME_KW && LA33_0 <= VISIBLE_STR_KW)) )
            {
                alt33 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d33s0 =
                    new NoViableAltException("", 33, 0, input);

                throw nvae_d33s0;
            }
            switch (alt33) 
            {
                case 1 :
                    // Smi.g:705:21: CHARACTER_KW STRING_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	CHARACTER_KW143=(IToken)Match(input,CHARACTER_KW,FOLLOW_CHARACTER_KW_in_character_str_type3030); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{CHARACTER_KW143_tree = (CommonTree)adaptor.Create(CHARACTER_KW143);
                    		adaptor.AddChild(root_0, CHARACTER_KW143_tree);
                    	}
                    	STRING_KW144=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_character_str_type3032); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW144_tree = (CommonTree)adaptor.Create(STRING_KW144);
                    		adaptor.AddChild(root_0, STRING_KW144_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:705:46: character_set ( constraint )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_character_set_in_character_str_type3036);
                    	character_set145 = character_set();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, character_set145.Tree);
                    	// Smi.g:705:60: ( constraint )?
                    	int alt32 = 2;
                    	int LA32_0 = input.LA(1);

                    	if ( (LA32_0 == L_PAREN) )
                    	{
                    	    alt32 = 1;
                    	}
                    	switch (alt32) 
                    	{
                    	    case 1 :
                    	        // Smi.g:705:61: constraint
                    	        {
                    	        	PushFollow(FOLLOW_constraint_in_character_str_type3039);
                    	        	constraint146 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint146.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_str_type"

    public class choice_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "choice_type"
    // Smi.g:707:0: choice_type : CHOICE_KW L_BRACE elementType_list R_BRACE ;
    public SmiParser.choice_type_return choice_type() // throws RecognitionException [1]
    {   
        SmiParser.choice_type_return retval = new SmiParser.choice_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken CHOICE_KW147 = null;
        IToken L_BRACE148 = null;
        IToken R_BRACE150 = null;
        SmiParser.elementType_list_return elementType_list149 = default(SmiParser.elementType_list_return);


        CommonTree CHOICE_KW147_tree=null;
        CommonTree L_BRACE148_tree=null;
        CommonTree R_BRACE150_tree=null;

        try 
    	{
            // Smi.g:707:14: ( CHOICE_KW L_BRACE elementType_list R_BRACE )
            // Smi.g:707:14: CHOICE_KW L_BRACE elementType_list R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	CHOICE_KW147=(IToken)Match(input,CHOICE_KW,FOLLOW_CHOICE_KW_in_choice_type3049); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{CHOICE_KW147_tree = (CommonTree)adaptor.Create(CHOICE_KW147);
            		adaptor.AddChild(root_0, CHOICE_KW147_tree);
            	}
            	L_BRACE148=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_choice_type3051); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE148_tree = (CommonTree)adaptor.Create(L_BRACE148);
            		adaptor.AddChild(root_0, L_BRACE148_tree);
            	}
            	PushFollow(FOLLOW_elementType_list_in_choice_type3053);
            	elementType_list149 = elementType_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list149.Tree);
            	R_BRACE150=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_choice_type3055); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE150_tree = (CommonTree)adaptor.Create(R_BRACE150);
            		adaptor.AddChild(root_0, R_BRACE150_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_type"

    public class embedded_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "embedded_type"
    // Smi.g:709:0: embedded_type : EMBEDDED_KW PDV_KW ;
    public SmiParser.embedded_type_return embedded_type() // throws RecognitionException [1]
    {   
        SmiParser.embedded_type_return retval = new SmiParser.embedded_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EMBEDDED_KW151 = null;
        IToken PDV_KW152 = null;

        CommonTree EMBEDDED_KW151_tree=null;
        CommonTree PDV_KW152_tree=null;

        try 
    	{
            // Smi.g:709:16: ( EMBEDDED_KW PDV_KW )
            // Smi.g:709:16: EMBEDDED_KW PDV_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EMBEDDED_KW151=(IToken)Match(input,EMBEDDED_KW,FOLLOW_EMBEDDED_KW_in_embedded_type3062); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EMBEDDED_KW151_tree = (CommonTree)adaptor.Create(EMBEDDED_KW151);
            		adaptor.AddChild(root_0, EMBEDDED_KW151_tree);
            	}
            	PDV_KW152=(IToken)Match(input,PDV_KW,FOLLOW_PDV_KW_in_embedded_type3064); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{PDV_KW152_tree = (CommonTree)adaptor.Create(PDV_KW152);
            		adaptor.AddChild(root_0, PDV_KW152_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "embedded_type"

    public class enum_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "enum_type"
    // Smi.g:711:0: enum_type : ENUMERATED_KW namedNumber_list ;
    public SmiParser.enum_type_return enum_type() // throws RecognitionException [1]
    {   
        SmiParser.enum_type_return retval = new SmiParser.enum_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ENUMERATED_KW153 = null;
        SmiParser.namedNumber_list_return namedNumber_list154 = default(SmiParser.namedNumber_list_return);


        CommonTree ENUMERATED_KW153_tree=null;

        try 
    	{
            // Smi.g:711:12: ( ENUMERATED_KW namedNumber_list )
            // Smi.g:711:12: ENUMERATED_KW namedNumber_list
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ENUMERATED_KW153=(IToken)Match(input,ENUMERATED_KW,FOLLOW_ENUMERATED_KW_in_enum_type3071); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ENUMERATED_KW153_tree = (CommonTree)adaptor.Create(ENUMERATED_KW153);
            		adaptor.AddChild(root_0, ENUMERATED_KW153_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_list_in_enum_type3073);
            	namedNumber_list154 = namedNumber_list();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list154.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "enum_type"

    public class external_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "external_type"
    // Smi.g:713:0: external_type : EXTERNAL_KW ;
    public SmiParser.external_type_return external_type() // throws RecognitionException [1]
    {   
        SmiParser.external_type_return retval = new SmiParser.external_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXTERNAL_KW155 = null;

        CommonTree EXTERNAL_KW155_tree=null;

        try 
    	{
            // Smi.g:713:16: ( EXTERNAL_KW )
            // Smi.g:713:16: EXTERNAL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXTERNAL_KW155=(IToken)Match(input,EXTERNAL_KW,FOLLOW_EXTERNAL_KW_in_external_type3080); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXTERNAL_KW155_tree = (CommonTree)adaptor.Create(EXTERNAL_KW155);
            		adaptor.AddChild(root_0, EXTERNAL_KW155_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "external_type"

    public class integer_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "integer_type"
    // Smi.g:716:0: integer_type : INTEGER_KW (=> namedNumber_list | constraint )? ;
    public SmiParser.integer_type_return integer_type() // throws RecognitionException [1]
    {   
        SmiParser.integer_type_return retval = new SmiParser.integer_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken INTEGER_KW156 = null;
        SmiParser.namedNumber_list_return namedNumber_list157 = default(SmiParser.namedNumber_list_return);

        SmiParser.constraint_return constraint158 = default(SmiParser.constraint_return);


        CommonTree INTEGER_KW156_tree=null;

        try 
    	{
            // Smi.g:716:15: ( INTEGER_KW (=> namedNumber_list | constraint )? )
            // Smi.g:716:15: INTEGER_KW (=> namedNumber_list | constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	INTEGER_KW156=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_integer_type3089); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{INTEGER_KW156_tree = (CommonTree)adaptor.Create(INTEGER_KW156);
            		adaptor.AddChild(root_0, INTEGER_KW156_tree);
            	}
            	// Smi.g:716:26: (=> namedNumber_list | constraint )?
            	int alt34 = 3;
            	int LA34_0 = input.LA(1);

            	if ( (LA34_0 == L_BRACE) && (synpred17_Smi()) )
            	{
            	    alt34 = 1;
            	}
            	else if ( (LA34_0 == L_PAREN) )
            	{
            	    alt34 = 2;
            	}
            	switch (alt34) 
            	{
            	    case 1 :
            	        // Smi.g:716:27: => namedNumber_list
            	        {

            	        	PushFollow(FOLLOW_namedNumber_list_in_integer_type3100);
            	        	namedNumber_list157 = namedNumber_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber_list157.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:716:71: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_integer_type3104);
            	        	constraint158 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint158.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "integer_type"

    public class null_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "null_type"
    // Smi.g:719:0: null_type : NULL_KW ;
    public SmiParser.null_type_return null_type() // throws RecognitionException [1]
    {   
        SmiParser.null_type_return retval = new SmiParser.null_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NULL_KW159 = null;

        CommonTree NULL_KW159_tree=null;

        try 
    	{
            // Smi.g:719:12: ( NULL_KW )
            // Smi.g:719:12: NULL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	NULL_KW159=(IToken)Match(input,NULL_KW,FOLLOW_NULL_KW_in_null_type3115); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NULL_KW159_tree = (CommonTree)adaptor.Create(NULL_KW159);
            		adaptor.AddChild(root_0, NULL_KW159_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "null_type"

    public class object_identifier_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "object_identifier_type"
    // Smi.g:721:0: object_identifier_type : OBJECT_KW IDENTIFIER_KW ;
    public SmiParser.object_identifier_type_return object_identifier_type() // throws RecognitionException [1]
    {   
        SmiParser.object_identifier_type_return retval = new SmiParser.object_identifier_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OBJECT_KW160 = null;
        IToken IDENTIFIER_KW161 = null;

        CommonTree OBJECT_KW160_tree=null;
        CommonTree IDENTIFIER_KW161_tree=null;

        try 
    	{
            // Smi.g:721:25: ( OBJECT_KW IDENTIFIER_KW )
            // Smi.g:721:25: OBJECT_KW IDENTIFIER_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	OBJECT_KW160=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_object_identifier_type3122); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OBJECT_KW160_tree = (CommonTree)adaptor.Create(OBJECT_KW160);
            		adaptor.AddChild(root_0, OBJECT_KW160_tree);
            	}
            	IDENTIFIER_KW161=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_object_identifier_type3124); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{IDENTIFIER_KW161_tree = (CommonTree)adaptor.Create(IDENTIFIER_KW161);
            		adaptor.AddChild(root_0, IDENTIFIER_KW161_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "object_identifier_type"

    public class octetString_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "octetString_type"
    // Smi.g:723:0: octetString_type : OCTET_KW STRING_KW ( constraint )? ;
    public SmiParser.octetString_type_return octetString_type() // throws RecognitionException [1]
    {   
        SmiParser.octetString_type_return retval = new SmiParser.octetString_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken OCTET_KW162 = null;
        IToken STRING_KW163 = null;
        SmiParser.constraint_return constraint164 = default(SmiParser.constraint_return);


        CommonTree OCTET_KW162_tree=null;
        CommonTree STRING_KW163_tree=null;

        try 
    	{
            // Smi.g:723:19: ( OCTET_KW STRING_KW ( constraint )? )
            // Smi.g:723:19: OCTET_KW STRING_KW ( constraint )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	OCTET_KW162=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_octetString_type3131); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OCTET_KW162_tree = (CommonTree)adaptor.Create(OCTET_KW162);
            		adaptor.AddChild(root_0, OCTET_KW162_tree);
            	}
            	STRING_KW163=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_octetString_type3133); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{STRING_KW163_tree = (CommonTree)adaptor.Create(STRING_KW163);
            		adaptor.AddChild(root_0, STRING_KW163_tree);
            	}
            	// Smi.g:723:38: ( constraint )?
            	int alt35 = 2;
            	int LA35_0 = input.LA(1);

            	if ( (LA35_0 == L_PAREN) )
            	{
            	    alt35 = 1;
            	}
            	switch (alt35) 
            	{
            	    case 1 :
            	        // Smi.g:723:39: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_octetString_type3136);
            	        	constraint164 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint164.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "octetString_type"

    public class real_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "real_type"
    // Smi.g:725:0: real_type : REAL_KW ;
    public SmiParser.real_type_return real_type() // throws RecognitionException [1]
    {   
        SmiParser.real_type_return retval = new SmiParser.real_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken REAL_KW165 = null;

        CommonTree REAL_KW165_tree=null;

        try 
    	{
            // Smi.g:725:12: ( REAL_KW )
            // Smi.g:725:12: REAL_KW
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	REAL_KW165=(IToken)Match(input,REAL_KW,FOLLOW_REAL_KW_in_real_type3146); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{REAL_KW165_tree = (CommonTree)adaptor.Create(REAL_KW165);
            		adaptor.AddChild(root_0, REAL_KW165_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "real_type"

    public class relativeOid_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "relativeOid_type"
    // Smi.g:728:0: relativeOid_type : 'RELATIVE-OID' ;
    public SmiParser.relativeOid_type_return relativeOid_type() // throws RecognitionException [1]
    {   
        SmiParser.relativeOid_type_return retval = new SmiParser.relativeOid_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal166 = null;

        CommonTree string_literal166_tree=null;

        try 
    	{
            // Smi.g:728:19: ( 'RELATIVE-OID' )
            // Smi.g:728:19: 'RELATIVE-OID'
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal166=(IToken)Match(input,179,FOLLOW_179_in_relativeOid_type3155); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal166_tree = (CommonTree)adaptor.Create(string_literal166);
            		adaptor.AddChild(root_0, string_literal166_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "relativeOid_type"

    public class sequence_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequence_type"
    // Smi.g:731:0: sequence_type : SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.sequence_type_return sequence_type() // throws RecognitionException [1]
    {   
        SmiParser.sequence_type_return retval = new SmiParser.sequence_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SEQUENCE_KW167 = null;
        IToken L_BRACE168 = null;
        IToken R_BRACE170 = null;
        SmiParser.elementType_list_return elementType_list169 = default(SmiParser.elementType_list_return);


        CommonTree SEQUENCE_KW167_tree=null;
        CommonTree L_BRACE168_tree=null;
        CommonTree R_BRACE170_tree=null;

        try 
    	{
            // Smi.g:731:16: ( SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:731:16: SEQUENCE_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SEQUENCE_KW167=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequence_type3163); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW167_tree = (CommonTree)adaptor.Create(SEQUENCE_KW167);
            		adaptor.AddChild(root_0, SEQUENCE_KW167_tree);
            	}
            	L_BRACE168=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_type3165); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE168_tree = (CommonTree)adaptor.Create(L_BRACE168);
            		adaptor.AddChild(root_0, L_BRACE168_tree);
            	}
            	// Smi.g:731:36: ( elementType_list )?
            	int alt36 = 2;
            	int LA36_0 = input.LA(1);

            	if ( (LA36_0 == COMPONENTS_KW || LA36_0 == LOWER) )
            	{
            	    alt36 = 1;
            	}
            	switch (alt36) 
            	{
            	    case 1 :
            	        // Smi.g:731:37: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_sequence_type3168);
            	        	elementType_list169 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list169.Tree);

            	        }
            	        break;

            	}

            	R_BRACE170=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_type3172); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE170_tree = (CommonTree)adaptor.Create(R_BRACE170);
            		adaptor.AddChild(root_0, R_BRACE170_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_type"

    public class sequenceof_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequenceof_type"
    // Smi.g:733:0: sequenceof_type : SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.sequenceof_type_return sequenceof_type() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_type_return retval = new SmiParser.sequenceof_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SEQUENCE_KW171 = null;
        IToken SIZE_KW172 = null;
        IToken OF_KW174 = null;
        SmiParser.constraint_return constraint173 = default(SmiParser.constraint_return);

        SmiParser.type_return type175 = default(SmiParser.type_return);


        CommonTree SEQUENCE_KW171_tree=null;
        CommonTree SIZE_KW172_tree=null;
        CommonTree OF_KW174_tree=null;

        try 
    	{
            // Smi.g:733:18: ( SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:733:18: SEQUENCE_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SEQUENCE_KW171=(IToken)Match(input,SEQUENCE_KW,FOLLOW_SEQUENCE_KW_in_sequenceof_type3180); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SEQUENCE_KW171_tree = (CommonTree)adaptor.Create(SEQUENCE_KW171);
            		adaptor.AddChild(root_0, SEQUENCE_KW171_tree);
            	}
            	// Smi.g:733:30: ( SIZE_KW constraint )?
            	int alt37 = 2;
            	int LA37_0 = input.LA(1);

            	if ( (LA37_0 == SIZE_KW) )
            	{
            	    alt37 = 1;
            	}
            	switch (alt37) 
            	{
            	    case 1 :
            	        // Smi.g:733:31: SIZE_KW constraint
            	        {
            	        	SIZE_KW172=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_sequenceof_type3183); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW172_tree = (CommonTree)adaptor.Create(SIZE_KW172);
            	        		adaptor.AddChild(root_0, SIZE_KW172_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_sequenceof_type3185);
            	        	constraint173 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint173.Tree);

            	        }
            	        break;

            	}

            	OF_KW174=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_sequenceof_type3189); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW174_tree = (CommonTree)adaptor.Create(OF_KW174);
            		adaptor.AddChild(root_0, OF_KW174_tree);
            	}
            	PushFollow(FOLLOW_type_in_sequenceof_type3191);
            	type175 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type175.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_type"

    public class set_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "set_type"
    // Smi.g:735:0: set_type : SET_KW L_BRACE ( elementType_list )? R_BRACE ;
    public SmiParser.set_type_return set_type() // throws RecognitionException [1]
    {   
        SmiParser.set_type_return retval = new SmiParser.set_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET_KW176 = null;
        IToken L_BRACE177 = null;
        IToken R_BRACE179 = null;
        SmiParser.elementType_list_return elementType_list178 = default(SmiParser.elementType_list_return);


        CommonTree SET_KW176_tree=null;
        CommonTree L_BRACE177_tree=null;
        CommonTree R_BRACE179_tree=null;

        try 
    	{
            // Smi.g:735:11: ( SET_KW L_BRACE ( elementType_list )? R_BRACE )
            // Smi.g:735:11: SET_KW L_BRACE ( elementType_list )? R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SET_KW176=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_set_type3198); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW176_tree = (CommonTree)adaptor.Create(SET_KW176);
            		adaptor.AddChild(root_0, SET_KW176_tree);
            	}
            	L_BRACE177=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_set_type3200); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE177_tree = (CommonTree)adaptor.Create(L_BRACE177);
            		adaptor.AddChild(root_0, L_BRACE177_tree);
            	}
            	// Smi.g:735:26: ( elementType_list )?
            	int alt38 = 2;
            	int LA38_0 = input.LA(1);

            	if ( (LA38_0 == COMPONENTS_KW || LA38_0 == LOWER) )
            	{
            	    alt38 = 1;
            	}
            	switch (alt38) 
            	{
            	    case 1 :
            	        // Smi.g:735:27: elementType_list
            	        {
            	        	PushFollow(FOLLOW_elementType_list_in_set_type3203);
            	        	elementType_list178 = elementType_list();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType_list178.Tree);

            	        }
            	        break;

            	}

            	R_BRACE179=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_set_type3207); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE179_tree = (CommonTree)adaptor.Create(R_BRACE179);
            		adaptor.AddChild(root_0, R_BRACE179_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "set_type"

    public class setof_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "setof_type"
    // Smi.g:737:0: setof_type : SET_KW ( SIZE_KW constraint )? OF_KW type ;
    public SmiParser.setof_type_return setof_type() // throws RecognitionException [1]
    {   
        SmiParser.setof_type_return retval = new SmiParser.setof_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SET_KW180 = null;
        IToken SIZE_KW181 = null;
        IToken OF_KW183 = null;
        SmiParser.constraint_return constraint182 = default(SmiParser.constraint_return);

        SmiParser.type_return type184 = default(SmiParser.type_return);


        CommonTree SET_KW180_tree=null;
        CommonTree SIZE_KW181_tree=null;
        CommonTree OF_KW183_tree=null;

        try 
    	{
            // Smi.g:737:13: ( SET_KW ( SIZE_KW constraint )? OF_KW type )
            // Smi.g:737:13: SET_KW ( SIZE_KW constraint )? OF_KW type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	SET_KW180=(IToken)Match(input,SET_KW,FOLLOW_SET_KW_in_setof_type3214); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{SET_KW180_tree = (CommonTree)adaptor.Create(SET_KW180);
            		adaptor.AddChild(root_0, SET_KW180_tree);
            	}
            	// Smi.g:737:20: ( SIZE_KW constraint )?
            	int alt39 = 2;
            	int LA39_0 = input.LA(1);

            	if ( (LA39_0 == SIZE_KW) )
            	{
            	    alt39 = 1;
            	}
            	switch (alt39) 
            	{
            	    case 1 :
            	        // Smi.g:737:21: SIZE_KW constraint
            	        {
            	        	SIZE_KW181=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_setof_type3217); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{SIZE_KW181_tree = (CommonTree)adaptor.Create(SIZE_KW181);
            	        		adaptor.AddChild(root_0, SIZE_KW181_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_in_setof_type3219);
            	        	constraint182 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint182.Tree);

            	        }
            	        break;

            	}

            	OF_KW183=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_setof_type3223); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{OF_KW183_tree = (CommonTree)adaptor.Create(OF_KW183);
            		adaptor.AddChild(root_0, OF_KW183_tree);
            	}
            	PushFollow(FOLLOW_type_in_setof_type3225);
            	type184 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type184.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "setof_type"

    public class tagged_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tagged_type"
    // Smi.g:739:0: tagged_type : tag ( tag_default )? type ;
    public SmiParser.tagged_type_return tagged_type() // throws RecognitionException [1]
    {   
        SmiParser.tagged_type_return retval = new SmiParser.tagged_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.tag_return tag185 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default186 = default(SmiParser.tag_default_return);

        SmiParser.type_return type187 = default(SmiParser.type_return);



        try 
    	{
            // Smi.g:739:14: ( tag ( tag_default )? type )
            // Smi.g:739:14: tag ( tag_default )? type
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_tag_in_tagged_type3232);
            	tag185 = tag();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag185.Tree);
            	// Smi.g:739:18: ( tag_default )?
            	int alt40 = 2;
            	int LA40_0 = input.LA(1);

            	if ( (LA40_0 == AUTOMATIC_KW || LA40_0 == EXPLICIT_KW || LA40_0 == IMPLICIT_KW) )
            	{
            	    alt40 = 1;
            	}
            	switch (alt40) 
            	{
            	    case 1 :
            	        // Smi.g:739:19: tag_default
            	        {
            	        	PushFollow(FOLLOW_tag_default_in_tagged_type3235);
            	        	tag_default186 = tag_default();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default186.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_type_in_tagged_type3239);
            	type187 = type();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type187.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tagged_type"

    public class namedNumber_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "namedNumber_list"
    // Smi.g:741:0: namedNumber_list : L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE ;
    public SmiParser.namedNumber_list_return namedNumber_list() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_list_return retval = new SmiParser.namedNumber_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE188 = null;
        IToken COMMA190 = null;
        IToken R_BRACE192 = null;
        SmiParser.namedNumber_return namedNumber189 = default(SmiParser.namedNumber_return);

        SmiParser.namedNumber_return namedNumber191 = default(SmiParser.namedNumber_return);


        CommonTree L_BRACE188_tree=null;
        CommonTree COMMA190_tree=null;
        CommonTree R_BRACE192_tree=null;

        try 
    	{
            // Smi.g:741:19: ( L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE )
            // Smi.g:741:19: L_BRACE namedNumber ( COMMA namedNumber )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE188=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_namedNumber_list3246); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE188_tree = (CommonTree)adaptor.Create(L_BRACE188);
            		adaptor.AddChild(root_0, L_BRACE188_tree);
            	}
            	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3248);
            	namedNumber189 = namedNumber();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber189.Tree);
            	// Smi.g:741:39: ( COMMA namedNumber )*
            	do 
            	{
            	    int alt41 = 2;
            	    int LA41_0 = input.LA(1);

            	    if ( (LA41_0 == COMMA) )
            	    {
            	        alt41 = 1;
            	    }


            	    switch (alt41) 
            		{
            			case 1 :
            			    // Smi.g:741:40: COMMA namedNumber
            			    {
            			    	COMMA190=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_namedNumber_list3251); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA190_tree = (CommonTree)adaptor.Create(COMMA190);
            			    		adaptor.AddChild(root_0, COMMA190_tree);
            			    	}
            			    	PushFollow(FOLLOW_namedNumber_in_namedNumber_list3253);
            			    	namedNumber191 = namedNumber();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, namedNumber191.Tree);

            			    }
            			    break;

            			default:
            			    goto loop41;
            	    }
            	} while (true);

            	loop41:
            		;	// Stops C# compiler whining that label 'loop41' has no statements

            	R_BRACE192=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_namedNumber_list3257); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE192_tree = (CommonTree)adaptor.Create(R_BRACE192);
            		adaptor.AddChild(root_0, R_BRACE192_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber_list"

    public class constraint_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constraint"
    // Smi.g:743:0: constraint : L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN ;
    public SmiParser.constraint_return constraint() // throws RecognitionException [1]
    {   
        SmiParser.constraint_return retval = new SmiParser.constraint_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_PAREN193 = null;
        IToken R_PAREN196 = null;
        SmiParser.element_set_specs_return element_set_specs194 = default(SmiParser.element_set_specs_return);

        SmiParser.exception_spec_return exception_spec195 = default(SmiParser.exception_spec_return);


        CommonTree L_PAREN193_tree=null;
        CommonTree R_PAREN196_tree=null;

        try 
    	{
            // Smi.g:743:13: ( L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN )
            // Smi.g:743:13: L_PAREN ( element_set_specs )? ( exception_spec )? R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_PAREN193=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint3264); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN193_tree = (CommonTree)adaptor.Create(L_PAREN193);
            		adaptor.AddChild(root_0, L_PAREN193_tree);
            	}
            	// Smi.g:743:21: ( element_set_specs )?
            	int alt42 = 2;
            	int LA42_0 = input.LA(1);

            	if ( ((LA42_0 >= ALL_KW && LA42_0 <= ANY_KW) || LA42_0 == B_STRING || (LA42_0 >= BIT_KW && LA42_0 <= BOOLEAN_KW) || (LA42_0 >= C_STRING && LA42_0 <= CHARACTER_KW) || LA42_0 == CHOICE_KW || LA42_0 == EMBEDDED_KW || (LA42_0 >= ENUMERATED_KW && LA42_0 <= ERROR_KW) || (LA42_0 >= EXTERNAL_KW && LA42_0 <= H_STRING) || LA42_0 == IA5_STRING_KW || LA42_0 == INCLUDES_KW || LA42_0 == INTEGER_KW || (LA42_0 >= ISO646_STR_KW && LA42_0 <= L_PAREN) || LA42_0 == LOWER || (LA42_0 >= MIN_KW && LA42_0 <= NUMERIC_STR_KW) || (LA42_0 >= OBJECT_KW && LA42_0 <= OCTET_KW) || LA42_0 == OPERATION_KW || LA42_0 == PATTERN_KW || LA42_0 == PLUS_INFINITY_KW || LA42_0 == PRINTABLE_STR_KW || LA42_0 == REAL_KW || (LA42_0 >= SEQUENCE_KW && LA42_0 <= SET_KW) || LA42_0 == SIZE_KW || LA42_0 == T61_STR_KW || (LA42_0 >= TELETEX_STR_KW && LA42_0 <= TRUE_KW) || (LA42_0 >= UNIVERSAL_STR_KW && LA42_0 <= WITH_KW) || LA42_0 == 131 || LA42_0 == 137 || (LA42_0 >= 158 && LA42_0 <= 160) || (LA42_0 >= 162 && LA42_0 <= 164) || LA42_0 == 166 || LA42_0 == 179 || LA42_0 == 188 || LA42_0 == 191) )
            	{
            	    alt42 = 1;
            	}
            	switch (alt42) 
            	{
            	    case 1 :
            	        // Smi.g:743:22: element_set_specs
            	        {
            	        	PushFollow(FOLLOW_element_set_specs_in_constraint3267);
            	        	element_set_specs194 = element_set_specs();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_specs194.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:743:42: ( exception_spec )?
            	int alt43 = 2;
            	int LA43_0 = input.LA(1);

            	if ( (LA43_0 == EXCLAMATION) )
            	{
            	    alt43 = 1;
            	}
            	switch (alt43) 
            	{
            	    case 1 :
            	        // Smi.g:743:43: exception_spec
            	        {
            	        	PushFollow(FOLLOW_exception_spec_in_constraint3272);
            	        	exception_spec195 = exception_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, exception_spec195.Tree);

            	        }
            	        break;

            	}

            	R_PAREN196=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint3276); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN196_tree = (CommonTree)adaptor.Create(R_PAREN196);
            		adaptor.AddChild(root_0, R_PAREN196_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint"

    public class character_set_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "character_set"
    // Smi.g:745:0: character_set : ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW );
    public SmiParser.character_set_return character_set() // throws RecognitionException [1]
    {   
        SmiParser.character_set_return retval = new SmiParser.character_set_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set197 = null;

        CommonTree set197_tree=null;

        try 
    	{
            // Smi.g:745:16: ( BMP_STR_KW | GENERALIZED_TIME_KW | GENERAL_STR_KW | GRAPHIC_STR_KW | IA5_STRING_KW | ISO646_STR_KW | NUMERIC_STR_KW | PRINTABLE_STR_KW | TELETEX_STR_KW | T61_STR_KW | UNIVERSAL_STR_KW | UTF8_STR_KW | UTC_TIME_KW | VIDEOTEX_STR_KW | VISIBLE_STR_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set197 = (IToken)input.LT(1);
            	if ( input.LA(1) == BMP_STR_KW || (input.LA(1) >= GENERAL_STR_KW && input.LA(1) <= GRAPHIC_STR_KW) || input.LA(1) == IA5_STRING_KW || input.LA(1) == ISO646_STR_KW || input.LA(1) == NUMERIC_STR_KW || input.LA(1) == PRINTABLE_STR_KW || input.LA(1) == T61_STR_KW || input.LA(1) == TELETEX_STR_KW || input.LA(1) == UNIVERSAL_STR_KW || (input.LA(1) >= UTC_TIME_KW && input.LA(1) <= VISIBLE_STR_KW) ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set197));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "character_set"

    public class elementType_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elementType_list"
    // Smi.g:750:0: elementType_list : elementType ( COMMA elementType )* ;
    public SmiParser.elementType_list_return elementType_list() // throws RecognitionException [1]
    {   
        SmiParser.elementType_list_return retval = new SmiParser.elementType_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA199 = null;
        SmiParser.elementType_return elementType198 = default(SmiParser.elementType_return);

        SmiParser.elementType_return elementType200 = default(SmiParser.elementType_return);


        CommonTree COMMA199_tree=null;

        try 
    	{
            // Smi.g:750:19: ( elementType ( COMMA elementType )* )
            // Smi.g:750:19: elementType ( COMMA elementType )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_elementType_in_elementType_list3385);
            	elementType198 = elementType();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType198.Tree);
            	// Smi.g:750:31: ( COMMA elementType )*
            	do 
            	{
            	    int alt44 = 2;
            	    int LA44_0 = input.LA(1);

            	    if ( (LA44_0 == COMMA) )
            	    {
            	        alt44 = 1;
            	    }


            	    switch (alt44) 
            		{
            			case 1 :
            			    // Smi.g:750:32: COMMA elementType
            			    {
            			    	COMMA199=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_elementType_list3388); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA199_tree = (CommonTree)adaptor.Create(COMMA199);
            			    		adaptor.AddChild(root_0, COMMA199_tree);
            			    	}
            			    	PushFollow(FOLLOW_elementType_in_elementType_list3390);
            			    	elementType200 = elementType();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, elementType200.Tree);

            			    }
            			    break;

            			default:
            			    goto loop44;
            	    }
            	} while (true);

            	loop44:
            		;	// Stops C# compiler whining that label 'loop44' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType_list"

    public class tag_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tag"
    // Smi.g:752:0: tag : L_BRACKET ( clazz )? class_NUMBER R_BRACKET ;
    public SmiParser.tag_return tag() // throws RecognitionException [1]
    {   
        SmiParser.tag_return retval = new SmiParser.tag_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACKET201 = null;
        IToken R_BRACKET204 = null;
        SmiParser.clazz_return clazz202 = default(SmiParser.clazz_return);

        SmiParser.class_NUMBER_return class_NUMBER203 = default(SmiParser.class_NUMBER_return);


        CommonTree L_BRACKET201_tree=null;
        CommonTree R_BRACKET204_tree=null;

        try 
    	{
            // Smi.g:752:6: ( L_BRACKET ( clazz )? class_NUMBER R_BRACKET )
            // Smi.g:752:6: L_BRACKET ( clazz )? class_NUMBER R_BRACKET
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACKET201=(IToken)Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_tag3400); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACKET201_tree = (CommonTree)adaptor.Create(L_BRACKET201);
            		adaptor.AddChild(root_0, L_BRACKET201_tree);
            	}
            	// Smi.g:752:16: ( clazz )?
            	int alt45 = 2;
            	int LA45_0 = input.LA(1);

            	if ( (LA45_0 == APPLICATION_KW || LA45_0 == PRIVATE_KW || LA45_0 == UNIVERSAL_KW) )
            	{
            	    alt45 = 1;
            	}
            	switch (alt45) 
            	{
            	    case 1 :
            	        // Smi.g:752:17: clazz
            	        {
            	        	PushFollow(FOLLOW_clazz_in_tag3403);
            	        	clazz202 = clazz();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, clazz202.Tree);

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_class_NUMBER_in_tag3407);
            	class_NUMBER203 = class_NUMBER();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, class_NUMBER203.Tree);
            	R_BRACKET204=(IToken)Match(input,R_BRACKET,FOLLOW_R_BRACKET_in_tag3409); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACKET204_tree = (CommonTree)adaptor.Create(R_BRACKET204);
            		adaptor.AddChild(root_0, R_BRACKET204_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tag"

    public class clazz_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "clazz"
    // Smi.g:754:0: clazz : ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW );
    public SmiParser.clazz_return clazz() // throws RecognitionException [1]
    {   
        SmiParser.clazz_return retval = new SmiParser.clazz_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set205 = null;

        CommonTree set205_tree=null;

        try 
    	{
            // Smi.g:754:8: ( UNIVERSAL_KW | APPLICATION_KW | PRIVATE_KW )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set205 = (IToken)input.LT(1);
            	if ( input.LA(1) == APPLICATION_KW || input.LA(1) == PRIVATE_KW || input.LA(1) == UNIVERSAL_KW ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set205));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "clazz"

    public class class_NUMBER_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "class_NUMBER"
    // Smi.g:757:0: class_NUMBER : ( NUMBER | defined_value );
    public SmiParser.class_NUMBER_return class_NUMBER() // throws RecognitionException [1]
    {   
        SmiParser.class_NUMBER_return retval = new SmiParser.class_NUMBER_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken NUMBER206 = null;
        SmiParser.defined_value_return defined_value207 = default(SmiParser.defined_value_return);


        CommonTree NUMBER206_tree=null;

        try 
    	{
            // Smi.g:757:15: ( NUMBER | defined_value )
            int alt46 = 2;
            int LA46_0 = input.LA(1);

            if ( (LA46_0 == NUMBER) )
            {
                alt46 = 1;
            }
            else if ( (LA46_0 == LOWER || LA46_0 == UPPER) )
            {
                alt46 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d46s0 =
                    new NoViableAltException("", 46, 0, input);

                throw nvae_d46s0;
            }
            switch (alt46) 
            {
                case 1 :
                    // Smi.g:757:15: NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	NUMBER206=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_class_NUMBER3433); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER206_tree = (CommonTree)adaptor.Create(NUMBER206);
                    		adaptor.AddChild(root_0, NUMBER206_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:757:24: defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_class_NUMBER3437);
                    	defined_value207 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value207.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "class_NUMBER"

    public class operation_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "operation_macro"
    // Smi.g:760:0: operation_macro : 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? ;
    public SmiParser.operation_macro_return operation_macro() // throws RecognitionException [1]
    {   
        SmiParser.operation_macro_return retval = new SmiParser.operation_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal208 = null;
        IToken ARGUMENT_KW209 = null;
        IToken LOWER210 = null;
        IToken RESULT_KW212 = null;
        IToken LOWER213 = null;
        IToken ERRORS_KW215 = null;
        IToken L_BRACE216 = null;
        IToken R_BRACE218 = null;
        IToken LINKED_KW219 = null;
        IToken L_BRACE220 = null;
        IToken R_BRACE222 = null;
        SmiParser.type_return type211 = default(SmiParser.type_return);

        SmiParser.type_return type214 = default(SmiParser.type_return);

        SmiParser.operation_errorlist_return operation_errorlist217 = default(SmiParser.operation_errorlist_return);

        SmiParser.linkedOp_list_return linkedOp_list221 = default(SmiParser.linkedOp_list_return);


        CommonTree string_literal208_tree=null;
        CommonTree ARGUMENT_KW209_tree=null;
        CommonTree LOWER210_tree=null;
        CommonTree RESULT_KW212_tree=null;
        CommonTree LOWER213_tree=null;
        CommonTree ERRORS_KW215_tree=null;
        CommonTree L_BRACE216_tree=null;
        CommonTree R_BRACE218_tree=null;
        CommonTree LINKED_KW219_tree=null;
        CommonTree L_BRACE220_tree=null;
        CommonTree R_BRACE222_tree=null;

        try 
    	{
            // Smi.g:760:18: ( 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )? )
            // Smi.g:760:18: 'OPERATION' ( ARGUMENT_KW (=> LOWER )? type )? (=> RESULT_KW (=> (=> LOWER )? type )? )? (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )? (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal208=(IToken)Match(input,OPERATION_KW,FOLLOW_OPERATION_KW_in_operation_macro3446); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal208_tree = (CommonTree)adaptor.Create(string_literal208);
            		adaptor.AddChild(root_0, string_literal208_tree);
            	}
            	// Smi.g:760:30: ( ARGUMENT_KW (=> LOWER )? type )?
            	int alt48 = 2;
            	int LA48_0 = input.LA(1);

            	if ( (LA48_0 == ARGUMENT_KW) )
            	{
            	    alt48 = 1;
            	}
            	switch (alt48) 
            	{
            	    case 1 :
            	        // Smi.g:760:31: ARGUMENT_KW (=> LOWER )? type
            	        {
            	        	ARGUMENT_KW209=(IToken)Match(input,ARGUMENT_KW,FOLLOW_ARGUMENT_KW_in_operation_macro3449); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ARGUMENT_KW209_tree = (CommonTree)adaptor.Create(ARGUMENT_KW209);
            	        		adaptor.AddChild(root_0, ARGUMENT_KW209_tree);
            	        	}
            	        	// Smi.g:760:43: (=> LOWER )?
            	        	int alt47 = 2;
            	        	alt47 = dfa47.Predict(input);
            	        	switch (alt47) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:760:44: => LOWER
            	        	        {

            	        	        	LOWER210=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3458); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER210_tree = (CommonTree)adaptor.Create(LOWER210);
            	        	        		adaptor.AddChild(root_0, LOWER210_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_operation_macro3462);
            	        	type211 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type211.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:761:21: (=> RESULT_KW (=> (=> LOWER )? type )? )?
            	int alt51 = 2;
            	int LA51_0 = input.LA(1);

            	if ( (LA51_0 == RESULT_KW) )
            	{
            	    int LA51_1 = input.LA(2);

            	    if ( (synpred19_Smi()) )
            	    {
            	        alt51 = 1;
            	    }
            	}
            	switch (alt51) 
            	{
            	    case 1 :
            	        // Smi.g:761:23: => RESULT_KW (=> (=> LOWER )? type )?
            	        {

            	        	RESULT_KW212=(IToken)Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_operation_macro3496); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{RESULT_KW212_tree = (CommonTree)adaptor.Create(RESULT_KW212);
            	        		adaptor.AddChild(root_0, RESULT_KW212_tree);
            	        	}
            	        	// Smi.g:762:25: (=> (=> LOWER )? type )?
            	        	int alt50 = 2;
            	        	alt50 = dfa50.Predict(input);
            	        	switch (alt50) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:762:26: => (=> LOWER )? type
            	        	        {

            	        	        	// Smi.g:762:37: (=> LOWER )?
            	        	        	int alt49 = 2;
            	        	        	alt49 = dfa49.Predict(input);
            	        	        	switch (alt49) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:762:38: => LOWER
            	        	        	        {

            	        	        	        	LOWER213=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_operation_macro3537); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER213_tree = (CommonTree)adaptor.Create(LOWER213);
            	        	        	        		adaptor.AddChild(root_0, LOWER213_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	PushFollow(FOLLOW_type_in_operation_macro3541);
            	        	        	type214 = type();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type214.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:764:21: (=> ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE )?
            	int alt53 = 2;
            	int LA53_0 = input.LA(1);

            	if ( (LA53_0 == ERRORS_KW) )
            	{
            	    int LA53_1 = input.LA(2);

            	    if ( (synpred22_Smi()) )
            	    {
            	        alt53 = 1;
            	    }
            	}
            	switch (alt53) 
            	{
            	    case 1 :
            	        // Smi.g:764:23: => ERRORS_KW L_BRACE ( operation_errorlist )? R_BRACE
            	        {

            	        	ERRORS_KW215=(IToken)Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_operation_macro3583); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{ERRORS_KW215_tree = (CommonTree)adaptor.Create(ERRORS_KW215);
            	        		adaptor.AddChild(root_0, ERRORS_KW215_tree);
            	        	}
            	        	L_BRACE216=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3585); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE216_tree = (CommonTree)adaptor.Create(L_BRACE216);
            	        		adaptor.AddChild(root_0, L_BRACE216_tree);
            	        	}
            	        	// Smi.g:764:56: ( operation_errorlist )?
            	        	int alt52 = 2;
            	        	int LA52_0 = input.LA(1);

            	        	if ( (LA52_0 == ANY_KW || LA52_0 == B_STRING || (LA52_0 >= BIT_KW && LA52_0 <= BOOLEAN_KW) || (LA52_0 >= C_STRING && LA52_0 <= CHARACTER_KW) || LA52_0 == CHOICE_KW || LA52_0 == EMBEDDED_KW || (LA52_0 >= ENUMERATED_KW && LA52_0 <= ERROR_KW) || (LA52_0 >= EXTERNAL_KW && LA52_0 <= FALSE_KW) || (LA52_0 >= GENERAL_STR_KW && LA52_0 <= H_STRING) || LA52_0 == IA5_STRING_KW || LA52_0 == INTEGER_KW || (LA52_0 >= ISO646_STR_KW && LA52_0 <= L_BRACKET) || LA52_0 == LOWER || (LA52_0 >= MINUS && LA52_0 <= NUMERIC_STR_KW) || (LA52_0 >= OBJECT_KW && LA52_0 <= OCTET_KW) || LA52_0 == OPERATION_KW || LA52_0 == PLUS_INFINITY_KW || LA52_0 == PRINTABLE_STR_KW || LA52_0 == REAL_KW || (LA52_0 >= SEQUENCE_KW && LA52_0 <= SET_KW) || LA52_0 == T61_STR_KW || (LA52_0 >= TELETEX_STR_KW && LA52_0 <= TRUE_KW) || (LA52_0 >= UNIVERSAL_STR_KW && LA52_0 <= VISIBLE_STR_KW) || LA52_0 == 131 || LA52_0 == 137 || (LA52_0 >= 158 && LA52_0 <= 160) || (LA52_0 >= 162 && LA52_0 <= 164) || LA52_0 == 166 || LA52_0 == 179 || LA52_0 == 188 || LA52_0 == 191) )
            	        	{
            	        	    alt52 = 1;
            	        	}
            	        	switch (alt52) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:764:57: operation_errorlist
            	        	        {
            	        	        	PushFollow(FOLLOW_operation_errorlist_in_operation_macro3588);
            	        	        	operation_errorlist217 = operation_errorlist();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_errorlist217.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE218=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3592); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE218_tree = (CommonTree)adaptor.Create(R_BRACE218);
            	        		adaptor.AddChild(root_0, R_BRACE218_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:765:21: (=> LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE )?
            	int alt55 = 2;
            	int LA55_0 = input.LA(1);

            	if ( (LA55_0 == LINKED_KW) )
            	{
            	    int LA55_1 = input.LA(2);

            	    if ( (synpred23_Smi()) )
            	    {
            	        alt55 = 1;
            	    }
            	}
            	switch (alt55) 
            	{
            	    case 1 :
            	        // Smi.g:765:23: => LINKED_KW L_BRACE ( linkedOp_list )? R_BRACE
            	        {

            	        	LINKED_KW219=(IToken)Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_operation_macro3626); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LINKED_KW219_tree = (CommonTree)adaptor.Create(LINKED_KW219);
            	        		adaptor.AddChild(root_0, LINKED_KW219_tree);
            	        	}
            	        	L_BRACE220=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_operation_macro3628); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE220_tree = (CommonTree)adaptor.Create(L_BRACE220);
            	        		adaptor.AddChild(root_0, L_BRACE220_tree);
            	        	}
            	        	// Smi.g:765:56: ( linkedOp_list )?
            	        	int alt54 = 2;
            	        	int LA54_0 = input.LA(1);

            	        	if ( (LA54_0 == ANY_KW || LA54_0 == B_STRING || (LA54_0 >= BIT_KW && LA54_0 <= BOOLEAN_KW) || (LA54_0 >= C_STRING && LA54_0 <= CHARACTER_KW) || LA54_0 == CHOICE_KW || LA54_0 == EMBEDDED_KW || (LA54_0 >= ENUMERATED_KW && LA54_0 <= ERROR_KW) || (LA54_0 >= EXTERNAL_KW && LA54_0 <= FALSE_KW) || (LA54_0 >= GENERAL_STR_KW && LA54_0 <= H_STRING) || LA54_0 == IA5_STRING_KW || LA54_0 == INTEGER_KW || (LA54_0 >= ISO646_STR_KW && LA54_0 <= L_BRACKET) || LA54_0 == LOWER || (LA54_0 >= MINUS && LA54_0 <= NUMERIC_STR_KW) || (LA54_0 >= OBJECT_KW && LA54_0 <= OCTET_KW) || LA54_0 == OPERATION_KW || LA54_0 == PLUS_INFINITY_KW || LA54_0 == PRINTABLE_STR_KW || LA54_0 == REAL_KW || (LA54_0 >= SEQUENCE_KW && LA54_0 <= SET_KW) || LA54_0 == T61_STR_KW || (LA54_0 >= TELETEX_STR_KW && LA54_0 <= TRUE_KW) || (LA54_0 >= UNIVERSAL_STR_KW && LA54_0 <= VISIBLE_STR_KW) || LA54_0 == 131 || LA54_0 == 137 || (LA54_0 >= 158 && LA54_0 <= 160) || (LA54_0 >= 162 && LA54_0 <= 164) || LA54_0 == 166 || LA54_0 == 179 || LA54_0 == 188 || LA54_0 == 191) )
            	        	{
            	        	    alt54 = 1;
            	        	}
            	        	switch (alt54) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:765:57: linkedOp_list
            	        	        {
            	        	        	PushFollow(FOLLOW_linkedOp_list_in_operation_macro3631);
            	        	        	linkedOp_list221 = linkedOp_list();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, linkedOp_list221.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE222=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_operation_macro3635); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE222_tree = (CommonTree)adaptor.Create(R_BRACE222);
            	        		adaptor.AddChild(root_0, R_BRACE222_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_macro"

    public class error_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "error_macro"
    // Smi.g:775:0: error_macro : ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? ;
    public SmiParser.error_macro_return error_macro() // throws RecognitionException [1]
    {   
        SmiParser.error_macro_return retval = new SmiParser.error_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken ERROR_KW223 = null;
        IToken PARAMETER_KW224 = null;
        IToken LOWER225 = null;
        SmiParser.type_return type226 = default(SmiParser.type_return);


        CommonTree ERROR_KW223_tree=null;
        CommonTree PARAMETER_KW224_tree=null;
        CommonTree LOWER225_tree=null;

        try 
    	{
            // Smi.g:775:14: ( ERROR_KW ( PARAMETER_KW (=> LOWER )? type )? )
            // Smi.g:775:14: ERROR_KW ( PARAMETER_KW (=> LOWER )? type )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	ERROR_KW223=(IToken)Match(input,ERROR_KW,FOLLOW_ERROR_KW_in_error_macro3655); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{ERROR_KW223_tree = (CommonTree)adaptor.Create(ERROR_KW223);
            		adaptor.AddChild(root_0, ERROR_KW223_tree);
            	}
            	// Smi.g:775:23: ( PARAMETER_KW (=> LOWER )? type )?
            	int alt57 = 2;
            	int LA57_0 = input.LA(1);

            	if ( (LA57_0 == PARAMETER_KW) )
            	{
            	    alt57 = 1;
            	}
            	switch (alt57) 
            	{
            	    case 1 :
            	        // Smi.g:775:25: PARAMETER_KW (=> LOWER )? type
            	        {
            	        	PARAMETER_KW224=(IToken)Match(input,PARAMETER_KW,FOLLOW_PARAMETER_KW_in_error_macro3659); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{PARAMETER_KW224_tree = (CommonTree)adaptor.Create(PARAMETER_KW224);
            	        		adaptor.AddChild(root_0, PARAMETER_KW224_tree);
            	        	}
            	        	// Smi.g:775:38: (=> LOWER )?
            	        	int alt56 = 2;
            	        	alt56 = dfa56.Predict(input);
            	        	switch (alt56) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:775:39: => LOWER
            	        	        {

            	        	        	LOWER225=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_error_macro3668); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{LOWER225_tree = (CommonTree)adaptor.Create(LOWER225);
            	        	        		adaptor.AddChild(root_0, LOWER225_tree);
            	        	        	}

            	        	        }
            	        	        break;

            	        	}

            	        	PushFollow(FOLLOW_type_in_error_macro3672);
            	        	type226 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type226.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "error_macro"

    public class macros_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "macros_type"
    // Smi.g:782:0: macros_type : ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro );
    public SmiParser.macros_type_return macros_type() // throws RecognitionException [1]
    {   
        SmiParser.macros_type_return retval = new SmiParser.macros_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.operation_macro_return operation_macro227 = default(SmiParser.operation_macro_return);

        SmiParser.error_macro_return error_macro228 = default(SmiParser.error_macro_return);

        SmiParser.objecttype_macro_return objecttype_macro229 = default(SmiParser.objecttype_macro_return);

        SmiParser.moduleidentity_macro_return moduleidentity_macro230 = default(SmiParser.moduleidentity_macro_return);

        SmiParser.objectidentity_macro_return objectidentity_macro231 = default(SmiParser.objectidentity_macro_return);

        SmiParser.notificationtype_macro_return notificationtype_macro232 = default(SmiParser.notificationtype_macro_return);

        SmiParser.textualconvention_macro_return textualconvention_macro233 = default(SmiParser.textualconvention_macro_return);

        SmiParser.objectgroup_macro_return objectgroup_macro234 = default(SmiParser.objectgroup_macro_return);

        SmiParser.notificationgroup_macro_return notificationgroup_macro235 = default(SmiParser.notificationgroup_macro_return);

        SmiParser.modulecompliance_macro_return modulecompliance_macro236 = default(SmiParser.modulecompliance_macro_return);

        SmiParser.agentcapabilities_macro_return agentcapabilities_macro237 = default(SmiParser.agentcapabilities_macro_return);

        SmiParser.traptype_macro_return traptype_macro238 = default(SmiParser.traptype_macro_return);



        try 
    	{
            // Smi.g:782:14: ( operation_macro | error_macro | objecttype_macro | moduleidentity_macro | objectidentity_macro | notificationtype_macro | textualconvention_macro | objectgroup_macro | notificationgroup_macro | modulecompliance_macro | agentcapabilities_macro | traptype_macro )
            int alt58 = 12;
            switch ( input.LA(1) ) 
            {
            case OPERATION_KW:
            	{
                alt58 = 1;
                }
                break;
            case ERROR_KW:
            	{
                alt58 = 2;
                }
                break;
            case 166:
            	{
                alt58 = 3;
                }
                break;
            case 159:
            	{
                alt58 = 4;
                }
                break;
            case 164:
            	{
                alt58 = 5;
                }
                break;
            case 162:
            	{
                alt58 = 6;
                }
                break;
            case 188:
            	{
                alt58 = 7;
                }
                break;
            case 163:
            	{
                alt58 = 8;
                }
                break;
            case 160:
            	{
                alt58 = 9;
                }
                break;
            case 158:
            	{
                alt58 = 10;
                }
                break;
            case 131:
            	{
                alt58 = 11;
                }
                break;
            case 191:
            	{
                alt58 = 12;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d58s0 =
            	        new NoViableAltException("", 58, 0, input);

            	    throw nvae_d58s0;
            }

            switch (alt58) 
            {
                case 1 :
                    // Smi.g:782:14: operation_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_operation_macro_in_macros_type3690);
                    	operation_macro227 = operation_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, operation_macro227.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:782:32: error_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_error_macro_in_macros_type3694);
                    	error_macro228 = error_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, error_macro228.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:782:46: objecttype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objecttype_macro_in_macros_type3698);
                    	objecttype_macro229 = objecttype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro229.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:782:65: moduleidentity_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_in_macros_type3702);
                    	moduleidentity_macro230 = moduleidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro230.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:783:14: objectidentity_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectidentity_macro_in_macros_type3718);
                    	objectidentity_macro231 = objectidentity_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro231.Tree);

                    }
                    break;
                case 6 :
                    // Smi.g:783:37: notificationtype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationtype_macro_in_macros_type3722);
                    	notificationtype_macro232 = notificationtype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro232.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:783:62: textualconvention_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_textualconvention_macro_in_macros_type3726);
                    	textualconvention_macro233 = textualconvention_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro233.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:784:14: objectgroup_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_objectgroup_macro_in_macros_type3742);
                    	objectgroup_macro234 = objectgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro234.Tree);

                    }
                    break;
                case 9 :
                    // Smi.g:784:34: notificationgroup_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_notificationgroup_macro_in_macros_type3746);
                    	notificationgroup_macro235 = notificationgroup_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro235.Tree);

                    }
                    break;
                case 10 :
                    // Smi.g:784:60: modulecompliance_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_modulecompliance_macro_in_macros_type3750);
                    	modulecompliance_macro236 = modulecompliance_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro236.Tree);

                    }
                    break;
                case 11 :
                    // Smi.g:785:14: agentcapabilities_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_agentcapabilities_macro_in_macros_type3766);
                    	agentcapabilities_macro237 = agentcapabilities_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro237.Tree);

                    }
                    break;
                case 12 :
                    // Smi.g:785:40: traptype_macro
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_traptype_macro_in_macros_type3770);
                    	traptype_macro238 = traptype_macro();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, traptype_macro238.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "macros_type"

    public class smi_macros_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_macros"
    // Smi.g:787:0: smi_macros : ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' );
    public SmiParser.smi_macros_return smi_macros() // throws RecognitionException [1]
    {   
        SmiParser.smi_macros_return retval = new SmiParser.smi_macros_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set239 = null;

        CommonTree set239_tree=null;

        try 
    	{
            // Smi.g:787:13: ( 'OBJECT-TYPE' | 'MODULE-IDENTITY' | 'OBJECT-IDENTITY' | 'NOTIFICATION-TYPE' | 'TEXTUAL-CONVENTION' | 'OBJECT-GROUP' | 'NOTIFICATION-GROUP' | 'MODULE-COMPLIANCE' | 'AGENT-CAPABILITIES' | 'TRAP-TYPE' )
            // Smi.g:
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	set239 = (IToken)input.LT(1);
            	if ( input.LA(1) == 131 || (input.LA(1) >= 158 && input.LA(1) <= 160) || (input.LA(1) >= 162 && input.LA(1) <= 164) || input.LA(1) == 166 || input.LA(1) == 188 || input.LA(1) == 191 ) 
            	{
            	    input.Consume();
            	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set239));
            	    state.errorRecovery = false;state.failed = false;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	    throw mse;
            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_macros"

    public class smi_type_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_type"
    // Smi.g:793:0: smi_type : ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER );
    public SmiParser.smi_type_return smi_type() // throws RecognitionException [1]
    {   
        SmiParser.smi_type_return retval = new SmiParser.smi_type_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal240 = null;
        IToken INTEGER_KW241 = null;
        IToken OCTET_KW242 = null;
        IToken STRING_KW243 = null;
        IToken OBJECT_KW244 = null;
        IToken IDENTIFIER_KW245 = null;
        IToken UPPER246 = null;

        CommonTree string_literal240_tree=null;
        CommonTree INTEGER_KW241_tree=null;
        CommonTree OCTET_KW242_tree=null;
        CommonTree STRING_KW243_tree=null;
        CommonTree OBJECT_KW244_tree=null;
        CommonTree IDENTIFIER_KW245_tree=null;
        CommonTree UPPER246_tree=null;

        try 
    	{
            // Smi.g:793:11: ( 'BITS' | INTEGER_KW | OCTET_KW STRING_KW | OBJECT_KW IDENTIFIER_KW | UPPER )
            int alt59 = 5;
            switch ( input.LA(1) ) 
            {
            case 137:
            	{
                alt59 = 1;
                }
                break;
            case INTEGER_KW:
            	{
                alt59 = 2;
                }
                break;
            case OCTET_KW:
            	{
                alt59 = 3;
                }
                break;
            case OBJECT_KW:
            	{
                alt59 = 4;
                }
                break;
            case UPPER:
            	{
                alt59 = 5;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d59s0 =
            	        new NoViableAltException("", 59, 0, input);

            	    throw nvae_d59s0;
            }

            switch (alt59) 
            {
                case 1 :
                    // Smi.g:793:11: 'BITS'
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal240=(IToken)Match(input,137,FOLLOW_137_in_smi_type3844); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal240_tree = (CommonTree)adaptor.Create(string_literal240);
                    		adaptor.AddChild(root_0, string_literal240_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:793:20: INTEGER_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	INTEGER_KW241=(IToken)Match(input,INTEGER_KW,FOLLOW_INTEGER_KW_in_smi_type3848); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{INTEGER_KW241_tree = (CommonTree)adaptor.Create(INTEGER_KW241);
                    		adaptor.AddChild(root_0, INTEGER_KW241_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:793:33: OCTET_KW STRING_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OCTET_KW242=(IToken)Match(input,OCTET_KW,FOLLOW_OCTET_KW_in_smi_type3852); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OCTET_KW242_tree = (CommonTree)adaptor.Create(OCTET_KW242);
                    		adaptor.AddChild(root_0, OCTET_KW242_tree);
                    	}
                    	STRING_KW243=(IToken)Match(input,STRING_KW,FOLLOW_STRING_KW_in_smi_type3854); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{STRING_KW243_tree = (CommonTree)adaptor.Create(STRING_KW243);
                    		adaptor.AddChild(root_0, STRING_KW243_tree);
                    	}

                    }
                    break;
                case 4 :
                    // Smi.g:793:54: OBJECT_KW IDENTIFIER_KW
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	OBJECT_KW244=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_smi_type3858); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OBJECT_KW244_tree = (CommonTree)adaptor.Create(OBJECT_KW244);
                    		adaptor.AddChild(root_0, OBJECT_KW244_tree);
                    	}
                    	IDENTIFIER_KW245=(IToken)Match(input,IDENTIFIER_KW,FOLLOW_IDENTIFIER_KW_in_smi_type3860); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{IDENTIFIER_KW245_tree = (CommonTree)adaptor.Create(IDENTIFIER_KW245);
                    		adaptor.AddChild(root_0, IDENTIFIER_KW245_tree);
                    	}

                    }
                    break;
                case 5 :
                    // Smi.g:793:80: UPPER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	UPPER246=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_smi_type3864); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{UPPER246_tree = (CommonTree)adaptor.Create(UPPER246);
                    		adaptor.AddChild(root_0, UPPER246_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_type"

    public class smi_subtyping_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "smi_subtyping"
    // Smi.g:799:0: smi_subtyping : ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN );
    public SmiParser.smi_subtyping_return smi_subtyping() // throws RecognitionException [1]
    {   
        SmiParser.smi_subtyping_return retval = new SmiParser.smi_subtyping_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_PAREN247 = null;
        IToken BAR249 = null;
        IToken R_PAREN251 = null;
        IToken L_PAREN252 = null;
        IToken string_literal253 = null;
        IToken L_PAREN254 = null;
        IToken BAR256 = null;
        IToken R_PAREN258 = null;
        IToken R_PAREN259 = null;
        SmiParser.subtype_range_return subtype_range248 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range250 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range255 = default(SmiParser.subtype_range_return);

        SmiParser.subtype_range_return subtype_range257 = default(SmiParser.subtype_range_return);


        CommonTree L_PAREN247_tree=null;
        CommonTree BAR249_tree=null;
        CommonTree R_PAREN251_tree=null;
        CommonTree L_PAREN252_tree=null;
        CommonTree string_literal253_tree=null;
        CommonTree L_PAREN254_tree=null;
        CommonTree BAR256_tree=null;
        CommonTree R_PAREN258_tree=null;
        CommonTree R_PAREN259_tree=null;

        try 
    	{
            // Smi.g:799:16: ( L_PAREN subtype_range ( BAR subtype_range )* R_PAREN | L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN )
            int alt62 = 2;
            int LA62_0 = input.LA(1);

            if ( (LA62_0 == L_PAREN) )
            {
                int LA62_1 = input.LA(2);

                if ( (LA62_1 == SIZE_KW) )
                {
                    alt62 = 2;
                }
                else if ( (LA62_1 == B_STRING || LA62_1 == H_STRING || LA62_1 == MINUS || LA62_1 == NUMBER) )
                {
                    alt62 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d62s1 =
                        new NoViableAltException("", 62, 1, input);

                    throw nvae_d62s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d62s0 =
                    new NoViableAltException("", 62, 0, input);

                throw nvae_d62s0;
            }
            switch (alt62) 
            {
                case 1 :
                    // Smi.g:799:16: L_PAREN subtype_range ( BAR subtype_range )* R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN247=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3878); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN247_tree = (CommonTree)adaptor.Create(L_PAREN247);
                    		adaptor.AddChild(root_0, L_PAREN247_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3880);
                    	subtype_range248 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range248.Tree);
                    	// Smi.g:799:38: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt60 = 2;
                    	    int LA60_0 = input.LA(1);

                    	    if ( (LA60_0 == BAR) )
                    	    {
                    	        alt60 = 1;
                    	    }


                    	    switch (alt60) 
                    		{
                    			case 1 :
                    			    // Smi.g:799:39: BAR subtype_range
                    			    {
                    			    	BAR249=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3883); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR249_tree = (CommonTree)adaptor.Create(BAR249);
                    			    		adaptor.AddChild(root_0, BAR249_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3885);
                    			    	subtype_range250 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range250.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop60;
                    	    }
                    	} while (true);

                    	loop60:
                    		;	// Stops C# compiler whining that label 'loop60' has no statements

                    	R_PAREN251=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3889); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN251_tree = (CommonTree)adaptor.Create(R_PAREN251);
                    		adaptor.AddChild(root_0, R_PAREN251_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:800:16: L_PAREN 'SIZE' L_PAREN subtype_range ( BAR subtype_range )* R_PAREN R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN252=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3906); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN252_tree = (CommonTree)adaptor.Create(L_PAREN252);
                    		adaptor.AddChild(root_0, L_PAREN252_tree);
                    	}
                    	string_literal253=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_smi_subtyping3908); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal253_tree = (CommonTree)adaptor.Create(string_literal253);
                    		adaptor.AddChild(root_0, string_literal253_tree);
                    	}
                    	L_PAREN254=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_smi_subtyping3910); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN254_tree = (CommonTree)adaptor.Create(L_PAREN254);
                    		adaptor.AddChild(root_0, L_PAREN254_tree);
                    	}
                    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3912);
                    	subtype_range255 = subtype_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range255.Tree);
                    	// Smi.g:800:53: ( BAR subtype_range )*
                    	do 
                    	{
                    	    int alt61 = 2;
                    	    int LA61_0 = input.LA(1);

                    	    if ( (LA61_0 == BAR) )
                    	    {
                    	        alt61 = 1;
                    	    }


                    	    switch (alt61) 
                    		{
                    			case 1 :
                    			    // Smi.g:800:54: BAR subtype_range
                    			    {
                    			    	BAR256=(IToken)Match(input,BAR,FOLLOW_BAR_in_smi_subtyping3915); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{BAR256_tree = (CommonTree)adaptor.Create(BAR256);
                    			    		adaptor.AddChild(root_0, BAR256_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_subtype_range_in_smi_subtyping3917);
                    			    	subtype_range257 = subtype_range();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_range257.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop61;
                    	    }
                    	} while (true);

                    	loop61:
                    		;	// Stops C# compiler whining that label 'loop61' has no statements

                    	R_PAREN258=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3921); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN258_tree = (CommonTree)adaptor.Create(R_PAREN258);
                    		adaptor.AddChild(root_0, R_PAREN258_tree);
                    	}
                    	R_PAREN259=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_smi_subtyping3923); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN259_tree = (CommonTree)adaptor.Create(R_PAREN259);
                    		adaptor.AddChild(root_0, R_PAREN259_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "smi_subtyping"

    public class subtype_range_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "subtype_range"
    // Smi.g:801:0: subtype_range : subtype_value ( DOTDOT subtype_value )? ;
    public SmiParser.subtype_range_return subtype_range() // throws RecognitionException [1]
    {   
        SmiParser.subtype_range_return retval = new SmiParser.subtype_range_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken DOTDOT261 = null;
        SmiParser.subtype_value_return subtype_value260 = default(SmiParser.subtype_value_return);

        SmiParser.subtype_value_return subtype_value262 = default(SmiParser.subtype_value_return);


        CommonTree DOTDOT261_tree=null;

        try 
    	{
            // Smi.g:801:16: ( subtype_value ( DOTDOT subtype_value )? )
            // Smi.g:801:16: subtype_value ( DOTDOT subtype_value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_subtype_value_in_subtype_range3929);
            	subtype_value260 = subtype_value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value260.Tree);
            	// Smi.g:801:30: ( DOTDOT subtype_value )?
            	int alt63 = 2;
            	int LA63_0 = input.LA(1);

            	if ( (LA63_0 == DOTDOT) )
            	{
            	    alt63 = 1;
            	}
            	switch (alt63) 
            	{
            	    case 1 :
            	        // Smi.g:801:31: DOTDOT subtype_value
            	        {
            	        	DOTDOT261=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_subtype_range3932); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOT261_tree = (CommonTree)adaptor.Create(DOTDOT261);
            	        		adaptor.AddChild(root_0, DOTDOT261_tree);
            	        	}
            	        	PushFollow(FOLLOW_subtype_value_in_subtype_range3934);
            	        	subtype_value262 = subtype_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, subtype_value262.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_range"

    public class subtype_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "subtype_value"
    // Smi.g:802:0: subtype_value : ( ( MINUS )? NUMBER | B_STRING | H_STRING );
    public SmiParser.subtype_value_return subtype_value() // throws RecognitionException [1]
    {   
        SmiParser.subtype_value_return retval = new SmiParser.subtype_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS263 = null;
        IToken NUMBER264 = null;
        IToken B_STRING265 = null;
        IToken H_STRING266 = null;

        CommonTree MINUS263_tree=null;
        CommonTree NUMBER264_tree=null;
        CommonTree B_STRING265_tree=null;
        CommonTree H_STRING266_tree=null;

        try 
    	{
            // Smi.g:802:16: ( ( MINUS )? NUMBER | B_STRING | H_STRING )
            int alt65 = 3;
            switch ( input.LA(1) ) 
            {
            case MINUS:
            case NUMBER:
            	{
                alt65 = 1;
                }
                break;
            case B_STRING:
            	{
                alt65 = 2;
                }
                break;
            case H_STRING:
            	{
                alt65 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d65s0 =
            	        new NoViableAltException("", 65, 0, input);

            	    throw nvae_d65s0;
            }

            switch (alt65) 
            {
                case 1 :
                    // Smi.g:802:16: ( MINUS )? NUMBER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:802:16: ( MINUS )?
                    	int alt64 = 2;
                    	int LA64_0 = input.LA(1);

                    	if ( (LA64_0 == MINUS) )
                    	{
                    	    alt64 = 1;
                    	}
                    	switch (alt64) 
                    	{
                    	    case 1 :
                    	        // Smi.g:802:17: MINUS
                    	        {
                    	        	MINUS263=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_subtype_value3944); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{MINUS263_tree = (CommonTree)adaptor.Create(MINUS263);
                    	        		adaptor.AddChild(root_0, MINUS263_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	NUMBER264=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_subtype_value3948); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{NUMBER264_tree = (CommonTree)adaptor.Create(NUMBER264);
                    		adaptor.AddChild(root_0, NUMBER264_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:802:34: B_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	B_STRING265=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_subtype_value3952); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING265_tree = (CommonTree)adaptor.Create(B_STRING265);
                    		adaptor.AddChild(root_0, B_STRING265_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:802:45: H_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	H_STRING266=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_subtype_value3956); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING266_tree = (CommonTree)adaptor.Create(H_STRING266);
                    		adaptor.AddChild(root_0, H_STRING266_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "subtype_value"

    public class objecttype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro"
    // Smi.g:805:0: objecttype_macro : 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? ;
    public SmiParser.objecttype_macro_return objecttype_macro() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_return retval = new SmiParser.objecttype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal267 = null;
        IToken string_literal268 = null;
        IToken string_literal274 = null;
        IToken C_STRING275 = null;
        IToken set276 = null;
        IToken string_literal278 = null;
        IToken string_literal280 = null;
        IToken L_BRACE281 = null;
        IToken R_BRACE283 = null;
        IToken string_literal284 = null;
        IToken L_BRACE285 = null;
        IToken R_BRACE287 = null;
        IToken string_literal288 = null;
        IToken string_literal290 = null;
        IToken C_STRING291 = null;
        IToken string_literal292 = null;
        IToken L_BRACE293 = null;
        IToken COMMA295 = null;
        IToken R_BRACE297 = null;
        IToken string_literal298 = null;
        IToken C_STRING299 = null;
        IToken string_literal300 = null;
        IToken string_literal302 = null;
        IToken string_literal304 = null;
        IToken L_BRACE305 = null;
        IToken R_BRACE307 = null;
        IToken string_literal308 = null;
        IToken L_BRACE309 = null;
        IToken R_BRACE311 = null;
        IToken string_literal312 = null;
        IToken string_literal314 = null;
        IToken L_BRACE315 = null;
        IToken COMMA317 = null;
        IToken R_BRACE319 = null;
        IToken string_literal320 = null;
        IToken L_BRACE321 = null;
        IToken R_BRACE324 = null;
        SmiParser.smi_type_return smi_type269 = default(SmiParser.smi_type_return);

        SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits270 = default(SmiParser.objecttype_macro_namedbits_return);

        SmiParser.smi_type_return smi_type271 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping272 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type273 = default(SmiParser.type_return);

        SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes277 = default(SmiParser.objecttype_macro_accesstypes_return);

        SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess279 = default(SmiParser.objecttype_macro_pibaccess_return);

        SmiParser.value_return value282 = default(SmiParser.value_return);

        SmiParser.value_return value286 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes289 = default(SmiParser.objecttype_macro_statustypes_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error294 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_error_return objecttype_macro_error296 = default(SmiParser.objecttype_macro_error_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index301 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.objecttype_macro_augments_return objecttype_macro_augments303 = default(SmiParser.objecttype_macro_augments_return);

        SmiParser.value_return value306 = default(SmiParser.value_return);

        SmiParser.value_return value310 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_index_return objecttype_macro_index313 = default(SmiParser.objecttype_macro_index_return);

        SmiParser.value_return value316 = default(SmiParser.value_return);

        SmiParser.value_return value318 = default(SmiParser.value_return);

        SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue322 = default(SmiParser.objecttype_macro_bitsvalue_return);

        SmiParser.value_return value323 = default(SmiParser.value_return);


        CommonTree string_literal267_tree=null;
        CommonTree string_literal268_tree=null;
        CommonTree string_literal274_tree=null;
        CommonTree C_STRING275_tree=null;
        CommonTree set276_tree=null;
        CommonTree string_literal278_tree=null;
        CommonTree string_literal280_tree=null;
        CommonTree L_BRACE281_tree=null;
        CommonTree R_BRACE283_tree=null;
        CommonTree string_literal284_tree=null;
        CommonTree L_BRACE285_tree=null;
        CommonTree R_BRACE287_tree=null;
        CommonTree string_literal288_tree=null;
        CommonTree string_literal290_tree=null;
        CommonTree C_STRING291_tree=null;
        CommonTree string_literal292_tree=null;
        CommonTree L_BRACE293_tree=null;
        CommonTree COMMA295_tree=null;
        CommonTree R_BRACE297_tree=null;
        CommonTree string_literal298_tree=null;
        CommonTree C_STRING299_tree=null;
        CommonTree string_literal300_tree=null;
        CommonTree string_literal302_tree=null;
        CommonTree string_literal304_tree=null;
        CommonTree L_BRACE305_tree=null;
        CommonTree R_BRACE307_tree=null;
        CommonTree string_literal308_tree=null;
        CommonTree L_BRACE309_tree=null;
        CommonTree R_BRACE311_tree=null;
        CommonTree string_literal312_tree=null;
        CommonTree string_literal314_tree=null;
        CommonTree L_BRACE315_tree=null;
        CommonTree COMMA317_tree=null;
        CommonTree R_BRACE319_tree=null;
        CommonTree string_literal320_tree=null;
        CommonTree L_BRACE321_tree=null;
        CommonTree R_BRACE324_tree=null;

        try 
    	{
            // Smi.g:805:19: ( 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )? )
            // Smi.g:805:19: 'OBJECT-TYPE' 'SYNTAX' (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type ) ( 'UNITS' C_STRING )? ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )? ( 'PIB-REFERENCES' L_BRACE value R_BRACE )? ( 'PIB-TAG' L_BRACE value R_BRACE )? 'STATUS' objecttype_macro_statustypes (=> 'DESCRIPTION' C_STRING )? ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )? ( 'REFERENCE' C_STRING )? (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )? ( 'INDEX' objecttype_macro_index )? ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )? (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal267=(IToken)Match(input,166,FOLLOW_166_in_objecttype_macro3965); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal267_tree = (CommonTree)adaptor.Create(string_literal267);
            		adaptor.AddChild(root_0, string_literal267_tree);
            	}
            	string_literal268=(IToken)Match(input,187,FOLLOW_187_in_objecttype_macro3967); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal268_tree = (CommonTree)adaptor.Create(string_literal268);
            		adaptor.AddChild(root_0, string_literal268_tree);
            	}
            	// Smi.g:806:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )
            	int alt67 = 3;
            	alt67 = dfa67.Predict(input);
            	switch (alt67) 
            	{
            	    case 1 :
            	        // Smi.g:806:23: => smi_type objecttype_macro_namedbits
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro4000);
            	        	smi_type269 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type269.Tree);
            	        	PushFollow(FOLLOW_objecttype_macro_namedbits_in_objecttype_macro4002);
            	        	objecttype_macro_namedbits270 = objecttype_macro_namedbits();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_namedbits270.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:807:24: => smi_type ( smi_subtyping )?
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_objecttype_macro4034);
            	        	smi_type271 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type271.Tree);
            	        	// Smi.g:807:47: ( smi_subtyping )?
            	        	int alt66 = 2;
            	        	int LA66_0 = input.LA(1);

            	        	if ( (LA66_0 == L_PAREN) )
            	        	{
            	        	    alt66 = 1;
            	        	}
            	        	switch (alt66) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:807:48: smi_subtyping
            	        	        {
            	        	        	PushFollow(FOLLOW_smi_subtyping_in_objecttype_macro4037);
            	        	        	smi_subtyping272 = smi_subtyping();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping272.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:808:24: type
            	        {
            	        	PushFollow(FOLLOW_type_in_objecttype_macro4064);
            	        	type273 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type273.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:810:19: ( 'UNITS' C_STRING )?
            	int alt68 = 2;
            	int LA68_0 = input.LA(1);

            	if ( (LA68_0 == 194) )
            	{
            	    alt68 = 1;
            	}
            	switch (alt68) 
            	{
            	    case 1 :
            	        // Smi.g:810:20: 'UNITS' C_STRING
            	        {
            	        	string_literal274=(IToken)Match(input,194,FOLLOW_194_in_objecttype_macro4108); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal274_tree = (CommonTree)adaptor.Create(string_literal274);
            	        		adaptor.AddChild(root_0, string_literal274_tree);
            	        	}
            	        	C_STRING275=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4110); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING275_tree = (CommonTree)adaptor.Create(C_STRING275);
            	        		adaptor.AddChild(root_0, C_STRING275_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:811:19: ( ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes | 'PIB-ACCESS' objecttype_macro_pibaccess )?
            	int alt69 = 3;
            	int LA69_0 = input.LA(1);

            	if ( (LA69_0 == 130 || LA69_0 == 155) )
            	{
            	    alt69 = 1;
            	}
            	else if ( (LA69_0 == 168) )
            	{
            	    alt69 = 2;
            	}
            	switch (alt69) 
            	{
            	    case 1 :
            	        // Smi.g:811:21: ( 'MAX-ACCESS' | 'ACCESS' ) objecttype_macro_accesstypes
            	        {
            	        	set276 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == 130 || input.LA(1) == 155 ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set276));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}

            	        	PushFollow(FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4143);
            	        	objecttype_macro_accesstypes277 = objecttype_macro_accesstypes();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_accesstypes277.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:812:22: 'PIB-ACCESS' objecttype_macro_pibaccess
            	        {
            	        	string_literal278=(IToken)Match(input,168,FOLLOW_168_in_objecttype_macro4167); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal278_tree = (CommonTree)adaptor.Create(string_literal278);
            	        		adaptor.AddChild(root_0, string_literal278_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4169);
            	        	objecttype_macro_pibaccess279 = objecttype_macro_pibaccess();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_pibaccess279.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:813:19: ( 'PIB-REFERENCES' L_BRACE value R_BRACE )?
            	int alt70 = 2;
            	int LA70_0 = input.LA(1);

            	if ( (LA70_0 == 172) )
            	{
            	    alt70 = 1;
            	}
            	switch (alt70) 
            	{
            	    case 1 :
            	        // Smi.g:813:20: 'PIB-REFERENCES' L_BRACE value R_BRACE
            	        {
            	        	string_literal280=(IToken)Match(input,172,FOLLOW_172_in_objecttype_macro4207); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal280_tree = (CommonTree)adaptor.Create(string_literal280);
            	        		adaptor.AddChild(root_0, string_literal280_tree);
            	        	}
            	        	L_BRACE281=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4209); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE281_tree = (CommonTree)adaptor.Create(L_BRACE281);
            	        		adaptor.AddChild(root_0, L_BRACE281_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4211);
            	        	value282 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value282.Tree);
            	        	R_BRACE283=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4213); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE283_tree = (CommonTree)adaptor.Create(R_BRACE283);
            	        		adaptor.AddChild(root_0, R_BRACE283_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:814:19: ( 'PIB-TAG' L_BRACE value R_BRACE )?
            	int alt71 = 2;
            	int LA71_0 = input.LA(1);

            	if ( (LA71_0 == 173) )
            	{
            	    alt71 = 1;
            	}
            	switch (alt71) 
            	{
            	    case 1 :
            	        // Smi.g:814:20: 'PIB-TAG' L_BRACE value R_BRACE
            	        {
            	        	string_literal284=(IToken)Match(input,173,FOLLOW_173_in_objecttype_macro4254); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal284_tree = (CommonTree)adaptor.Create(string_literal284);
            	        		adaptor.AddChild(root_0, string_literal284_tree);
            	        	}
            	        	L_BRACE285=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4256); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE285_tree = (CommonTree)adaptor.Create(L_BRACE285);
            	        		adaptor.AddChild(root_0, L_BRACE285_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4258);
            	        	value286 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value286.Tree);
            	        	R_BRACE287=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4260); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE287_tree = (CommonTree)adaptor.Create(R_BRACE287);
            	        		adaptor.AddChild(root_0, R_BRACE287_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal288=(IToken)Match(input,184,FOLLOW_184_in_objecttype_macro4307); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal288_tree = (CommonTree)adaptor.Create(string_literal288);
            		adaptor.AddChild(root_0, string_literal288_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4309);
            	objecttype_macro_statustypes289 = objecttype_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_statustypes289.Tree);
            	// Smi.g:816:19: (=> 'DESCRIPTION' C_STRING )?
            	int alt72 = 2;
            	int LA72_0 = input.LA(1);

            	if ( (LA72_0 == 141) )
            	{
            	    int LA72_1 = input.LA(2);

            	    if ( (LA72_1 == C_STRING) )
            	    {
            	        int LA72_3 = input.LA(3);

            	        if ( (synpred27_Smi()) )
            	        {
            	            alt72 = 1;
            	        }
            	    }
            	}
            	switch (alt72) 
            	{
            	    case 1 :
            	        // Smi.g:816:21: => 'DESCRIPTION' C_STRING
            	        {

            	        	string_literal290=(IToken)Match(input,141,FOLLOW_141_in_objecttype_macro4338); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal290_tree = (CommonTree)adaptor.Create(string_literal290);
            	        		adaptor.AddChild(root_0, string_literal290_tree);
            	        	}
            	        	C_STRING291=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4340); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING291_tree = (CommonTree)adaptor.Create(C_STRING291);
            	        		adaptor.AddChild(root_0, C_STRING291_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:817:19: ( 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE )?
            	int alt74 = 2;
            	int LA74_0 = input.LA(1);

            	if ( (LA74_0 == 151) )
            	{
            	    alt74 = 1;
            	}
            	switch (alt74) 
            	{
            	    case 1 :
            	        // Smi.g:817:20: 'INSTALL-ERRORS' L_BRACE objecttype_macro_error ( COMMA objecttype_macro_error )* R_BRACE
            	        {
            	        	string_literal292=(IToken)Match(input,151,FOLLOW_151_in_objecttype_macro4396); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal292_tree = (CommonTree)adaptor.Create(string_literal292);
            	        		adaptor.AddChild(root_0, string_literal292_tree);
            	        	}
            	        	L_BRACE293=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4398); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE293_tree = (CommonTree)adaptor.Create(L_BRACE293);
            	        		adaptor.AddChild(root_0, L_BRACE293_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4400);
            	        	objecttype_macro_error294 = objecttype_macro_error();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error294.Tree);
            	        	// Smi.g:817:68: ( COMMA objecttype_macro_error )*
            	        	do 
            	        	{
            	        	    int alt73 = 2;
            	        	    int LA73_0 = input.LA(1);

            	        	    if ( (LA73_0 == COMMA) )
            	        	    {
            	        	        alt73 = 1;
            	        	    }


            	        	    switch (alt73) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:817:69: COMMA objecttype_macro_error
            	        			    {
            	        			    	COMMA295=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4403); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA295_tree = (CommonTree)adaptor.Create(COMMA295);
            	        			    		adaptor.AddChild(root_0, COMMA295_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_objecttype_macro_error_in_objecttype_macro4405);
            	        			    	objecttype_macro_error296 = objecttype_macro_error();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_error296.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop73;
            	        	    }
            	        	} while (true);

            	        	loop73:
            	        		;	// Stops C# compiler whining that label 'loop73' has no statements

            	        	R_BRACE297=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4409); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE297_tree = (CommonTree)adaptor.Create(R_BRACE297);
            	        		adaptor.AddChild(root_0, R_BRACE297_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:818:5: ( 'REFERENCE' C_STRING )?
            	int alt75 = 2;
            	int LA75_0 = input.LA(1);

            	if ( (LA75_0 == 177) )
            	{
            	    alt75 = 1;
            	}
            	switch (alt75) 
            	{
            	    case 1 :
            	        // Smi.g:818:7: 'REFERENCE' C_STRING
            	        {
            	        	string_literal298=(IToken)Match(input,177,FOLLOW_177_in_objecttype_macro4424); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal298_tree = (CommonTree)adaptor.Create(string_literal298);
            	        		adaptor.AddChild(root_0, string_literal298_tree);
            	        	}
            	        	C_STRING299=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objecttype_macro4426); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING299_tree = (CommonTree)adaptor.Create(C_STRING299);
            	        		adaptor.AddChild(root_0, C_STRING299_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:819:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?
            	int alt76 = 5;
            	alt76 = dfa76.Predict(input);
            	switch (alt76) 
            	{
            	    case 1 :
            	        // Smi.g:819:7: => 'INDEX' objecttype_macro_index
            	        {

            	        	string_literal300=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4447); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal300_tree = (CommonTree)adaptor.Create(string_literal300);
            	        		adaptor.AddChild(root_0, string_literal300_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4449);
            	        	objecttype_macro_index301 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index301.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:820:23: 'AUGMENTS' objecttype_macro_augments
            	        {
            	        	string_literal302=(IToken)Match(input,135,FOLLOW_135_in_objecttype_macro4474); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal302_tree = (CommonTree)adaptor.Create(string_literal302);
            	        		adaptor.AddChild(root_0, string_literal302_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_augments_in_objecttype_macro4476);
            	        	objecttype_macro_augments303 = objecttype_macro_augments();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_augments303.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:821:23: 'PIB-INDEX' L_BRACE value R_BRACE
            	        {
            	        	string_literal304=(IToken)Match(input,170,FOLLOW_170_in_objecttype_macro4501); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal304_tree = (CommonTree)adaptor.Create(string_literal304);
            	        		adaptor.AddChild(root_0, string_literal304_tree);
            	        	}
            	        	L_BRACE305=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4503); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE305_tree = (CommonTree)adaptor.Create(L_BRACE305);
            	        		adaptor.AddChild(root_0, L_BRACE305_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4505);
            	        	value306 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value306.Tree);
            	        	R_BRACE307=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4507); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE307_tree = (CommonTree)adaptor.Create(R_BRACE307);
            	        		adaptor.AddChild(root_0, R_BRACE307_tree);
            	        	}

            	        }
            	        break;
            	    case 4 :
            	        // Smi.g:822:23: 'EXTENDS' L_BRACE value R_BRACE
            	        {
            	        	string_literal308=(IToken)Match(input,145,FOLLOW_145_in_objecttype_macro4553); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal308_tree = (CommonTree)adaptor.Create(string_literal308);
            	        		adaptor.AddChild(root_0, string_literal308_tree);
            	        	}
            	        	L_BRACE309=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4555); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE309_tree = (CommonTree)adaptor.Create(L_BRACE309);
            	        		adaptor.AddChild(root_0, L_BRACE309_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_objecttype_macro4557);
            	        	value310 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value310.Tree);
            	        	R_BRACE311=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4559); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE311_tree = (CommonTree)adaptor.Create(R_BRACE311);
            	        		adaptor.AddChild(root_0, R_BRACE311_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:824:19: ( 'INDEX' objecttype_macro_index )?
            	int alt77 = 2;
            	int LA77_0 = input.LA(1);

            	if ( (LA77_0 == 150) )
            	{
            	    alt77 = 1;
            	}
            	switch (alt77) 
            	{
            	    case 1 :
            	        // Smi.g:824:21: 'INDEX' objecttype_macro_index
            	        {
            	        	string_literal312=(IToken)Match(input,150,FOLLOW_150_in_objecttype_macro4627); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal312_tree = (CommonTree)adaptor.Create(string_literal312);
            	        		adaptor.AddChild(root_0, string_literal312_tree);
            	        	}
            	        	PushFollow(FOLLOW_objecttype_macro_index_in_objecttype_macro4629);
            	        	objecttype_macro_index313 = objecttype_macro_index();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_index313.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:825:19: ( 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE )?
            	int alt80 = 2;
            	int LA80_0 = input.LA(1);

            	if ( (LA80_0 == 193) )
            	{
            	    alt80 = 1;
            	}
            	switch (alt80) 
            	{
            	    case 1 :
            	        // Smi.g:825:21: 'UNIQUENESS' L_BRACE ( value ( COMMA value )* )? R_BRACE
            	        {
            	        	string_literal314=(IToken)Match(input,193,FOLLOW_193_in_objecttype_macro4678); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal314_tree = (CommonTree)adaptor.Create(string_literal314);
            	        		adaptor.AddChild(root_0, string_literal314_tree);
            	        	}
            	        	L_BRACE315=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4680); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE315_tree = (CommonTree)adaptor.Create(L_BRACE315);
            	        		adaptor.AddChild(root_0, L_BRACE315_tree);
            	        	}
            	        	// Smi.g:825:42: ( value ( COMMA value )* )?
            	        	int alt79 = 2;
            	        	int LA79_0 = input.LA(1);

            	        	if ( (LA79_0 == B_STRING || LA79_0 == C_STRING || LA79_0 == FALSE_KW || LA79_0 == H_STRING || LA79_0 == L_BRACE || LA79_0 == LOWER || (LA79_0 >= MINUS && LA79_0 <= NUMBER) || LA79_0 == PLUS_INFINITY_KW || LA79_0 == TRUE_KW || LA79_0 == UPPER) )
            	        	{
            	        	    alt79 = 1;
            	        	}
            	        	switch (alt79) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:825:43: value ( COMMA value )*
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4683);
            	        	        	value316 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value316.Tree);
            	        	        	// Smi.g:825:49: ( COMMA value )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt78 = 2;
            	        	        	    int LA78_0 = input.LA(1);

            	        	        	    if ( (LA78_0 == COMMA) )
            	        	        	    {
            	        	        	        alt78 = 1;
            	        	        	    }


            	        	        	    switch (alt78) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:825:50: COMMA value
            	        	        			    {
            	        	        			    	COMMA317=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro4686); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA317_tree = (CommonTree)adaptor.Create(COMMA317);
            	        	        			    		adaptor.AddChild(root_0, COMMA317_tree);
            	        	        			    	}
            	        	        			    	PushFollow(FOLLOW_value_in_objecttype_macro4688);
            	        	        			    	value318 = value();
            	        	        			    	state.followingStackPointer--;
            	        	        			    	if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value318.Tree);

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop78;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop78:
            	        	        		;	// Stops C# compiler whining that label 'loop78' has no statements


            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE319=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4695); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE319_tree = (CommonTree)adaptor.Create(R_BRACE319);
            	        		adaptor.AddChild(root_0, R_BRACE319_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:826:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?
            	int alt82 = 2;
            	alt82 = dfa82.Predict(input);
            	switch (alt82) 
            	{
            	    case 1 :
            	        // Smi.g:826:7: => 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE
            	        {

            	        	string_literal320=(IToken)Match(input,140,FOLLOW_140_in_objecttype_macro4734); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal320_tree = (CommonTree)adaptor.Create(string_literal320);
            	        		adaptor.AddChild(root_0, string_literal320_tree);
            	        	}
            	        	L_BRACE321=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro4736); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE321_tree = (CommonTree)adaptor.Create(L_BRACE321);
            	        		adaptor.AddChild(root_0, L_BRACE321_tree);
            	        	}
            	        	// Smi.g:827:21: (=> objecttype_macro_bitsvalue | value )
            	        	int alt81 = 2;
            	        	alt81 = dfa81.Predict(input);
            	        	switch (alt81) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:827:23: => objecttype_macro_bitsvalue
            	        	        {

            	        	        	PushFollow(FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4777);
            	        	        	objecttype_macro_bitsvalue322 = objecttype_macro_bitsvalue();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_bitsvalue322.Tree);

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:828:26: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_objecttype_macro4804);
            	        	        	value323 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value323.Tree);

            	        	        }
            	        	        break;

            	        	}

            	        	R_BRACE324=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro4828); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE324_tree = (CommonTree)adaptor.Create(R_BRACE324);
            	        		adaptor.AddChild(root_0, R_BRACE324_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro"

    public class objecttype_macro_accesstypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_accesstypes"
    // Smi.g:830:0: protected objecttype_macro_accesstypes : l= LOWER ;
    public SmiParser.objecttype_macro_accesstypes_return objecttype_macro_accesstypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_accesstypes_return retval = new SmiParser.objecttype_macro_accesstypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:830:41: (l= LOWER )
            // Smi.g:830:41: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_accesstypes4842); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("read-only") || l.Text == ("read-write") 
            	                                              || l.Text == ("write-only") || l.Text == ("read-create") 
            	                                              || l.Text == ("not-accessible") || l.Text == ("accessible-for-notify"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_accesstypes"

    public class objecttype_macro_pibaccess_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_pibaccess"
    // Smi.g:835:0: protected objecttype_macro_pibaccess : l= LOWER ;
    public SmiParser.objecttype_macro_pibaccess_return objecttype_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_pibaccess_return retval = new SmiParser.objecttype_macro_pibaccess_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:835:39: (l= LOWER )
            // Smi.g:835:39: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_pibaccess4895); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("install") 
            	                                              || l.Text == ("notify") 
            	                                              || l.Text == ("install-notify") 
            	                                              || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_pibaccess"

    public class objecttype_macro_statustypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_statustypes"
    // Smi.g:841:0: protected objecttype_macro_statustypes : l= LOWER ;
    public SmiParser.objecttype_macro_statustypes_return objecttype_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_statustypes_return retval = new SmiParser.objecttype_macro_statustypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:841:41: (l= LOWER )
            // Smi.g:841:41: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_statustypes4948); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("mandatory") 
            	                                              || l.Text == ("optional") 
            	                                              || l.Text == ("obsolete") 
            	                                              || l.Text == ("current") 
            	                                              || l.Text == ("deprecated"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_statustypes"

    public class objecttype_macro_index_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_index"
    // Smi.g:850:0: objecttype_macro_index : L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE ;
    public SmiParser.objecttype_macro_index_return objecttype_macro_index() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_index_return retval = new SmiParser.objecttype_macro_index_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE325 = null;
        IToken COMMA327 = null;
        IToken R_BRACE329 = null;
        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype326 = default(SmiParser.objecttype_macro_indextype_return);

        SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype328 = default(SmiParser.objecttype_macro_indextype_return);


        CommonTree L_BRACE325_tree=null;
        CommonTree COMMA327_tree=null;
        CommonTree R_BRACE329_tree=null;

        try 
    	{
            // Smi.g:850:25: ( L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE )
            // Smi.g:850:25: L_BRACE objecttype_macro_indextype ( COMMA objecttype_macro_indextype )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE325=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_index4998); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE325_tree = (CommonTree)adaptor.Create(L_BRACE325);
            		adaptor.AddChild(root_0, L_BRACE325_tree);
            	}
            	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5000);
            	objecttype_macro_indextype326 = objecttype_macro_indextype();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype326.Tree);
            	// Smi.g:850:60: ( COMMA objecttype_macro_indextype )*
            	do 
            	{
            	    int alt83 = 2;
            	    int LA83_0 = input.LA(1);

            	    if ( (LA83_0 == COMMA) )
            	    {
            	        alt83 = 1;
            	    }


            	    switch (alt83) 
            		{
            			case 1 :
            			    // Smi.g:850:61: COMMA objecttype_macro_indextype
            			    {
            			    	COMMA327=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_index5003); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA327_tree = (CommonTree)adaptor.Create(COMMA327);
            			    		adaptor.AddChild(root_0, COMMA327_tree);
            			    	}
            			    	PushFollow(FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5005);
            			    	objecttype_macro_indextype328 = objecttype_macro_indextype();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objecttype_macro_indextype328.Tree);

            			    }
            			    break;

            			default:
            			    goto loop83;
            	    }
            	} while (true);

            	loop83:
            		;	// Stops C# compiler whining that label 'loop83' has no statements

            	R_BRACE329=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_index5009); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE329_tree = (CommonTree)adaptor.Create(R_BRACE329);
            		adaptor.AddChild(root_0, R_BRACE329_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_index"

    public class objecttype_macro_indextype_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_indextype"
    // Smi.g:851:0: objecttype_macro_indextype : ( 'IMPLIED' )? value ;
    public SmiParser.objecttype_macro_indextype_return objecttype_macro_indextype() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_indextype_return retval = new SmiParser.objecttype_macro_indextype_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal330 = null;
        SmiParser.value_return value331 = default(SmiParser.value_return);


        CommonTree string_literal330_tree=null;

        try 
    	{
            // Smi.g:851:29: ( ( 'IMPLIED' )? value )
            // Smi.g:851:29: ( 'IMPLIED' )? value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:851:29: ( 'IMPLIED' )?
            	int alt84 = 2;
            	int LA84_0 = input.LA(1);

            	if ( (LA84_0 == IMPLIED_KW) )
            	{
            	    alt84 = 1;
            	}
            	switch (alt84) 
            	{
            	    case 1 :
            	        // Smi.g:851:30: 'IMPLIED'
            	        {
            	        	string_literal330=(IToken)Match(input,IMPLIED_KW,FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype5023); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal330_tree = (CommonTree)adaptor.Create(string_literal330);
            	        		adaptor.AddChild(root_0, string_literal330_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_objecttype_macro_indextype5027);
            	value331 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value331.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_indextype"

    public class objecttype_macro_augments_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_augments"
    // Smi.g:852:0: objecttype_macro_augments : L_BRACE value R_BRACE ;
    public SmiParser.objecttype_macro_augments_return objecttype_macro_augments() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_augments_return retval = new SmiParser.objecttype_macro_augments_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE332 = null;
        IToken R_BRACE334 = null;
        SmiParser.value_return value333 = default(SmiParser.value_return);


        CommonTree L_BRACE332_tree=null;
        CommonTree R_BRACE334_tree=null;

        try 
    	{
            // Smi.g:852:28: ( L_BRACE value R_BRACE )
            // Smi.g:852:28: L_BRACE value R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE332=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_augments5033); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE332_tree = (CommonTree)adaptor.Create(L_BRACE332);
            		adaptor.AddChild(root_0, L_BRACE332_tree);
            	}
            	PushFollow(FOLLOW_value_in_objecttype_macro_augments5035);
            	value333 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value333.Tree);
            	R_BRACE334=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_augments5037); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE334_tree = (CommonTree)adaptor.Create(R_BRACE334);
            		adaptor.AddChild(root_0, R_BRACE334_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_augments"

    public class objecttype_macro_namedbits_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_namedbits"
    // Smi.g:854:0: objecttype_macro_namedbits : L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE ;
    public SmiParser.objecttype_macro_namedbits_return objecttype_macro_namedbits() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_namedbits_return retval = new SmiParser.objecttype_macro_namedbits_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE335 = null;
        IToken LOWER336 = null;
        IToken L_PAREN337 = null;
        IToken NUMBER338 = null;
        IToken R_PAREN339 = null;
        IToken COMMA340 = null;
        IToken LOWER341 = null;
        IToken L_PAREN342 = null;
        IToken NUMBER343 = null;
        IToken R_PAREN344 = null;
        IToken R_BRACE345 = null;

        CommonTree L_BRACE335_tree=null;
        CommonTree LOWER336_tree=null;
        CommonTree L_PAREN337_tree=null;
        CommonTree NUMBER338_tree=null;
        CommonTree R_PAREN339_tree=null;
        CommonTree COMMA340_tree=null;
        CommonTree LOWER341_tree=null;
        CommonTree L_PAREN342_tree=null;
        CommonTree NUMBER343_tree=null;
        CommonTree R_PAREN344_tree=null;
        CommonTree R_BRACE345_tree=null;

        try 
    	{
            // Smi.g:854:29: ( L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE )
            // Smi.g:854:29: L_BRACE ( LOWER ) L_PAREN NUMBER R_PAREN ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE335=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_namedbits5047); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE335_tree = (CommonTree)adaptor.Create(L_BRACE335);
            		adaptor.AddChild(root_0, L_BRACE335_tree);
            	}
            	// Smi.g:854:37: ( LOWER )
            	// Smi.g:854:38: LOWER
            	{
            		LOWER336=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5050); if (state.failed) return retval;
            		if ( state.backtracking == 0 )
            		{LOWER336_tree = (CommonTree)adaptor.Create(LOWER336);
            			adaptor.AddChild(root_0, LOWER336_tree);
            		}

            	}

            	L_PAREN337=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5053); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN337_tree = (CommonTree)adaptor.Create(L_PAREN337);
            		adaptor.AddChild(root_0, L_PAREN337_tree);
            	}
            	NUMBER338=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5055); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER338_tree = (CommonTree)adaptor.Create(NUMBER338);
            		adaptor.AddChild(root_0, NUMBER338_tree);
            	}
            	R_PAREN339=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5057); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN339_tree = (CommonTree)adaptor.Create(R_PAREN339);
            		adaptor.AddChild(root_0, R_PAREN339_tree);
            	}
            	// Smi.g:854:68: ( COMMA ( LOWER ) L_PAREN NUMBER R_PAREN )*
            	do 
            	{
            	    int alt85 = 2;
            	    int LA85_0 = input.LA(1);

            	    if ( (LA85_0 == COMMA) )
            	    {
            	        alt85 = 1;
            	    }


            	    switch (alt85) 
            		{
            			case 1 :
            			    // Smi.g:854:69: COMMA ( LOWER ) L_PAREN NUMBER R_PAREN
            			    {
            			    	COMMA340=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_namedbits5060); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA340_tree = (CommonTree)adaptor.Create(COMMA340);
            			    		adaptor.AddChild(root_0, COMMA340_tree);
            			    	}
            			    	// Smi.g:854:75: ( LOWER )
            			    	// Smi.g:854:76: LOWER
            			    	{
            			    		LOWER341=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_namedbits5063); if (state.failed) return retval;
            			    		if ( state.backtracking == 0 )
            			    		{LOWER341_tree = (CommonTree)adaptor.Create(LOWER341);
            			    			adaptor.AddChild(root_0, LOWER341_tree);
            			    		}

            			    	}

            			    	L_PAREN342=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_namedbits5066); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{L_PAREN342_tree = (CommonTree)adaptor.Create(L_PAREN342);
            			    		adaptor.AddChild(root_0, L_PAREN342_tree);
            			    	}
            			    	NUMBER343=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_namedbits5068); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{NUMBER343_tree = (CommonTree)adaptor.Create(NUMBER343);
            			    		adaptor.AddChild(root_0, NUMBER343_tree);
            			    	}
            			    	R_PAREN344=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_namedbits5070); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{R_PAREN344_tree = (CommonTree)adaptor.Create(R_PAREN344);
            			    		adaptor.AddChild(root_0, R_PAREN344_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop85;
            	    }
            	} while (true);

            	loop85:
            		;	// Stops C# compiler whining that label 'loop85' has no statements

            	R_BRACE345=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_namedbits5074); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE345_tree = (CommonTree)adaptor.Create(R_BRACE345);
            		adaptor.AddChild(root_0, R_BRACE345_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_namedbits"

    public class objecttype_macro_bitsvalue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_bitsvalue"
    // Smi.g:855:0: objecttype_macro_bitsvalue : L_BRACE LOWER ( COMMA LOWER )* R_BRACE ;
    public SmiParser.objecttype_macro_bitsvalue_return objecttype_macro_bitsvalue() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_bitsvalue_return retval = new SmiParser.objecttype_macro_bitsvalue_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE346 = null;
        IToken LOWER347 = null;
        IToken COMMA348 = null;
        IToken LOWER349 = null;
        IToken R_BRACE350 = null;

        CommonTree L_BRACE346_tree=null;
        CommonTree LOWER347_tree=null;
        CommonTree COMMA348_tree=null;
        CommonTree LOWER349_tree=null;
        CommonTree R_BRACE350_tree=null;

        try 
    	{
            // Smi.g:855:29: ( L_BRACE LOWER ( COMMA LOWER )* R_BRACE )
            // Smi.g:855:29: L_BRACE LOWER ( COMMA LOWER )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE346=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5085); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE346_tree = (CommonTree)adaptor.Create(L_BRACE346);
            		adaptor.AddChild(root_0, L_BRACE346_tree);
            	}
            	LOWER347=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5087); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER347_tree = (CommonTree)adaptor.Create(LOWER347);
            		adaptor.AddChild(root_0, LOWER347_tree);
            	}
            	// Smi.g:855:43: ( COMMA LOWER )*
            	do 
            	{
            	    int alt86 = 2;
            	    int LA86_0 = input.LA(1);

            	    if ( (LA86_0 == COMMA) )
            	    {
            	        alt86 = 1;
            	    }


            	    switch (alt86) 
            		{
            			case 1 :
            			    // Smi.g:855:44: COMMA LOWER
            			    {
            			    	COMMA348=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objecttype_macro_bitsvalue5090); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA348_tree = (CommonTree)adaptor.Create(COMMA348);
            			    		adaptor.AddChild(root_0, COMMA348_tree);
            			    	}
            			    	LOWER349=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_bitsvalue5092); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER349_tree = (CommonTree)adaptor.Create(LOWER349);
            			    		adaptor.AddChild(root_0, LOWER349_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop86;
            	    }
            	} while (true);

            	loop86:
            		;	// Stops C# compiler whining that label 'loop86' has no statements

            	R_BRACE350=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5096); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE350_tree = (CommonTree)adaptor.Create(R_BRACE350);
            		adaptor.AddChild(root_0, R_BRACE350_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_bitsvalue"

    public class objecttype_macro_error_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objecttype_macro_error"
    // Smi.g:856:0: objecttype_macro_error : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.objecttype_macro_error_return objecttype_macro_error() // throws RecognitionException [1]
    {   
        SmiParser.objecttype_macro_error_return retval = new SmiParser.objecttype_macro_error_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER351 = null;
        IToken L_PAREN352 = null;
        IToken NUMBER353 = null;
        IToken R_PAREN354 = null;

        CommonTree LOWER351_tree=null;
        CommonTree L_PAREN352_tree=null;
        CommonTree NUMBER353_tree=null;
        CommonTree R_PAREN354_tree=null;

        try 
    	{
            // Smi.g:856:25: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:856:25: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER351=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objecttype_macro_error5107); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER351_tree = (CommonTree)adaptor.Create(LOWER351);
            		adaptor.AddChild(root_0, LOWER351_tree);
            	}
            	L_PAREN352=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_objecttype_macro_error5109); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN352_tree = (CommonTree)adaptor.Create(L_PAREN352);
            		adaptor.AddChild(root_0, L_PAREN352_tree);
            	}
            	NUMBER353=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_objecttype_macro_error5111); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER353_tree = (CommonTree)adaptor.Create(NUMBER353);
            		adaptor.AddChild(root_0, NUMBER353_tree);
            	}
            	R_PAREN354=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_objecttype_macro_error5113); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN354_tree = (CommonTree)adaptor.Create(R_PAREN354);
            		adaptor.AddChild(root_0, R_PAREN354_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objecttype_macro_error"

    public class moduleidentity_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro"
    // Smi.g:859:0: moduleidentity_macro : 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* ;
    public SmiParser.moduleidentity_macro_return moduleidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_return retval = new SmiParser.moduleidentity_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal355 = null;
        IToken string_literal356 = null;
        IToken L_BRACE357 = null;
        IToken R_BRACE359 = null;
        IToken string_literal360 = null;
        IToken C_STRING361 = null;
        IToken string_literal362 = null;
        IToken C_STRING363 = null;
        IToken string_literal364 = null;
        IToken C_STRING365 = null;
        IToken string_literal366 = null;
        IToken C_STRING367 = null;
        SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories358 = default(SmiParser.moduleidentity_macro_categories_return);

        SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision368 = default(SmiParser.moduleidentity_macro_revision_return);


        CommonTree string_literal355_tree=null;
        CommonTree string_literal356_tree=null;
        CommonTree L_BRACE357_tree=null;
        CommonTree R_BRACE359_tree=null;
        CommonTree string_literal360_tree=null;
        CommonTree C_STRING361_tree=null;
        CommonTree string_literal362_tree=null;
        CommonTree C_STRING363_tree=null;
        CommonTree string_literal364_tree=null;
        CommonTree C_STRING365_tree=null;
        CommonTree string_literal366_tree=null;
        CommonTree C_STRING367_tree=null;

        try 
    	{
            // Smi.g:859:23: ( 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )* )
            // Smi.g:859:23: 'MODULE-IDENTITY' ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )? 'LAST-UPDATED' C_STRING 'ORGANIZATION' C_STRING 'CONTACT-INFO' C_STRING 'DESCRIPTION' C_STRING ( moduleidentity_macro_revision )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal355=(IToken)Match(input,159,FOLLOW_159_in_moduleidentity_macro5122); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal355_tree = (CommonTree)adaptor.Create(string_literal355);
            		adaptor.AddChild(root_0, string_literal355_tree);
            	}
            	// Smi.g:860:25: ( 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE )?
            	int alt87 = 2;
            	int LA87_0 = input.LA(1);

            	if ( (LA87_0 == 185) )
            	{
            	    alt87 = 1;
            	}
            	switch (alt87) 
            	{
            	    case 1 :
            	        // Smi.g:860:26: 'SUBJECT-CATEGORIES' L_BRACE moduleidentity_macro_categories R_BRACE
            	        {
            	        	string_literal356=(IToken)Match(input,185,FOLLOW_185_in_moduleidentity_macro5150); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal356_tree = (CommonTree)adaptor.Create(string_literal356);
            	        		adaptor.AddChild(root_0, string_literal356_tree);
            	        	}
            	        	L_BRACE357=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_moduleidentity_macro5152); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE357_tree = (CommonTree)adaptor.Create(L_BRACE357);
            	        		adaptor.AddChild(root_0, L_BRACE357_tree);
            	        	}
            	        	PushFollow(FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5154);
            	        	moduleidentity_macro_categories358 = moduleidentity_macro_categories();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categories358.Tree);
            	        	R_BRACE359=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_moduleidentity_macro5156); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE359_tree = (CommonTree)adaptor.Create(R_BRACE359);
            	        		adaptor.AddChild(root_0, R_BRACE359_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal360=(IToken)Match(input,152,FOLLOW_152_in_moduleidentity_macro5186); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal360_tree = (CommonTree)adaptor.Create(string_literal360);
            		adaptor.AddChild(root_0, string_literal360_tree);
            	}
            	C_STRING361=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5188); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING361_tree = (CommonTree)adaptor.Create(C_STRING361);
            		adaptor.AddChild(root_0, C_STRING361_tree);
            	}
            	string_literal362=(IToken)Match(input,167,FOLLOW_167_in_moduleidentity_macro5190); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal362_tree = (CommonTree)adaptor.Create(string_literal362);
            		adaptor.AddChild(root_0, string_literal362_tree);
            	}
            	C_STRING363=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5192); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING363_tree = (CommonTree)adaptor.Create(C_STRING363);
            		adaptor.AddChild(root_0, C_STRING363_tree);
            	}
            	string_literal364=(IToken)Match(input,138,FOLLOW_138_in_moduleidentity_macro5194); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal364_tree = (CommonTree)adaptor.Create(string_literal364);
            		adaptor.AddChild(root_0, string_literal364_tree);
            	}
            	C_STRING365=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5196); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING365_tree = (CommonTree)adaptor.Create(C_STRING365);
            		adaptor.AddChild(root_0, C_STRING365_tree);
            	}
            	string_literal366=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro5223); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal366_tree = (CommonTree)adaptor.Create(string_literal366);
            		adaptor.AddChild(root_0, string_literal366_tree);
            	}
            	C_STRING367=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro5225); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING367_tree = (CommonTree)adaptor.Create(C_STRING367);
            		adaptor.AddChild(root_0, C_STRING367_tree);
            	}
            	// Smi.g:862:48: ( moduleidentity_macro_revision )*
            	do 
            	{
            	    int alt88 = 2;
            	    int LA88_0 = input.LA(1);

            	    if ( (LA88_0 == 180) )
            	    {
            	        alt88 = 1;
            	    }


            	    switch (alt88) 
            		{
            			case 1 :
            			    // Smi.g:862:49: moduleidentity_macro_revision
            			    {
            			    	PushFollow(FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5228);
            			    	moduleidentity_macro_revision368 = moduleidentity_macro_revision();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_revision368.Tree);

            			    }
            			    break;

            			default:
            			    goto loop88;
            	    }
            	} while (true);

            	loop88:
            		;	// Stops C# compiler whining that label 'loop88' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro"

    public class moduleidentity_macro_revision_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_revision"
    // Smi.g:863:0: moduleidentity_macro_revision : 'REVISION' C_STRING 'DESCRIPTION' C_STRING ;
    public SmiParser.moduleidentity_macro_revision_return moduleidentity_macro_revision() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_revision_return retval = new SmiParser.moduleidentity_macro_revision_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal369 = null;
        IToken C_STRING370 = null;
        IToken string_literal371 = null;
        IToken C_STRING372 = null;

        CommonTree string_literal369_tree=null;
        CommonTree C_STRING370_tree=null;
        CommonTree string_literal371_tree=null;
        CommonTree C_STRING372_tree=null;

        try 
    	{
            // Smi.g:863:32: ( 'REVISION' C_STRING 'DESCRIPTION' C_STRING )
            // Smi.g:863:32: 'REVISION' C_STRING 'DESCRIPTION' C_STRING
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal369=(IToken)Match(input,180,FOLLOW_180_in_moduleidentity_macro_revision5237); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal369_tree = (CommonTree)adaptor.Create(string_literal369);
            		adaptor.AddChild(root_0, string_literal369_tree);
            	}
            	C_STRING370=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5239); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING370_tree = (CommonTree)adaptor.Create(C_STRING370);
            		adaptor.AddChild(root_0, C_STRING370_tree);
            	}
            	string_literal371=(IToken)Match(input,141,FOLLOW_141_in_moduleidentity_macro_revision5241); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal371_tree = (CommonTree)adaptor.Create(string_literal371);
            		adaptor.AddChild(root_0, string_literal371_tree);
            	}
            	C_STRING372=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_moduleidentity_macro_revision5243); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING372_tree = (CommonTree)adaptor.Create(C_STRING372);
            		adaptor.AddChild(root_0, C_STRING372_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_revision"

    public class moduleidentity_macro_categories_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categories"
    // Smi.g:864:0: moduleidentity_macro_categories : (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* );
    public SmiParser.moduleidentity_macro_categories_return moduleidentity_macro_categories() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categories_return retval = new SmiParser.moduleidentity_macro_categories_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;
        IToken COMMA374 = null;
        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid373 = default(SmiParser.moduleidentity_macro_categoryid_return);

        SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid375 = default(SmiParser.moduleidentity_macro_categoryid_return);


        CommonTree l_tree=null;
        CommonTree COMMA374_tree=null;

        try 
    	{
            // Smi.g:864:34: (l= LOWER | moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )* )
            int alt90 = 2;
            int LA90_0 = input.LA(1);

            if ( (LA90_0 == LOWER) )
            {
                int LA90_1 = input.LA(2);

                if ( (LA90_1 == L_PAREN) )
                {
                    alt90 = 2;
                }
                else if ( (LA90_1 == R_BRACE) )
                {
                    alt90 = 1;
                }
                else 
                {
                    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    NoViableAltException nvae_d90s1 =
                        new NoViableAltException("", 90, 1, input);

                    throw nvae_d90s1;
                }
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d90s0 =
                    new NoViableAltException("", 90, 0, input);

                throw nvae_d90s0;
            }
            switch (alt90) 
            {
                case 1 :
                    // Smi.g:864:34: l= LOWER
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categories5252); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{l_tree = (CommonTree)adaptor.Create(l);
                    		adaptor.AddChild(root_0, l_tree);
                    	}
                    	if ( (state.backtracking==0) )
                    	{
                    	  if (l.Text !=  ("all")) {throw new SemanticException ("(invalid)");}
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:865:34: moduleidentity_macro_categoryid ( COMMA moduleidentity_macro_categoryid )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5290);
                    	moduleidentity_macro_categoryid373 = moduleidentity_macro_categoryid();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid373.Tree);
                    	// Smi.g:865:66: ( COMMA moduleidentity_macro_categoryid )*
                    	do 
                    	{
                    	    int alt89 = 2;
                    	    int LA89_0 = input.LA(1);

                    	    if ( (LA89_0 == COMMA) )
                    	    {
                    	        alt89 = 1;
                    	    }


                    	    switch (alt89) 
                    		{
                    			case 1 :
                    			    // Smi.g:865:67: COMMA moduleidentity_macro_categoryid
                    			    {
                    			    	COMMA374=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_moduleidentity_macro_categories5293); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA374_tree = (CommonTree)adaptor.Create(COMMA374);
                    			    		adaptor.AddChild(root_0, COMMA374_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5295);
                    			    	moduleidentity_macro_categoryid375 = moduleidentity_macro_categoryid();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, moduleidentity_macro_categoryid375.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop89;
                    	    }
                    	} while (true);

                    	loop89:
                    		;	// Stops C# compiler whining that label 'loop89' has no statements


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categories"

    public class moduleidentity_macro_categoryid_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "moduleidentity_macro_categoryid"
    // Smi.g:866:0: moduleidentity_macro_categoryid : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.moduleidentity_macro_categoryid_return moduleidentity_macro_categoryid() // throws RecognitionException [1]
    {   
        SmiParser.moduleidentity_macro_categoryid_return retval = new SmiParser.moduleidentity_macro_categoryid_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER376 = null;
        IToken L_PAREN377 = null;
        IToken NUMBER378 = null;
        IToken R_PAREN379 = null;

        CommonTree LOWER376_tree=null;
        CommonTree L_PAREN377_tree=null;
        CommonTree NUMBER378_tree=null;
        CommonTree R_PAREN379_tree=null;

        try 
    	{
            // Smi.g:866:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:866:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER376=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_moduleidentity_macro_categoryid5303); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER376_tree = (CommonTree)adaptor.Create(LOWER376);
            		adaptor.AddChild(root_0, LOWER376_tree);
            	}
            	L_PAREN377=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5305); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN377_tree = (CommonTree)adaptor.Create(L_PAREN377);
            		adaptor.AddChild(root_0, L_PAREN377_tree);
            	}
            	NUMBER378=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5307); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER378_tree = (CommonTree)adaptor.Create(NUMBER378);
            		adaptor.AddChild(root_0, NUMBER378_tree);
            	}
            	R_PAREN379=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5309); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN379_tree = (CommonTree)adaptor.Create(R_PAREN379);
            		adaptor.AddChild(root_0, R_PAREN379_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "moduleidentity_macro_categoryid"

    public class objectidentity_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectidentity_macro"
    // Smi.g:869:0: objectidentity_macro : 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectidentity_macro_return objectidentity_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_return retval = new SmiParser.objectidentity_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal380 = null;
        IToken string_literal381 = null;
        IToken string_literal383 = null;
        IToken C_STRING384 = null;
        IToken string_literal385 = null;
        IToken C_STRING386 = null;
        SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes382 = default(SmiParser.objectidentity_macro_statustypes_return);


        CommonTree string_literal380_tree=null;
        CommonTree string_literal381_tree=null;
        CommonTree string_literal383_tree=null;
        CommonTree C_STRING384_tree=null;
        CommonTree string_literal385_tree=null;
        CommonTree C_STRING386_tree=null;

        try 
    	{
            // Smi.g:869:23: ( 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:869:23: 'OBJECT-IDENTITY' 'STATUS' objectidentity_macro_statustypes 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal380=(IToken)Match(input,164,FOLLOW_164_in_objectidentity_macro5319); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal380_tree = (CommonTree)adaptor.Create(string_literal380);
            		adaptor.AddChild(root_0, string_literal380_tree);
            	}
            	string_literal381=(IToken)Match(input,184,FOLLOW_184_in_objectidentity_macro5321); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal381_tree = (CommonTree)adaptor.Create(string_literal381);
            		adaptor.AddChild(root_0, string_literal381_tree);
            	}
            	PushFollow(FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5323);
            	objectidentity_macro_statustypes382 = objectidentity_macro_statustypes();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectidentity_macro_statustypes382.Tree);
            	string_literal383=(IToken)Match(input,141,FOLLOW_141_in_objectidentity_macro5325); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal383_tree = (CommonTree)adaptor.Create(string_literal383);
            		adaptor.AddChild(root_0, string_literal383_tree);
            	}
            	C_STRING384=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5327); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING384_tree = (CommonTree)adaptor.Create(C_STRING384);
            		adaptor.AddChild(root_0, C_STRING384_tree);
            	}
            	// Smi.g:869:106: ( 'REFERENCE' C_STRING )?
            	int alt91 = 2;
            	int LA91_0 = input.LA(1);

            	if ( (LA91_0 == 177) )
            	{
            	    alt91 = 1;
            	}
            	switch (alt91) 
            	{
            	    case 1 :
            	        // Smi.g:869:107: 'REFERENCE' C_STRING
            	        {
            	        	string_literal385=(IToken)Match(input,177,FOLLOW_177_in_objectidentity_macro5330); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal385_tree = (CommonTree)adaptor.Create(string_literal385);
            	        		adaptor.AddChild(root_0, string_literal385_tree);
            	        	}
            	        	C_STRING386=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectidentity_macro5332); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING386_tree = (CommonTree)adaptor.Create(C_STRING386);
            	        		adaptor.AddChild(root_0, C_STRING386_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro"

    public class objectidentity_macro_statustypes_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectidentity_macro_statustypes"
    // Smi.g:870:0: protected objectidentity_macro_statustypes : l= LOWER ;
    public SmiParser.objectidentity_macro_statustypes_return objectidentity_macro_statustypes() // throws RecognitionException [1]
    {   
        SmiParser.objectidentity_macro_statustypes_return retval = new SmiParser.objectidentity_macro_statustypes_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:870:45: (l= LOWER )
            // Smi.g:870:45: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectidentity_macro_statustypes5345); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectidentity_macro_statustypes"

    public class notificationtype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationtype_macro"
    // Smi.g:878:0: notificationtype_macro : 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationtype_macro_return notificationtype_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_return retval = new SmiParser.notificationtype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal387 = null;
        IToken string_literal388 = null;
        IToken L_BRACE389 = null;
        IToken COMMA391 = null;
        IToken R_BRACE393 = null;
        IToken string_literal394 = null;
        IToken string_literal396 = null;
        IToken C_STRING397 = null;
        IToken string_literal398 = null;
        IToken C_STRING399 = null;
        SmiParser.value_return value390 = default(SmiParser.value_return);

        SmiParser.value_return value392 = default(SmiParser.value_return);

        SmiParser.notificationtype_macro_status_return notificationtype_macro_status395 = default(SmiParser.notificationtype_macro_status_return);


        CommonTree string_literal387_tree=null;
        CommonTree string_literal388_tree=null;
        CommonTree L_BRACE389_tree=null;
        CommonTree COMMA391_tree=null;
        CommonTree R_BRACE393_tree=null;
        CommonTree string_literal394_tree=null;
        CommonTree string_literal396_tree=null;
        CommonTree C_STRING397_tree=null;
        CommonTree string_literal398_tree=null;
        CommonTree C_STRING399_tree=null;

        try 
    	{
            // Smi.g:878:25: ( 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:878:25: 'NOTIFICATION-TYPE' ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )? 'STATUS' notificationtype_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal387=(IToken)Match(input,162,FOLLOW_162_in_notificationtype_macro5398); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal387_tree = (CommonTree)adaptor.Create(string_literal387);
            		adaptor.AddChild(root_0, string_literal387_tree);
            	}
            	// Smi.g:878:45: ( 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt93 = 2;
            	int LA93_0 = input.LA(1);

            	if ( (LA93_0 == 165) )
            	{
            	    alt93 = 1;
            	}
            	switch (alt93) 
            	{
            	    case 1 :
            	        // Smi.g:878:46: 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal388=(IToken)Match(input,165,FOLLOW_165_in_notificationtype_macro5401); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal388_tree = (CommonTree)adaptor.Create(string_literal388);
            	        		adaptor.AddChild(root_0, string_literal388_tree);
            	        	}
            	        	L_BRACE389=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationtype_macro5403); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE389_tree = (CommonTree)adaptor.Create(L_BRACE389);
            	        		adaptor.AddChild(root_0, L_BRACE389_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_notificationtype_macro5405);
            	        	value390 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value390.Tree);
            	        	// Smi.g:878:70: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt92 = 2;
            	        	    int LA92_0 = input.LA(1);

            	        	    if ( (LA92_0 == COMMA) )
            	        	    {
            	        	        alt92 = 1;
            	        	    }


            	        	    switch (alt92) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:878:71: COMMA value
            	        			    {
            	        			    	COMMA391=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationtype_macro5408); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA391_tree = (CommonTree)adaptor.Create(COMMA391);
            	        			    		adaptor.AddChild(root_0, COMMA391_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_notificationtype_macro5410);
            	        			    	value392 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value392.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop92;
            	        	    }
            	        	} while (true);

            	        	loop92:
            	        		;	// Stops C# compiler whining that label 'loop92' has no statements

            	        	R_BRACE393=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationtype_macro5414); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE393_tree = (CommonTree)adaptor.Create(R_BRACE393);
            	        		adaptor.AddChild(root_0, R_BRACE393_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal394=(IToken)Match(input,184,FOLLOW_184_in_notificationtype_macro5463); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal394_tree = (CommonTree)adaptor.Create(string_literal394);
            		adaptor.AddChild(root_0, string_literal394_tree);
            	}
            	PushFollow(FOLLOW_notificationtype_macro_status_in_notificationtype_macro5465);
            	notificationtype_macro_status395 = notificationtype_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationtype_macro_status395.Tree);
            	string_literal396=(IToken)Match(input,141,FOLLOW_141_in_notificationtype_macro5467); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal396_tree = (CommonTree)adaptor.Create(string_literal396);
            		adaptor.AddChild(root_0, string_literal396_tree);
            	}
            	C_STRING397=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5469); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING397_tree = (CommonTree)adaptor.Create(C_STRING397);
            		adaptor.AddChild(root_0, C_STRING397_tree);
            	}
            	// Smi.g:879:107: ( 'REFERENCE' C_STRING )?
            	int alt94 = 2;
            	int LA94_0 = input.LA(1);

            	if ( (LA94_0 == 177) )
            	{
            	    alt94 = 1;
            	}
            	switch (alt94) 
            	{
            	    case 1 :
            	        // Smi.g:879:108: 'REFERENCE' C_STRING
            	        {
            	        	string_literal398=(IToken)Match(input,177,FOLLOW_177_in_notificationtype_macro5472); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal398_tree = (CommonTree)adaptor.Create(string_literal398);
            	        		adaptor.AddChild(root_0, string_literal398_tree);
            	        	}
            	        	C_STRING399=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationtype_macro5474); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING399_tree = (CommonTree)adaptor.Create(C_STRING399);
            	        		adaptor.AddChild(root_0, C_STRING399_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro"

    public class notificationtype_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationtype_macro_status"
    // Smi.g:880:0: protected notificationtype_macro_status : l= LOWER ;
    public SmiParser.notificationtype_macro_status_return notificationtype_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationtype_macro_status_return retval = new SmiParser.notificationtype_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:880:42: (l= LOWER )
            // Smi.g:880:42: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationtype_macro_status5487); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationtype_macro_status"

    public class textualconvention_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro"
    // Smi.g:887:0: textualconvention_macro : 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) ;
    public SmiParser.textualconvention_macro_return textualconvention_macro() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_return retval = new SmiParser.textualconvention_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal400 = null;
        IToken string_literal401 = null;
        IToken C_STRING402 = null;
        IToken string_literal403 = null;
        IToken string_literal405 = null;
        IToken C_STRING406 = null;
        IToken string_literal407 = null;
        IToken C_STRING408 = null;
        IToken string_literal409 = null;
        IToken L_BRACE411 = null;
        IToken COMMA413 = null;
        IToken R_BRACE415 = null;
        SmiParser.textualconvention_macro_status_return textualconvention_macro_status404 = default(SmiParser.textualconvention_macro_status_return);

        SmiParser.smi_type_return smi_type410 = default(SmiParser.smi_type_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit412 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit414 = default(SmiParser.textualconvention_macro_namedbit_return);

        SmiParser.type_return type416 = default(SmiParser.type_return);


        CommonTree string_literal400_tree=null;
        CommonTree string_literal401_tree=null;
        CommonTree C_STRING402_tree=null;
        CommonTree string_literal403_tree=null;
        CommonTree string_literal405_tree=null;
        CommonTree C_STRING406_tree=null;
        CommonTree string_literal407_tree=null;
        CommonTree C_STRING408_tree=null;
        CommonTree string_literal409_tree=null;
        CommonTree L_BRACE411_tree=null;
        CommonTree COMMA413_tree=null;
        CommonTree R_BRACE415_tree=null;

        try 
    	{
            // Smi.g:887:26: ( 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type ) )
            // Smi.g:887:26: 'TEXTUAL-CONVENTION' ( 'DISPLAY-HINT' C_STRING )? 'STATUS' textualconvention_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? 'SYNTAX' (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal400=(IToken)Match(input,188,FOLLOW_188_in_textualconvention_macro5539); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal400_tree = (CommonTree)adaptor.Create(string_literal400);
            		adaptor.AddChild(root_0, string_literal400_tree);
            	}
            	// Smi.g:887:47: ( 'DISPLAY-HINT' C_STRING )?
            	int alt95 = 2;
            	int LA95_0 = input.LA(1);

            	if ( (LA95_0 == 142) )
            	{
            	    alt95 = 1;
            	}
            	switch (alt95) 
            	{
            	    case 1 :
            	        // Smi.g:887:48: 'DISPLAY-HINT' C_STRING
            	        {
            	        	string_literal401=(IToken)Match(input,142,FOLLOW_142_in_textualconvention_macro5542); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal401_tree = (CommonTree)adaptor.Create(string_literal401);
            	        		adaptor.AddChild(root_0, string_literal401_tree);
            	        	}
            	        	C_STRING402=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5544); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING402_tree = (CommonTree)adaptor.Create(C_STRING402);
            	        		adaptor.AddChild(root_0, C_STRING402_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal403=(IToken)Match(input,184,FOLLOW_184_in_textualconvention_macro5577); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal403_tree = (CommonTree)adaptor.Create(string_literal403);
            		adaptor.AddChild(root_0, string_literal403_tree);
            	}
            	PushFollow(FOLLOW_textualconvention_macro_status_in_textualconvention_macro5579);
            	textualconvention_macro_status404 = textualconvention_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_status404.Tree);
            	string_literal405=(IToken)Match(input,141,FOLLOW_141_in_textualconvention_macro5610); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal405_tree = (CommonTree)adaptor.Create(string_literal405);
            		adaptor.AddChild(root_0, string_literal405_tree);
            	}
            	C_STRING406=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5612); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING406_tree = (CommonTree)adaptor.Create(C_STRING406);
            		adaptor.AddChild(root_0, C_STRING406_tree);
            	}
            	// Smi.g:890:29: ( 'REFERENCE' C_STRING )?
            	int alt96 = 2;
            	int LA96_0 = input.LA(1);

            	if ( (LA96_0 == 177) )
            	{
            	    alt96 = 1;
            	}
            	switch (alt96) 
            	{
            	    case 1 :
            	        // Smi.g:890:30: 'REFERENCE' C_STRING
            	        {
            	        	string_literal407=(IToken)Match(input,177,FOLLOW_177_in_textualconvention_macro5644); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal407_tree = (CommonTree)adaptor.Create(string_literal407);
            	        		adaptor.AddChild(root_0, string_literal407_tree);
            	        	}
            	        	C_STRING408=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_textualconvention_macro5646); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING408_tree = (CommonTree)adaptor.Create(C_STRING408);
            	        		adaptor.AddChild(root_0, C_STRING408_tree);
            	        	}

            	        }
            	        break;

            	}

            	string_literal409=(IToken)Match(input,187,FOLLOW_187_in_textualconvention_macro5679); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal409_tree = (CommonTree)adaptor.Create(string_literal409);
            		adaptor.AddChild(root_0, string_literal409_tree);
            	}
            	// Smi.g:891:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )
            	int alt98 = 2;
            	alt98 = dfa98.Predict(input);
            	switch (alt98) 
            	{
            	    case 1 :
            	        // Smi.g:891:40: => smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE
            	        {

            	        	PushFollow(FOLLOW_smi_type_in_textualconvention_macro5691);
            	        	smi_type410 = smi_type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type410.Tree);
            	        	L_BRACE411=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_textualconvention_macro5693); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE411_tree = (CommonTree)adaptor.Create(L_BRACE411);
            	        		adaptor.AddChild(root_0, L_BRACE411_tree);
            	        	}
            	        	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5695);
            	        	textualconvention_macro_namedbit412 = textualconvention_macro_namedbit();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit412.Tree);
            	        	// Smi.g:892:37: ( COMMA textualconvention_macro_namedbit )*
            	        	do 
            	        	{
            	        	    int alt97 = 2;
            	        	    int LA97_0 = input.LA(1);

            	        	    if ( (LA97_0 == COMMA) )
            	        	    {
            	        	        alt97 = 1;
            	        	    }


            	        	    switch (alt97) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:892:38: COMMA textualconvention_macro_namedbit
            	        			    {
            	        			    	COMMA413=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_textualconvention_macro5735); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA413_tree = (CommonTree)adaptor.Create(COMMA413);
            	        			    		adaptor.AddChild(root_0, COMMA413_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5737);
            	        			    	textualconvention_macro_namedbit414 = textualconvention_macro_namedbit();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, textualconvention_macro_namedbit414.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop97;
            	        	    }
            	        	} while (true);

            	        	loop97:
            	        		;	// Stops C# compiler whining that label 'loop97' has no statements

            	        	R_BRACE415=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_textualconvention_macro5741); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE415_tree = (CommonTree)adaptor.Create(R_BRACE415);
            	        		adaptor.AddChild(root_0, R_BRACE415_tree);
            	        	}

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:892:89: type
            	        {
            	        	PushFollow(FOLLOW_type_in_textualconvention_macro5745);
            	        	type416 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type416.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro"

    public class textualconvention_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_status"
    // Smi.g:893:0: fragment textualconvention_macro_status : l= LOWER ;
    public SmiParser.textualconvention_macro_status_return textualconvention_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_status_return retval = new SmiParser.textualconvention_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:893:42: (l= LOWER )
            // Smi.g:893:42: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_status5756); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_status"

    public class textualconvention_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "textualconvention_macro_namedbit"
    // Smi.g:898:0: textualconvention_macro_namedbit : LOWER L_PAREN ( MINUS )? NUMBER R_PAREN ;
    public SmiParser.textualconvention_macro_namedbit_return textualconvention_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.textualconvention_macro_namedbit_return retval = new SmiParser.textualconvention_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER417 = null;
        IToken L_PAREN418 = null;
        IToken MINUS419 = null;
        IToken NUMBER420 = null;
        IToken R_PAREN421 = null;

        CommonTree LOWER417_tree=null;
        CommonTree L_PAREN418_tree=null;
        CommonTree MINUS419_tree=null;
        CommonTree NUMBER420_tree=null;
        CommonTree R_PAREN421_tree=null;

        try 
    	{
            // Smi.g:898:35: ( LOWER L_PAREN ( MINUS )? NUMBER R_PAREN )
            // Smi.g:898:35: LOWER L_PAREN ( MINUS )? NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER417=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_textualconvention_macro_namedbit5805); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER417_tree = (CommonTree)adaptor.Create(LOWER417);
            		adaptor.AddChild(root_0, LOWER417_tree);
            	}
            	L_PAREN418=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5807); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN418_tree = (CommonTree)adaptor.Create(L_PAREN418);
            		adaptor.AddChild(root_0, L_PAREN418_tree);
            	}
            	// Smi.g:898:49: ( MINUS )?
            	int alt99 = 2;
            	int LA99_0 = input.LA(1);

            	if ( (LA99_0 == MINUS) )
            	{
            	    alt99 = 1;
            	}
            	switch (alt99) 
            	{
            	    case 1 :
            	        // Smi.g:898:50: MINUS
            	        {
            	        	MINUS419=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_textualconvention_macro_namedbit5810); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS419_tree = (CommonTree)adaptor.Create(MINUS419);
            	        		adaptor.AddChild(root_0, MINUS419_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER420=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_textualconvention_macro_namedbit5814); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER420_tree = (CommonTree)adaptor.Create(NUMBER420);
            		adaptor.AddChild(root_0, NUMBER420_tree);
            	}
            	R_PAREN421=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5816); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN421_tree = (CommonTree)adaptor.Create(R_PAREN421);
            		adaptor.AddChild(root_0, R_PAREN421_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "textualconvention_macro_namedbit"

    public class objectgroup_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectgroup_macro"
    // Smi.g:901:0: objectgroup_macro : 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.objectgroup_macro_return objectgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_return retval = new SmiParser.objectgroup_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal422 = null;
        IToken string_literal423 = null;
        IToken L_BRACE424 = null;
        IToken COMMA426 = null;
        IToken R_BRACE428 = null;
        IToken string_literal429 = null;
        IToken string_literal431 = null;
        IToken C_STRING432 = null;
        IToken string_literal433 = null;
        IToken C_STRING434 = null;
        SmiParser.value_return value425 = default(SmiParser.value_return);

        SmiParser.value_return value427 = default(SmiParser.value_return);

        SmiParser.objectgroup_macro_status_return objectgroup_macro_status430 = default(SmiParser.objectgroup_macro_status_return);


        CommonTree string_literal422_tree=null;
        CommonTree string_literal423_tree=null;
        CommonTree L_BRACE424_tree=null;
        CommonTree COMMA426_tree=null;
        CommonTree R_BRACE428_tree=null;
        CommonTree string_literal429_tree=null;
        CommonTree string_literal431_tree=null;
        CommonTree C_STRING432_tree=null;
        CommonTree string_literal433_tree=null;
        CommonTree C_STRING434_tree=null;

        try 
    	{
            // Smi.g:901:20: ( 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:901:20: 'OBJECT-GROUP' 'OBJECTS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' objectgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal422=(IToken)Match(input,163,FOLLOW_163_in_objectgroup_macro5825); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal422_tree = (CommonTree)adaptor.Create(string_literal422);
            		adaptor.AddChild(root_0, string_literal422_tree);
            	}
            	string_literal423=(IToken)Match(input,165,FOLLOW_165_in_objectgroup_macro5827); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal423_tree = (CommonTree)adaptor.Create(string_literal423);
            		adaptor.AddChild(root_0, string_literal423_tree);
            	}
            	L_BRACE424=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_objectgroup_macro5829); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE424_tree = (CommonTree)adaptor.Create(L_BRACE424);
            		adaptor.AddChild(root_0, L_BRACE424_tree);
            	}
            	PushFollow(FOLLOW_value_in_objectgroup_macro5831);
            	value425 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value425.Tree);
            	// Smi.g:901:59: ( COMMA value )*
            	do 
            	{
            	    int alt100 = 2;
            	    int LA100_0 = input.LA(1);

            	    if ( (LA100_0 == COMMA) )
            	    {
            	        alt100 = 1;
            	    }


            	    switch (alt100) 
            		{
            			case 1 :
            			    // Smi.g:901:60: COMMA value
            			    {
            			    	COMMA426=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_objectgroup_macro5834); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA426_tree = (CommonTree)adaptor.Create(COMMA426);
            			    		adaptor.AddChild(root_0, COMMA426_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_objectgroup_macro5836);
            			    	value427 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value427.Tree);

            			    }
            			    break;

            			default:
            			    goto loop100;
            	    }
            	} while (true);

            	loop100:
            		;	// Stops C# compiler whining that label 'loop100' has no statements

            	R_BRACE428=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_objectgroup_macro5840); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE428_tree = (CommonTree)adaptor.Create(R_BRACE428);
            		adaptor.AddChild(root_0, R_BRACE428_tree);
            	}
            	string_literal429=(IToken)Match(input,184,FOLLOW_184_in_objectgroup_macro5867); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal429_tree = (CommonTree)adaptor.Create(string_literal429);
            		adaptor.AddChild(root_0, string_literal429_tree);
            	}
            	PushFollow(FOLLOW_objectgroup_macro_status_in_objectgroup_macro5869);
            	objectgroup_macro_status430 = objectgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, objectgroup_macro_status430.Tree);
            	string_literal431=(IToken)Match(input,141,FOLLOW_141_in_objectgroup_macro5871); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal431_tree = (CommonTree)adaptor.Create(string_literal431);
            		adaptor.AddChild(root_0, string_literal431_tree);
            	}
            	C_STRING432=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5873); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING432_tree = (CommonTree)adaptor.Create(C_STRING432);
            		adaptor.AddChild(root_0, C_STRING432_tree);
            	}
            	// Smi.g:902:82: ( 'REFERENCE' C_STRING )?
            	int alt101 = 2;
            	int LA101_0 = input.LA(1);

            	if ( (LA101_0 == 177) )
            	{
            	    alt101 = 1;
            	}
            	switch (alt101) 
            	{
            	    case 1 :
            	        // Smi.g:902:83: 'REFERENCE' C_STRING
            	        {
            	        	string_literal433=(IToken)Match(input,177,FOLLOW_177_in_objectgroup_macro5876); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal433_tree = (CommonTree)adaptor.Create(string_literal433);
            	        		adaptor.AddChild(root_0, string_literal433_tree);
            	        	}
            	        	C_STRING434=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_objectgroup_macro5878); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING434_tree = (CommonTree)adaptor.Create(C_STRING434);
            	        		adaptor.AddChild(root_0, C_STRING434_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro"

    public class objectgroup_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "objectgroup_macro_status"
    // Smi.g:903:0: objectgroup_macro_status : l= LOWER ;
    public SmiParser.objectgroup_macro_status_return objectgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.objectgroup_macro_status_return retval = new SmiParser.objectgroup_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:903:27: (l= LOWER )
            // Smi.g:903:27: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_objectgroup_macro_status5889); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "objectgroup_macro_status"

    public class notificationgroup_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro"
    // Smi.g:910:0: notificationgroup_macro : 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ;
    public SmiParser.notificationgroup_macro_return notificationgroup_macro() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_return retval = new SmiParser.notificationgroup_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal435 = null;
        IToken string_literal436 = null;
        IToken L_BRACE437 = null;
        IToken COMMA439 = null;
        IToken R_BRACE441 = null;
        IToken string_literal442 = null;
        IToken string_literal444 = null;
        IToken C_STRING445 = null;
        IToken string_literal446 = null;
        IToken C_STRING447 = null;
        SmiParser.value_return value438 = default(SmiParser.value_return);

        SmiParser.value_return value440 = default(SmiParser.value_return);

        SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status443 = default(SmiParser.notificationgroup_macro_status_return);


        CommonTree string_literal435_tree=null;
        CommonTree string_literal436_tree=null;
        CommonTree L_BRACE437_tree=null;
        CommonTree COMMA439_tree=null;
        CommonTree R_BRACE441_tree=null;
        CommonTree string_literal442_tree=null;
        CommonTree string_literal444_tree=null;
        CommonTree C_STRING445_tree=null;
        CommonTree string_literal446_tree=null;
        CommonTree C_STRING447_tree=null;

        try 
    	{
            // Smi.g:910:26: ( 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? )
            // Smi.g:910:26: 'NOTIFICATION-GROUP' 'NOTIFICATIONS' L_BRACE value ( COMMA value )* R_BRACE 'STATUS' notificationgroup_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal435=(IToken)Match(input,160,FOLLOW_160_in_notificationgroup_macro5941); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal435_tree = (CommonTree)adaptor.Create(string_literal435);
            		adaptor.AddChild(root_0, string_literal435_tree);
            	}
            	string_literal436=(IToken)Match(input,161,FOLLOW_161_in_notificationgroup_macro5943); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal436_tree = (CommonTree)adaptor.Create(string_literal436);
            		adaptor.AddChild(root_0, string_literal436_tree);
            	}
            	L_BRACE437=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_notificationgroup_macro5945); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE437_tree = (CommonTree)adaptor.Create(L_BRACE437);
            		adaptor.AddChild(root_0, L_BRACE437_tree);
            	}
            	PushFollow(FOLLOW_value_in_notificationgroup_macro5947);
            	value438 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value438.Tree);
            	// Smi.g:910:77: ( COMMA value )*
            	do 
            	{
            	    int alt102 = 2;
            	    int LA102_0 = input.LA(1);

            	    if ( (LA102_0 == COMMA) )
            	    {
            	        alt102 = 1;
            	    }


            	    switch (alt102) 
            		{
            			case 1 :
            			    // Smi.g:910:78: COMMA value
            			    {
            			    	COMMA439=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_notificationgroup_macro5950); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA439_tree = (CommonTree)adaptor.Create(COMMA439);
            			    		adaptor.AddChild(root_0, COMMA439_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_notificationgroup_macro5952);
            			    	value440 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value440.Tree);

            			    }
            			    break;

            			default:
            			    goto loop102;
            	    }
            	} while (true);

            	loop102:
            		;	// Stops C# compiler whining that label 'loop102' has no statements

            	R_BRACE441=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_notificationgroup_macro5956); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE441_tree = (CommonTree)adaptor.Create(R_BRACE441);
            		adaptor.AddChild(root_0, R_BRACE441_tree);
            	}
            	string_literal442=(IToken)Match(input,184,FOLLOW_184_in_notificationgroup_macro5983); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal442_tree = (CommonTree)adaptor.Create(string_literal442);
            		adaptor.AddChild(root_0, string_literal442_tree);
            	}
            	PushFollow(FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5985);
            	notificationgroup_macro_status443 = notificationgroup_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, notificationgroup_macro_status443.Tree);
            	string_literal444=(IToken)Match(input,141,FOLLOW_141_in_notificationgroup_macro5987); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal444_tree = (CommonTree)adaptor.Create(string_literal444);
            		adaptor.AddChild(root_0, string_literal444_tree);
            	}
            	C_STRING445=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5989); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING445_tree = (CommonTree)adaptor.Create(C_STRING445);
            		adaptor.AddChild(root_0, C_STRING445_tree);
            	}
            	// Smi.g:911:88: ( 'REFERENCE' C_STRING )?
            	int alt103 = 2;
            	int LA103_0 = input.LA(1);

            	if ( (LA103_0 == 177) )
            	{
            	    alt103 = 1;
            	}
            	switch (alt103) 
            	{
            	    case 1 :
            	        // Smi.g:911:89: 'REFERENCE' C_STRING
            	        {
            	        	string_literal446=(IToken)Match(input,177,FOLLOW_177_in_notificationgroup_macro5992); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal446_tree = (CommonTree)adaptor.Create(string_literal446);
            	        		adaptor.AddChild(root_0, string_literal446_tree);
            	        	}
            	        	C_STRING447=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_notificationgroup_macro5994); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING447_tree = (CommonTree)adaptor.Create(C_STRING447);
            	        		adaptor.AddChild(root_0, C_STRING447_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro"

    public class notificationgroup_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "notificationgroup_macro_status"
    // Smi.g:912:0: notificationgroup_macro_status : l= LOWER ;
    public SmiParser.notificationgroup_macro_status_return notificationgroup_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.notificationgroup_macro_status_return retval = new SmiParser.notificationgroup_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:912:33: (l= LOWER )
            // Smi.g:912:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_notificationgroup_macro_status6005); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "notificationgroup_macro_status"

    public class modulecompliance_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro"
    // Smi.g:919:0: modulecompliance_macro : 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ ;
    public SmiParser.modulecompliance_macro_return modulecompliance_macro() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_return retval = new SmiParser.modulecompliance_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal448 = null;
        IToken string_literal449 = null;
        IToken string_literal451 = null;
        IToken C_STRING452 = null;
        IToken string_literal453 = null;
        IToken C_STRING454 = null;
        SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status450 = default(SmiParser.modulecompliance_macro_status_return);

        SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module455 = default(SmiParser.modulecompliance_macro_module_return);


        CommonTree string_literal448_tree=null;
        CommonTree string_literal449_tree=null;
        CommonTree string_literal451_tree=null;
        CommonTree C_STRING452_tree=null;
        CommonTree string_literal453_tree=null;
        CommonTree C_STRING454_tree=null;

        try 
    	{
            // Smi.g:919:25: ( 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+ )
            // Smi.g:919:25: 'MODULE-COMPLIANCE' 'STATUS' modulecompliance_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( modulecompliance_macro_module )+
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal448=(IToken)Match(input,158,FOLLOW_158_in_modulecompliance_macro6057); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal448_tree = (CommonTree)adaptor.Create(string_literal448);
            		adaptor.AddChild(root_0, string_literal448_tree);
            	}
            	string_literal449=(IToken)Match(input,184,FOLLOW_184_in_modulecompliance_macro6059); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal449_tree = (CommonTree)adaptor.Create(string_literal449);
            		adaptor.AddChild(root_0, string_literal449_tree);
            	}
            	PushFollow(FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6061);
            	modulecompliance_macro_status450 = modulecompliance_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_status450.Tree);
            	string_literal451=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro6087); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal451_tree = (CommonTree)adaptor.Create(string_literal451);
            		adaptor.AddChild(root_0, string_literal451_tree);
            	}
            	C_STRING452=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6089); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING452_tree = (CommonTree)adaptor.Create(C_STRING452);
            		adaptor.AddChild(root_0, C_STRING452_tree);
            	}
            	// Smi.g:920:48: ( 'REFERENCE' C_STRING )?
            	int alt104 = 2;
            	int LA104_0 = input.LA(1);

            	if ( (LA104_0 == 177) )
            	{
            	    alt104 = 1;
            	}
            	switch (alt104) 
            	{
            	    case 1 :
            	        // Smi.g:920:49: 'REFERENCE' C_STRING
            	        {
            	        	string_literal453=(IToken)Match(input,177,FOLLOW_177_in_modulecompliance_macro6092); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal453_tree = (CommonTree)adaptor.Create(string_literal453);
            	        		adaptor.AddChild(root_0, string_literal453_tree);
            	        	}
            	        	C_STRING454=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro6094); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING454_tree = (CommonTree)adaptor.Create(C_STRING454);
            	        		adaptor.AddChild(root_0, C_STRING454_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:920:72: ( modulecompliance_macro_module )+
            	int cnt105 = 0;
            	do 
            	{
            	    int alt105 = 2;
            	    int LA105_0 = input.LA(1);

            	    if ( (LA105_0 == 157) )
            	    {
            	        alt105 = 1;
            	    }


            	    switch (alt105) 
            		{
            			case 1 :
            			    // Smi.g:920:73: modulecompliance_macro_module
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6099);
            			    	modulecompliance_macro_module455 = modulecompliance_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_module455.Tree);

            			    }
            			    break;

            			default:
            			    if ( cnt105 >= 1 ) goto loop105;
            			    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            		            EarlyExitException eee105 =
            		                new EarlyExitException(105, input);
            		            throw eee105;
            	    }
            	    cnt105++;
            	} while (true);

            	loop105:
            		;	// Stops C# compiler whining that label 'loop105' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro"

    public class modulecompliance_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_status"
    // Smi.g:921:0: modulecompliance_macro_status : l= LOWER ;
    public SmiParser.modulecompliance_macro_status_return modulecompliance_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_status_return retval = new SmiParser.modulecompliance_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:921:32: (l= LOWER )
            // Smi.g:921:32: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_status6110); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("deprecated") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_status"

    public class modulecompliance_macro_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_module"
    // Smi.g:926:0: modulecompliance_macro_module : 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* ;
    public SmiParser.modulecompliance_macro_module_return modulecompliance_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_module_return retval = new SmiParser.modulecompliance_macro_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal456 = null;
        IToken UPPER457 = null;
        IToken string_literal459 = null;
        IToken L_BRACE460 = null;
        IToken COMMA462 = null;
        IToken R_BRACE464 = null;
        SmiParser.value_return value458 = default(SmiParser.value_return);

        SmiParser.value_return value461 = default(SmiParser.value_return);

        SmiParser.value_return value463 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance465 = default(SmiParser.modulecompliance_macro_compliance_return);


        CommonTree string_literal456_tree=null;
        CommonTree UPPER457_tree=null;
        CommonTree string_literal459_tree=null;
        CommonTree L_BRACE460_tree=null;
        CommonTree COMMA462_tree=null;
        CommonTree R_BRACE464_tree=null;

        try 
    	{
            // Smi.g:926:32: ( 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )* )
            // Smi.g:926:32: 'MODULE' (=> UPPER (=> value )? )? ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )? ( modulecompliance_macro_compliance )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal456=(IToken)Match(input,157,FOLLOW_157_in_modulecompliance_macro_module6158); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal456_tree = (CommonTree)adaptor.Create(string_literal456);
            		adaptor.AddChild(root_0, string_literal456_tree);
            	}
            	// Smi.g:926:41: (=> UPPER (=> value )? )?
            	int alt107 = 2;
            	alt107 = dfa107.Predict(input);
            	switch (alt107) 
            	{
            	    case 1 :
            	        // Smi.g:926:42: => UPPER (=> value )?
            	        {

            	        	UPPER457=(IToken)Match(input,UPPER,FOLLOW_UPPER_in_modulecompliance_macro_module6167); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{UPPER457_tree = (CommonTree)adaptor.Create(UPPER457);
            	        		adaptor.AddChild(root_0, UPPER457_tree);
            	        	}
            	        	// Smi.g:926:59: (=> value )?
            	        	int alt106 = 2;
            	        	alt106 = dfa106.Predict(input);
            	        	switch (alt106) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:926:60: => value
            	        	        {

            	        	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6176);
            	        	        	value458 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value458.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	// Smi.g:927:33: ( 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt109 = 2;
            	int LA109_0 = input.LA(1);

            	if ( (LA109_0 == 154) )
            	{
            	    alt109 = 1;
            	}
            	switch (alt109) 
            	{
            	    case 1 :
            	        // Smi.g:927:34: 'MANDATORY-GROUPS' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal459=(IToken)Match(input,154,FOLLOW_154_in_modulecompliance_macro_module6217); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal459_tree = (CommonTree)adaptor.Create(string_literal459);
            	        		adaptor.AddChild(root_0, string_literal459_tree);
            	        	}
            	        	L_BRACE460=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_module6219); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE460_tree = (CommonTree)adaptor.Create(L_BRACE460);
            	        		adaptor.AddChild(root_0, L_BRACE460_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6221);
            	        	value461 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value461.Tree);
            	        	// Smi.g:927:67: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt108 = 2;
            	        	    int LA108_0 = input.LA(1);

            	        	    if ( (LA108_0 == COMMA) )
            	        	    {
            	        	        alt108 = 1;
            	        	    }


            	        	    switch (alt108) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:927:68: COMMA value
            	        			    {
            	        			    	COMMA462=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_module6224); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA462_tree = (CommonTree)adaptor.Create(COMMA462);
            	        			    		adaptor.AddChild(root_0, COMMA462_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_modulecompliance_macro_module6226);
            	        			    	value463 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value463.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop108;
            	        	    }
            	        	} while (true);

            	        	loop108:
            	        		;	// Stops C# compiler whining that label 'loop108' has no statements

            	        	R_BRACE464=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_module6230); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE464_tree = (CommonTree)adaptor.Create(R_BRACE464);
            	        		adaptor.AddChild(root_0, R_BRACE464_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:928:33: ( modulecompliance_macro_compliance )*
            	do 
            	{
            	    int alt110 = 2;
            	    int LA110_0 = input.LA(1);

            	    if ( (LA110_0 == OBJECT_KW) )
            	    {
            	        int LA110_2 = input.LA(2);

            	        if ( (LA110_2 == B_STRING || LA110_2 == C_STRING || LA110_2 == FALSE_KW || LA110_2 == H_STRING || LA110_2 == L_BRACE || LA110_2 == LOWER || (LA110_2 >= MINUS && LA110_2 <= NUMBER) || LA110_2 == PLUS_INFINITY_KW || LA110_2 == TRUE_KW || LA110_2 == UPPER) )
            	        {
            	            alt110 = 1;
            	        }


            	    }
            	    else if ( (LA110_0 == 149) )
            	    {
            	        alt110 = 1;
            	    }


            	    switch (alt110) 
            		{
            			case 1 :
            			    // Smi.g:928:34: modulecompliance_macro_compliance
            			    {
            			    	PushFollow(FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6267);
            			    	modulecompliance_macro_compliance465 = modulecompliance_macro_compliance();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_compliance465.Tree);

            			    }
            			    break;

            			default:
            			    goto loop110;
            	    }
            	} while (true);

            	loop110:
            		;	// Stops C# compiler whining that label 'loop110' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_module"

    public class modulecompliance_macro_compliance_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_compliance"
    // Smi.g:929:0: modulecompliance_macro_compliance : ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING );
    public SmiParser.modulecompliance_macro_compliance_return modulecompliance_macro_compliance() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_compliance_return retval = new SmiParser.modulecompliance_macro_compliance_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal466 = null;
        IToken string_literal468 = null;
        IToken C_STRING469 = null;
        IToken string_literal470 = null;
        IToken string_literal472 = null;
        IToken string_literal474 = null;
        IToken string_literal476 = null;
        IToken string_literal478 = null;
        IToken string_literal480 = null;
        IToken C_STRING481 = null;
        SmiParser.value_return value467 = default(SmiParser.value_return);

        SmiParser.value_return value471 = default(SmiParser.value_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax473 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax475 = default(SmiParser.modulecompliance_macro_syntax_return);

        SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access477 = default(SmiParser.modulecompliance_macro_access_return);

        SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess479 = default(SmiParser.modulecompliance_macro_pibaccess_return);


        CommonTree string_literal466_tree=null;
        CommonTree string_literal468_tree=null;
        CommonTree C_STRING469_tree=null;
        CommonTree string_literal470_tree=null;
        CommonTree string_literal472_tree=null;
        CommonTree string_literal474_tree=null;
        CommonTree string_literal476_tree=null;
        CommonTree string_literal478_tree=null;
        CommonTree string_literal480_tree=null;
        CommonTree C_STRING481_tree=null;

        try 
    	{
            // Smi.g:929:36: ( 'GROUP' value 'DESCRIPTION' C_STRING | 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING )
            int alt115 = 2;
            int LA115_0 = input.LA(1);

            if ( (LA115_0 == 149) )
            {
                alt115 = 1;
            }
            else if ( (LA115_0 == OBJECT_KW) )
            {
                alt115 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d115s0 =
                    new NoViableAltException("", 115, 0, input);

                throw nvae_d115s0;
            }
            switch (alt115) 
            {
                case 1 :
                    // Smi.g:929:36: 'GROUP' value 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal466=(IToken)Match(input,149,FOLLOW_149_in_modulecompliance_macro_compliance6276); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal466_tree = (CommonTree)adaptor.Create(string_literal466);
                    		adaptor.AddChild(root_0, string_literal466_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6278);
                    	value467 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value467.Tree);
                    	string_literal468=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6280); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal468_tree = (CommonTree)adaptor.Create(string_literal468);
                    		adaptor.AddChild(root_0, string_literal468_tree);
                    	}
                    	C_STRING469=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6282); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING469_tree = (CommonTree)adaptor.Create(C_STRING469);
                    		adaptor.AddChild(root_0, C_STRING469_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:930:36: 'OBJECT' value ( 'SYNTAX' modulecompliance_macro_syntax )? ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )? ( 'MIN-ACCESS' modulecompliance_macro_access )? ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )? 'DESCRIPTION' C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	string_literal470=(IToken)Match(input,OBJECT_KW,FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6319); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal470_tree = (CommonTree)adaptor.Create(string_literal470);
                    		adaptor.AddChild(root_0, string_literal470_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_modulecompliance_macro_compliance6321);
                    	value471 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value471.Tree);
                    	// Smi.g:931:37: ( 'SYNTAX' modulecompliance_macro_syntax )?
                    	int alt111 = 2;
                    	int LA111_0 = input.LA(1);

                    	if ( (LA111_0 == 187) )
                    	{
                    	    alt111 = 1;
                    	}
                    	switch (alt111) 
                    	{
                    	    case 1 :
                    	        // Smi.g:931:38: 'SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal472=(IToken)Match(input,187,FOLLOW_187_in_modulecompliance_macro_compliance6361); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal472_tree = (CommonTree)adaptor.Create(string_literal472);
                    	        		adaptor.AddChild(root_0, string_literal472_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6363);
                    	        	modulecompliance_macro_syntax473 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax473.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:932:37: ( 'WRITE-SYNTAX' modulecompliance_macro_syntax )?
                    	int alt112 = 2;
                    	int LA112_0 = input.LA(1);

                    	if ( (LA112_0 == 197) )
                    	{
                    	    alt112 = 1;
                    	}
                    	switch (alt112) 
                    	{
                    	    case 1 :
                    	        // Smi.g:932:38: 'WRITE-SYNTAX' modulecompliance_macro_syntax
                    	        {
                    	        	string_literal474=(IToken)Match(input,197,FOLLOW_197_in_modulecompliance_macro_compliance6405); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal474_tree = (CommonTree)adaptor.Create(string_literal474);
                    	        		adaptor.AddChild(root_0, string_literal474_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6407);
                    	        	modulecompliance_macro_syntax475 = modulecompliance_macro_syntax();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_syntax475.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:933:37: ( 'MIN-ACCESS' modulecompliance_macro_access )?
                    	int alt113 = 2;
                    	int LA113_0 = input.LA(1);

                    	if ( (LA113_0 == 156) )
                    	{
                    	    alt113 = 1;
                    	}
                    	switch (alt113) 
                    	{
                    	    case 1 :
                    	        // Smi.g:933:38: 'MIN-ACCESS' modulecompliance_macro_access
                    	        {
                    	        	string_literal476=(IToken)Match(input,156,FOLLOW_156_in_modulecompliance_macro_compliance6454); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal476_tree = (CommonTree)adaptor.Create(string_literal476);
                    	        		adaptor.AddChild(root_0, string_literal476_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6456);
                    	        	modulecompliance_macro_access477 = modulecompliance_macro_access();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_access477.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:934:37: ( 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess )?
                    	int alt114 = 2;
                    	int LA114_0 = input.LA(1);

                    	if ( (LA114_0 == 171) )
                    	{
                    	    alt114 = 1;
                    	}
                    	switch (alt114) 
                    	{
                    	    case 1 :
                    	        // Smi.g:934:38: 'PIB-MIN-ACCESS' modulecompliance_macro_pibaccess
                    	        {
                    	        	string_literal478=(IToken)Match(input,171,FOLLOW_171_in_modulecompliance_macro_compliance6498); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{string_literal478_tree = (CommonTree)adaptor.Create(string_literal478);
                    	        		adaptor.AddChild(root_0, string_literal478_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6500);
                    	        	modulecompliance_macro_pibaccess479 = modulecompliance_macro_pibaccess();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_pibaccess479.Tree);

                    	        }
                    	        break;

                    	}

                    	string_literal480=(IToken)Match(input,141,FOLLOW_141_in_modulecompliance_macro_compliance6545); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{string_literal480_tree = (CommonTree)adaptor.Create(string_literal480);
                    		adaptor.AddChild(root_0, string_literal480_tree);
                    	}
                    	C_STRING481=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_modulecompliance_macro_compliance6547); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING481_tree = (CommonTree)adaptor.Create(C_STRING481);
                    		adaptor.AddChild(root_0, C_STRING481_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_compliance"

    public class modulecompliance_macro_syntax_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_syntax"
    // Smi.g:936:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.modulecompliance_macro_syntax_return modulecompliance_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_syntax_return retval = new SmiParser.modulecompliance_macro_syntax_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE483 = null;
        IToken COMMA485 = null;
        IToken R_BRACE487 = null;
        SmiParser.smi_type_return smi_type482 = default(SmiParser.smi_type_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit484 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit486 = default(SmiParser.modulecompliance_macro_namedbit_return);

        SmiParser.smi_type_return smi_type488 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping489 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type490 = default(SmiParser.type_return);


        CommonTree L_BRACE483_tree=null;
        CommonTree COMMA485_tree=null;
        CommonTree R_BRACE487_tree=null;

        try 
    	{
            // Smi.g:936:32: (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt118 = 3;
            alt118 = dfa118.Predict(input);
            switch (alt118) 
            {
                case 1 :
                    // Smi.g:936:32: => smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6561);
                    	smi_type482 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type482.Tree);
                    	L_BRACE483=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6563); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE483_tree = (CommonTree)adaptor.Create(L_BRACE483);
                    		adaptor.AddChild(root_0, L_BRACE483_tree);
                    	}
                    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6565);
                    	modulecompliance_macro_namedbit484 = modulecompliance_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit484.Tree);
                    	// Smi.g:936:103: ( COMMA modulecompliance_macro_namedbit )*
                    	do 
                    	{
                    	    int alt116 = 2;
                    	    int LA116_0 = input.LA(1);

                    	    if ( (LA116_0 == COMMA) )
                    	    {
                    	        alt116 = 1;
                    	    }


                    	    switch (alt116) 
                    		{
                    			case 1 :
                    			    // Smi.g:936:104: COMMA modulecompliance_macro_namedbit
                    			    {
                    			    	COMMA485=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_modulecompliance_macro_syntax6568); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA485_tree = (CommonTree)adaptor.Create(COMMA485);
                    			    		adaptor.AddChild(root_0, COMMA485_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6570);
                    			    	modulecompliance_macro_namedbit486 = modulecompliance_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, modulecompliance_macro_namedbit486.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop116;
                    	    }
                    	} while (true);

                    	loop116:
                    		;	// Stops C# compiler whining that label 'loop116' has no statements

                    	R_BRACE487=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6574); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE487_tree = (CommonTree)adaptor.Create(R_BRACE487);
                    		adaptor.AddChild(root_0, R_BRACE487_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:937:32: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_modulecompliance_macro_syntax6613);
                    	smi_type488 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type488.Tree);
                    	// Smi.g:937:55: ( smi_subtyping )?
                    	int alt117 = 2;
                    	int LA117_0 = input.LA(1);

                    	if ( (LA117_0 == L_PAREN) )
                    	{
                    	    alt117 = 1;
                    	}
                    	switch (alt117) 
                    	{
                    	    case 1 :
                    	        // Smi.g:937:56: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6616);
                    	        	smi_subtyping489 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping489.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:938:32: type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_modulecompliance_macro_syntax6651);
                    	type490 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type490.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_syntax"

    public class modulecompliance_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_namedbit"
    // Smi.g:939:0: modulecompliance_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.modulecompliance_macro_namedbit_return modulecompliance_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_namedbit_return retval = new SmiParser.modulecompliance_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER491 = null;
        IToken L_PAREN492 = null;
        IToken NUMBER493 = null;
        IToken R_PAREN494 = null;

        CommonTree LOWER491_tree=null;
        CommonTree L_PAREN492_tree=null;
        CommonTree NUMBER493_tree=null;
        CommonTree R_PAREN494_tree=null;

        try 
    	{
            // Smi.g:939:34: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:939:34: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER491=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_namedbit6657); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER491_tree = (CommonTree)adaptor.Create(LOWER491);
            		adaptor.AddChild(root_0, LOWER491_tree);
            	}
            	L_PAREN492=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6659); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN492_tree = (CommonTree)adaptor.Create(L_PAREN492);
            		adaptor.AddChild(root_0, L_PAREN492_tree);
            	}
            	NUMBER493=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6661); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER493_tree = (CommonTree)adaptor.Create(NUMBER493);
            		adaptor.AddChild(root_0, NUMBER493_tree);
            	}
            	R_PAREN494=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6663); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN494_tree = (CommonTree)adaptor.Create(R_PAREN494);
            		adaptor.AddChild(root_0, R_PAREN494_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_namedbit"

    public class modulecompliance_macro_access_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_access"
    // Smi.g:940:0: modulecompliance_macro_access : l= LOWER ;
    public SmiParser.modulecompliance_macro_access_return modulecompliance_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_access_return retval = new SmiParser.modulecompliance_macro_access_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:940:32: (l= LOWER )
            // Smi.g:940:32: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_access6671); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_access"

    public class modulecompliance_macro_pibaccess_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "modulecompliance_macro_pibaccess"
    // Smi.g:947:0: modulecompliance_macro_pibaccess : l= LOWER ;
    public SmiParser.modulecompliance_macro_pibaccess_return modulecompliance_macro_pibaccess() // throws RecognitionException [1]
    {   
        SmiParser.modulecompliance_macro_pibaccess_return retval = new SmiParser.modulecompliance_macro_pibaccess_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:947:35: (l= LOWER )
            // Smi.g:947:35: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6721); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-accessible") 
            	                                                  || l.Text == ("install") 
            	                                                  || l.Text == ("notify")
            	                                                  || l.Text == ("install-notify")
            	                                                  || l.Text == ("report-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "modulecompliance_macro_pibaccess"

    public class agentcapabilities_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro"
    // Smi.g:956:0: agentcapabilities_macro : 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* ;
    public SmiParser.agentcapabilities_macro_return agentcapabilities_macro() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_return retval = new SmiParser.agentcapabilities_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal495 = null;
        IToken string_literal496 = null;
        IToken C_STRING497 = null;
        IToken string_literal498 = null;
        IToken string_literal500 = null;
        IToken C_STRING501 = null;
        IToken string_literal502 = null;
        IToken C_STRING503 = null;
        SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status499 = default(SmiParser.agentcapabilities_macro_status_return);

        SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module504 = default(SmiParser.agentcapabilities_macro_module_return);


        CommonTree string_literal495_tree=null;
        CommonTree string_literal496_tree=null;
        CommonTree C_STRING497_tree=null;
        CommonTree string_literal498_tree=null;
        CommonTree string_literal500_tree=null;
        CommonTree C_STRING501_tree=null;
        CommonTree string_literal502_tree=null;
        CommonTree C_STRING503_tree=null;

        try 
    	{
            // Smi.g:956:26: ( 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )* )
            // Smi.g:956:26: 'AGENT-CAPABILITIES' 'PRODUCT-RELEASE' C_STRING 'STATUS' agentcapabilities_macro_status 'DESCRIPTION' C_STRING ( 'REFERENCE' C_STRING )? ( agentcapabilities_macro_module )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal495=(IToken)Match(input,131,FOLLOW_131_in_agentcapabilities_macro6772); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal495_tree = (CommonTree)adaptor.Create(string_literal495);
            		adaptor.AddChild(root_0, string_literal495_tree);
            	}
            	string_literal496=(IToken)Match(input,175,FOLLOW_175_in_agentcapabilities_macro6774); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal496_tree = (CommonTree)adaptor.Create(string_literal496);
            		adaptor.AddChild(root_0, string_literal496_tree);
            	}
            	C_STRING497=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6776); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING497_tree = (CommonTree)adaptor.Create(C_STRING497);
            		adaptor.AddChild(root_0, C_STRING497_tree);
            	}
            	string_literal498=(IToken)Match(input,184,FOLLOW_184_in_agentcapabilities_macro6778); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal498_tree = (CommonTree)adaptor.Create(string_literal498);
            		adaptor.AddChild(root_0, string_literal498_tree);
            	}
            	PushFollow(FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6780);
            	agentcapabilities_macro_status499 = agentcapabilities_macro_status();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_status499.Tree);
            	string_literal500=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro6807); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal500_tree = (CommonTree)adaptor.Create(string_literal500);
            		adaptor.AddChild(root_0, string_literal500_tree);
            	}
            	C_STRING501=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6809); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING501_tree = (CommonTree)adaptor.Create(C_STRING501);
            		adaptor.AddChild(root_0, C_STRING501_tree);
            	}
            	// Smi.g:957:49: ( 'REFERENCE' C_STRING )?
            	int alt119 = 2;
            	int LA119_0 = input.LA(1);

            	if ( (LA119_0 == 177) )
            	{
            	    alt119 = 1;
            	}
            	switch (alt119) 
            	{
            	    case 1 :
            	        // Smi.g:957:50: 'REFERENCE' C_STRING
            	        {
            	        	string_literal502=(IToken)Match(input,177,FOLLOW_177_in_agentcapabilities_macro6812); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal502_tree = (CommonTree)adaptor.Create(string_literal502);
            	        		adaptor.AddChild(root_0, string_literal502_tree);
            	        	}
            	        	C_STRING503=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro6814); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{C_STRING503_tree = (CommonTree)adaptor.Create(C_STRING503);
            	        		adaptor.AddChild(root_0, C_STRING503_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:957:73: ( agentcapabilities_macro_module )*
            	do 
            	{
            	    int alt120 = 2;
            	    int LA120_0 = input.LA(1);

            	    if ( (LA120_0 == 186) )
            	    {
            	        alt120 = 1;
            	    }


            	    switch (alt120) 
            		{
            			case 1 :
            			    // Smi.g:957:74: agentcapabilities_macro_module
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6819);
            			    	agentcapabilities_macro_module504 = agentcapabilities_macro_module();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_module504.Tree);

            			    }
            			    break;

            			default:
            			    goto loop120;
            	    }
            	} while (true);

            	loop120:
            		;	// Stops C# compiler whining that label 'loop120' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro"

    public class agentcapabilities_macro_status_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_status"
    // Smi.g:958:0: agentcapabilities_macro_status : l= LOWER ;
    public SmiParser.agentcapabilities_macro_status_return agentcapabilities_macro_status() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_status_return retval = new SmiParser.agentcapabilities_macro_status_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:958:33: (l= LOWER )
            // Smi.g:958:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_status6829); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("current") 
            	                                                  || l.Text == ("obsolete"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_status"

    public class agentcapabilities_macro_module_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_module"
    // Smi.g:962:0: agentcapabilities_macro_module : 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* ;
    public SmiParser.agentcapabilities_macro_module_return agentcapabilities_macro_module() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_module_return retval = new SmiParser.agentcapabilities_macro_module_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal505 = null;
        IToken LOWER506 = null;
        IToken string_literal508 = null;
        IToken L_BRACE509 = null;
        IToken COMMA511 = null;
        IToken R_BRACE513 = null;
        SmiParser.value_return value507 = default(SmiParser.value_return);

        SmiParser.value_return value510 = default(SmiParser.value_return);

        SmiParser.value_return value512 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation514 = default(SmiParser.agentcapabilities_macro_variation_return);


        CommonTree string_literal505_tree=null;
        CommonTree LOWER506_tree=null;
        CommonTree string_literal508_tree=null;
        CommonTree L_BRACE509_tree=null;
        CommonTree COMMA511_tree=null;
        CommonTree R_BRACE513_tree=null;

        try 
    	{
            // Smi.g:962:33: ( 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )* )
            // Smi.g:962:33: 'SUPPORTS' LOWER ( value )? 'INCLUDES' L_BRACE value ( COMMA value )* R_BRACE ( agentcapabilities_macro_variation )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal505=(IToken)Match(input,186,FOLLOW_186_in_agentcapabilities_macro_module6877); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal505_tree = (CommonTree)adaptor.Create(string_literal505);
            		adaptor.AddChild(root_0, string_literal505_tree);
            	}
            	LOWER506=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_module6879); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER506_tree = (CommonTree)adaptor.Create(LOWER506);
            		adaptor.AddChild(root_0, LOWER506_tree);
            	}
            	// Smi.g:962:50: ( value )?
            	int alt121 = 2;
            	int LA121_0 = input.LA(1);

            	if ( (LA121_0 == B_STRING || LA121_0 == C_STRING || LA121_0 == FALSE_KW || LA121_0 == H_STRING || LA121_0 == L_BRACE || LA121_0 == LOWER || (LA121_0 >= MINUS && LA121_0 <= NUMBER) || LA121_0 == PLUS_INFINITY_KW || LA121_0 == TRUE_KW || LA121_0 == UPPER) )
            	{
            	    alt121 = 1;
            	}
            	switch (alt121) 
            	{
            	    case 1 :
            	        // Smi.g:962:51: value
            	        {
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6882);
            	        	value507 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value507.Tree);

            	        }
            	        break;

            	}

            	string_literal508=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6919); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal508_tree = (CommonTree)adaptor.Create(string_literal508);
            		adaptor.AddChild(root_0, string_literal508_tree);
            	}
            	L_BRACE509=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_module6921); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE509_tree = (CommonTree)adaptor.Create(L_BRACE509);
            		adaptor.AddChild(root_0, L_BRACE509_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6923);
            	value510 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value510.Tree);
            	// Smi.g:963:58: ( COMMA value )*
            	do 
            	{
            	    int alt122 = 2;
            	    int LA122_0 = input.LA(1);

            	    if ( (LA122_0 == COMMA) )
            	    {
            	        alt122 = 1;
            	    }


            	    switch (alt122) 
            		{
            			case 1 :
            			    // Smi.g:963:59: COMMA value
            			    {
            			    	COMMA511=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_module6926); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA511_tree = (CommonTree)adaptor.Create(COMMA511);
            			    		adaptor.AddChild(root_0, COMMA511_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_module6928);
            			    	value512 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value512.Tree);

            			    }
            			    break;

            			default:
            			    goto loop122;
            	    }
            	} while (true);

            	loop122:
            		;	// Stops C# compiler whining that label 'loop122' has no statements

            	R_BRACE513=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_module6932); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE513_tree = (CommonTree)adaptor.Create(R_BRACE513);
            		adaptor.AddChild(root_0, R_BRACE513_tree);
            	}
            	// Smi.g:964:33: ( agentcapabilities_macro_variation )*
            	do 
            	{
            	    int alt123 = 2;
            	    int LA123_0 = input.LA(1);

            	    if ( (LA123_0 == 196) )
            	    {
            	        alt123 = 1;
            	    }


            	    switch (alt123) 
            		{
            			case 1 :
            			    // Smi.g:964:34: agentcapabilities_macro_variation
            			    {
            			    	PushFollow(FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6968);
            			    	agentcapabilities_macro_variation514 = agentcapabilities_macro_variation();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_variation514.Tree);

            			    }
            			    break;

            			default:
            			    goto loop123;
            	    }
            	} while (true);

            	loop123:
            		;	// Stops C# compiler whining that label 'loop123' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_module"

    public class agentcapabilities_macro_variation_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_variation"
    // Smi.g:965:0: agentcapabilities_macro_variation : 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING ;
    public SmiParser.agentcapabilities_macro_variation_return agentcapabilities_macro_variation() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_variation_return retval = new SmiParser.agentcapabilities_macro_variation_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal515 = null;
        IToken string_literal517 = null;
        IToken string_literal519 = null;
        IToken string_literal521 = null;
        IToken string_literal523 = null;
        IToken L_BRACE524 = null;
        IToken COMMA526 = null;
        IToken R_BRACE528 = null;
        IToken string_literal529 = null;
        IToken L_BRACE530 = null;
        IToken L_BRACE531 = null;
        IToken LOWER532 = null;
        IToken COMMA533 = null;
        IToken LOWER534 = null;
        IToken R_BRACE535 = null;
        IToken string_literal537 = null;
        IToken C_STRING538 = null;
        SmiParser.value_return value516 = default(SmiParser.value_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax518 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax520 = default(SmiParser.agentcapabilities_macro_syntax_return);

        SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access522 = default(SmiParser.agentcapabilities_macro_access_return);

        SmiParser.value_return value525 = default(SmiParser.value_return);

        SmiParser.value_return value527 = default(SmiParser.value_return);

        SmiParser.value_return value536 = default(SmiParser.value_return);


        CommonTree string_literal515_tree=null;
        CommonTree string_literal517_tree=null;
        CommonTree string_literal519_tree=null;
        CommonTree string_literal521_tree=null;
        CommonTree string_literal523_tree=null;
        CommonTree L_BRACE524_tree=null;
        CommonTree COMMA526_tree=null;
        CommonTree R_BRACE528_tree=null;
        CommonTree string_literal529_tree=null;
        CommonTree L_BRACE530_tree=null;
        CommonTree L_BRACE531_tree=null;
        CommonTree LOWER532_tree=null;
        CommonTree COMMA533_tree=null;
        CommonTree LOWER534_tree=null;
        CommonTree R_BRACE535_tree=null;
        CommonTree string_literal537_tree=null;
        CommonTree C_STRING538_tree=null;

        try 
    	{
            // Smi.g:965:36: ( 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING )
            // Smi.g:965:36: 'VARIATION' value ( 'SYNTAX' agentcapabilities_macro_syntax )? ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )? ( 'ACCESS' agentcapabilities_macro_access )? ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )? ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )? 'DESCRIPTION' C_STRING
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal515=(IToken)Match(input,196,FOLLOW_196_in_agentcapabilities_macro_variation6976); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal515_tree = (CommonTree)adaptor.Create(string_literal515);
            		adaptor.AddChild(root_0, string_literal515_tree);
            	}
            	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation6978);
            	value516 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value516.Tree);
            	// Smi.g:965:54: ( 'SYNTAX' agentcapabilities_macro_syntax )?
            	int alt124 = 2;
            	int LA124_0 = input.LA(1);

            	if ( (LA124_0 == 187) )
            	{
            	    alt124 = 1;
            	}
            	switch (alt124) 
            	{
            	    case 1 :
            	        // Smi.g:965:55: 'SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal517=(IToken)Match(input,187,FOLLOW_187_in_agentcapabilities_macro_variation6981); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal517_tree = (CommonTree)adaptor.Create(string_literal517);
            	        		adaptor.AddChild(root_0, string_literal517_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6983);
            	        	agentcapabilities_macro_syntax518 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax518.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:965:97: ( 'WRITE-SYNTAX' agentcapabilities_macro_syntax )?
            	int alt125 = 2;
            	int LA125_0 = input.LA(1);

            	if ( (LA125_0 == 197) )
            	{
            	    alt125 = 1;
            	}
            	switch (alt125) 
            	{
            	    case 1 :
            	        // Smi.g:965:98: 'WRITE-SYNTAX' agentcapabilities_macro_syntax
            	        {
            	        	string_literal519=(IToken)Match(input,197,FOLLOW_197_in_agentcapabilities_macro_variation6988); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal519_tree = (CommonTree)adaptor.Create(string_literal519);
            	        		adaptor.AddChild(root_0, string_literal519_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6990);
            	        	agentcapabilities_macro_syntax520 = agentcapabilities_macro_syntax();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_syntax520.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:965:146: ( 'ACCESS' agentcapabilities_macro_access )?
            	int alt126 = 2;
            	int LA126_0 = input.LA(1);

            	if ( (LA126_0 == 130) )
            	{
            	    alt126 = 1;
            	}
            	switch (alt126) 
            	{
            	    case 1 :
            	        // Smi.g:965:147: 'ACCESS' agentcapabilities_macro_access
            	        {
            	        	string_literal521=(IToken)Match(input,130,FOLLOW_130_in_agentcapabilities_macro_variation6995); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal521_tree = (CommonTree)adaptor.Create(string_literal521);
            	        		adaptor.AddChild(root_0, string_literal521_tree);
            	        	}
            	        	PushFollow(FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6997);
            	        	agentcapabilities_macro_access522 = agentcapabilities_macro_access();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_access522.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:966:37: ( 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt128 = 2;
            	int LA128_0 = input.LA(1);

            	if ( (LA128_0 == 139) )
            	{
            	    alt128 = 1;
            	}
            	switch (alt128) 
            	{
            	    case 1 :
            	        // Smi.g:966:38: 'CREATION-REQUIRES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal523=(IToken)Match(input,139,FOLLOW_139_in_agentcapabilities_macro_variation7039); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal523_tree = (CommonTree)adaptor.Create(string_literal523);
            	        		adaptor.AddChild(root_0, string_literal523_tree);
            	        	}
            	        	L_BRACE524=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7041); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE524_tree = (CommonTree)adaptor.Create(L_BRACE524);
            	        		adaptor.AddChild(root_0, L_BRACE524_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7043);
            	        	value525 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value525.Tree);
            	        	// Smi.g:966:72: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt127 = 2;
            	        	    int LA127_0 = input.LA(1);

            	        	    if ( (LA127_0 == COMMA) )
            	        	    {
            	        	        alt127 = 1;
            	        	    }


            	        	    switch (alt127) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:966:73: COMMA value
            	        			    {
            	        			    	COMMA526=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7046); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA526_tree = (CommonTree)adaptor.Create(COMMA526);
            	        			    		adaptor.AddChild(root_0, COMMA526_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7048);
            	        			    	value527 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value527.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop127;
            	        	    }
            	        	} while (true);

            	        	loop127:
            	        		;	// Stops C# compiler whining that label 'loop127' has no statements

            	        	R_BRACE528=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7052); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE528_tree = (CommonTree)adaptor.Create(R_BRACE528);
            	        		adaptor.AddChild(root_0, R_BRACE528_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:967:37: ( 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value ) )?
            	int alt132 = 2;
            	int LA132_0 = input.LA(1);

            	if ( (LA132_0 == 140) )
            	{
            	    alt132 = 1;
            	}
            	switch (alt132) 
            	{
            	    case 1 :
            	        // Smi.g:967:38: 'DEFVAL' L_BRACE (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        {
            	        	string_literal529=(IToken)Match(input,140,FOLLOW_140_in_agentcapabilities_macro_variation7094); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal529_tree = (CommonTree)adaptor.Create(string_literal529);
            	        		adaptor.AddChild(root_0, string_literal529_tree);
            	        	}
            	        	L_BRACE530=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7096); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE530_tree = (CommonTree)adaptor.Create(L_BRACE530);
            	        		adaptor.AddChild(root_0, L_BRACE530_tree);
            	        	}
            	        	// Smi.g:967:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )
            	        	int alt131 = 2;
            	        	alt131 = dfa131.Predict(input);
            	        	switch (alt131) 
            	        	{
            	        	    case 1 :
            	        	        // Smi.g:967:56: => L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE
            	        	        {

            	        	        	L_BRACE531=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7117); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{L_BRACE531_tree = (CommonTree)adaptor.Create(L_BRACE531);
            	        	        		adaptor.AddChild(root_0, L_BRACE531_tree);
            	        	        	}
            	        	        	// Smi.g:967:103: ( LOWER )?
            	        	        	int alt129 = 2;
            	        	        	int LA129_0 = input.LA(1);

            	        	        	if ( (LA129_0 == LOWER) )
            	        	        	{
            	        	        	    alt129 = 1;
            	        	        	}
            	        	        	switch (alt129) 
            	        	        	{
            	        	        	    case 1 :
            	        	        	        // Smi.g:967:104: LOWER
            	        	        	        {
            	        	        	        	LOWER532=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7120); if (state.failed) return retval;
            	        	        	        	if ( state.backtracking == 0 )
            	        	        	        	{LOWER532_tree = (CommonTree)adaptor.Create(LOWER532);
            	        	        	        		adaptor.AddChild(root_0, LOWER532_tree);
            	        	        	        	}

            	        	        	        }
            	        	        	        break;

            	        	        	}

            	        	        	// Smi.g:967:112: ( COMMA LOWER )*
            	        	        	do 
            	        	        	{
            	        	        	    int alt130 = 2;
            	        	        	    int LA130_0 = input.LA(1);

            	        	        	    if ( (LA130_0 == COMMA) )
            	        	        	    {
            	        	        	        alt130 = 1;
            	        	        	    }


            	        	        	    switch (alt130) 
            	        	        		{
            	        	        			case 1 :
            	        	        			    // Smi.g:967:113: COMMA LOWER
            	        	        			    {
            	        	        			    	COMMA533=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_variation7125); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{COMMA533_tree = (CommonTree)adaptor.Create(COMMA533);
            	        	        			    		adaptor.AddChild(root_0, COMMA533_tree);
            	        	        			    	}
            	        	        			    	LOWER534=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_variation7127); if (state.failed) return retval;
            	        	        			    	if ( state.backtracking == 0 )
            	        	        			    	{LOWER534_tree = (CommonTree)adaptor.Create(LOWER534);
            	        	        			    		adaptor.AddChild(root_0, LOWER534_tree);
            	        	        			    	}

            	        	        			    }
            	        	        			    break;

            	        	        			default:
            	        	        			    goto loop130;
            	        	        	    }
            	        	        	} while (true);

            	        	        	loop130:
            	        	        		;	// Stops C# compiler whining that label 'loop130' has no statements

            	        	        	R_BRACE535=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7131); if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 )
            	        	        	{R_BRACE535_tree = (CommonTree)adaptor.Create(R_BRACE535);
            	        	        		adaptor.AddChild(root_0, R_BRACE535_tree);
            	        	        	}

            	        	        }
            	        	        break;
            	        	    case 2 :
            	        	        // Smi.g:967:137: value
            	        	        {
            	        	        	PushFollow(FOLLOW_value_in_agentcapabilities_macro_variation7135);
            	        	        	value536 = value();
            	        	        	state.followingStackPointer--;
            	        	        	if (state.failed) return retval;
            	        	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value536.Tree);

            	        	        }
            	        	        break;

            	        	}


            	        }
            	        break;

            	}

            	string_literal537=(IToken)Match(input,141,FOLLOW_141_in_agentcapabilities_macro_variation7178); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal537_tree = (CommonTree)adaptor.Create(string_literal537);
            		adaptor.AddChild(root_0, string_literal537_tree);
            	}
            	C_STRING538=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_agentcapabilities_macro_variation7180); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{C_STRING538_tree = (CommonTree)adaptor.Create(C_STRING538);
            		adaptor.AddChild(root_0, C_STRING538_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_variation"

    public class agentcapabilities_macro_syntax_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_syntax"
    // Smi.g:969:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );
    public SmiParser.agentcapabilities_macro_syntax_return agentcapabilities_macro_syntax() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_syntax_return retval = new SmiParser.agentcapabilities_macro_syntax_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE540 = null;
        IToken COMMA542 = null;
        IToken R_BRACE544 = null;
        SmiParser.smi_type_return smi_type539 = default(SmiParser.smi_type_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit541 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit543 = default(SmiParser.agentcapabilities_macro_namedbit_return);

        SmiParser.smi_type_return smi_type545 = default(SmiParser.smi_type_return);

        SmiParser.smi_subtyping_return smi_subtyping546 = default(SmiParser.smi_subtyping_return);

        SmiParser.type_return type547 = default(SmiParser.type_return);


        CommonTree L_BRACE540_tree=null;
        CommonTree COMMA542_tree=null;
        CommonTree R_BRACE544_tree=null;

        try 
    	{
            // Smi.g:969:33: (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type )
            int alt135 = 3;
            alt135 = dfa135.Predict(input);
            switch (alt135) 
            {
                case 1 :
                    // Smi.g:969:33: => smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7231);
                    	smi_type539 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type539.Tree);
                    	L_BRACE540=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7233); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE540_tree = (CommonTree)adaptor.Create(L_BRACE540);
                    		adaptor.AddChild(root_0, L_BRACE540_tree);
                    	}
                    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7235);
                    	agentcapabilities_macro_namedbit541 = agentcapabilities_macro_namedbit();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit541.Tree);
                    	// Smi.g:970:87: ( COMMA agentcapabilities_macro_namedbit )*
                    	do 
                    	{
                    	    int alt133 = 2;
                    	    int LA133_0 = input.LA(1);

                    	    if ( (LA133_0 == COMMA) )
                    	    {
                    	        alt133 = 1;
                    	    }


                    	    switch (alt133) 
                    		{
                    			case 1 :
                    			    // Smi.g:970:88: COMMA agentcapabilities_macro_namedbit
                    			    {
                    			    	COMMA542=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_agentcapabilities_macro_syntax7238); if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 )
                    			    	{COMMA542_tree = (CommonTree)adaptor.Create(COMMA542);
                    			    		adaptor.AddChild(root_0, COMMA542_tree);
                    			    	}
                    			    	PushFollow(FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7240);
                    			    	agentcapabilities_macro_namedbit543 = agentcapabilities_macro_namedbit();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, agentcapabilities_macro_namedbit543.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop133;
                    	    }
                    	} while (true);

                    	loop133:
                    		;	// Stops C# compiler whining that label 'loop133' has no statements

                    	R_BRACE544=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7244); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE544_tree = (CommonTree)adaptor.Create(R_BRACE544);
                    		adaptor.AddChild(root_0, R_BRACE544_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:971:33: => smi_type ( smi_subtyping )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_smi_type_in_agentcapabilities_macro_syntax7284);
                    	smi_type545 = smi_type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_type545.Tree);
                    	// Smi.g:971:56: ( smi_subtyping )?
                    	int alt134 = 2;
                    	int LA134_0 = input.LA(1);

                    	if ( (LA134_0 == L_PAREN) )
                    	{
                    	    alt134 = 1;
                    	}
                    	switch (alt134) 
                    	{
                    	    case 1 :
                    	        // Smi.g:971:57: smi_subtyping
                    	        {
                    	        	PushFollow(FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7287);
                    	        	smi_subtyping546 = smi_subtyping();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, smi_subtyping546.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 3 :
                    // Smi.g:972:33: type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_type_in_agentcapabilities_macro_syntax7323);
                    	type547 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type547.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_syntax"

    public class agentcapabilities_macro_access_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_access"
    // Smi.g:973:0: agentcapabilities_macro_access : l= LOWER ;
    public SmiParser.agentcapabilities_macro_access_return agentcapabilities_macro_access() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_access_return retval = new SmiParser.agentcapabilities_macro_access_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken l = null;

        CommonTree l_tree=null;

        try 
    	{
            // Smi.g:973:33: (l= LOWER )
            // Smi.g:973:33: l= LOWER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	l=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_access7332); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{l_tree = (CommonTree)adaptor.Create(l);
            		adaptor.AddChild(root_0, l_tree);
            	}
            	if ( (state.backtracking==0) )
            	{
            	  if (l.Text == ("not-implemented") 
            	                                                  || l.Text == ("accessible-for-notify") 
            	                                                  || l.Text == ("read-only")
            	                                                  || l.Text == ("read-write")
            	                                                  || l.Text == ("read-create")
            	                                                  || l.Text == ("write-only"))
            	                                              {/*DOSOMETHING*/} else {throw new SemanticException("(invalid)");}
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_access"

    public class agentcapabilities_macro_namedbit_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "agentcapabilities_macro_namedbit"
    // Smi.g:981:0: agentcapabilities_macro_namedbit : LOWER L_PAREN NUMBER R_PAREN ;
    public SmiParser.agentcapabilities_macro_namedbit_return agentcapabilities_macro_namedbit() // throws RecognitionException [1]
    {   
        SmiParser.agentcapabilities_macro_namedbit_return retval = new SmiParser.agentcapabilities_macro_namedbit_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER548 = null;
        IToken L_PAREN549 = null;
        IToken NUMBER550 = null;
        IToken R_PAREN551 = null;

        CommonTree LOWER548_tree=null;
        CommonTree L_PAREN549_tree=null;
        CommonTree NUMBER550_tree=null;
        CommonTree R_PAREN551_tree=null;

        try 
    	{
            // Smi.g:981:35: ( LOWER L_PAREN NUMBER R_PAREN )
            // Smi.g:981:35: LOWER L_PAREN NUMBER R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER548=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7380); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER548_tree = (CommonTree)adaptor.Create(LOWER548);
            		adaptor.AddChild(root_0, LOWER548_tree);
            	}
            	L_PAREN549=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7382); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN549_tree = (CommonTree)adaptor.Create(L_PAREN549);
            		adaptor.AddChild(root_0, L_PAREN549_tree);
            	}
            	NUMBER550=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7384); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER550_tree = (CommonTree)adaptor.Create(NUMBER550);
            		adaptor.AddChild(root_0, NUMBER550_tree);
            	}
            	R_PAREN551=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7386); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN551_tree = (CommonTree)adaptor.Create(R_PAREN551);
            		adaptor.AddChild(root_0, R_PAREN551_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "agentcapabilities_macro_namedbit"

    public class traptype_macro_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "traptype_macro"
    // Smi.g:985:0: traptype_macro : 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? ;
    public SmiParser.traptype_macro_return traptype_macro() // throws RecognitionException [1]
    {   
        SmiParser.traptype_macro_return retval = new SmiParser.traptype_macro_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken string_literal552 = null;
        IToken string_literal553 = null;
        IToken string_literal555 = null;
        IToken L_BRACE556 = null;
        IToken COMMA558 = null;
        IToken R_BRACE560 = null;
        IToken string_literal561 = null;
        IToken string_literal563 = null;
        SmiParser.value_return value554 = default(SmiParser.value_return);

        SmiParser.value_return value557 = default(SmiParser.value_return);

        SmiParser.value_return value559 = default(SmiParser.value_return);

        SmiParser.value_return value562 = default(SmiParser.value_return);

        SmiParser.value_return value564 = default(SmiParser.value_return);


        CommonTree string_literal552_tree=null;
        CommonTree string_literal553_tree=null;
        CommonTree string_literal555_tree=null;
        CommonTree L_BRACE556_tree=null;
        CommonTree COMMA558_tree=null;
        CommonTree R_BRACE560_tree=null;
        CommonTree string_literal561_tree=null;
        CommonTree string_literal563_tree=null;

        try 
    	{
            // Smi.g:985:17: ( 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )? )
            // Smi.g:985:17: 'TRAP-TYPE' 'ENTERPRISE' value ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )? (=> 'DESCRIPTION' value )? ( 'REFERENCE' value )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	string_literal552=(IToken)Match(input,191,FOLLOW_191_in_traptype_macro7396); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal552_tree = (CommonTree)adaptor.Create(string_literal552);
            		adaptor.AddChild(root_0, string_literal552_tree);
            	}
            	string_literal553=(IToken)Match(input,144,FOLLOW_144_in_traptype_macro7398); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{string_literal553_tree = (CommonTree)adaptor.Create(string_literal553);
            		adaptor.AddChild(root_0, string_literal553_tree);
            	}
            	PushFollow(FOLLOW_value_in_traptype_macro7400);
            	value554 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value554.Tree);
            	// Smi.g:985:48: ( 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE )?
            	int alt137 = 2;
            	int LA137_0 = input.LA(1);

            	if ( (LA137_0 == 195) )
            	{
            	    alt137 = 1;
            	}
            	switch (alt137) 
            	{
            	    case 1 :
            	        // Smi.g:985:49: 'VARIABLES' L_BRACE value ( COMMA value )* R_BRACE
            	        {
            	        	string_literal555=(IToken)Match(input,195,FOLLOW_195_in_traptype_macro7403); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal555_tree = (CommonTree)adaptor.Create(string_literal555);
            	        		adaptor.AddChild(root_0, string_literal555_tree);
            	        	}
            	        	L_BRACE556=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_traptype_macro7405); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{L_BRACE556_tree = (CommonTree)adaptor.Create(L_BRACE556);
            	        		adaptor.AddChild(root_0, L_BRACE556_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7407);
            	        	value557 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value557.Tree);
            	        	// Smi.g:985:75: ( COMMA value )*
            	        	do 
            	        	{
            	        	    int alt136 = 2;
            	        	    int LA136_0 = input.LA(1);

            	        	    if ( (LA136_0 == COMMA) )
            	        	    {
            	        	        alt136 = 1;
            	        	    }


            	        	    switch (alt136) 
            	        		{
            	        			case 1 :
            	        			    // Smi.g:985:76: COMMA value
            	        			    {
            	        			    	COMMA558=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_traptype_macro7410); if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 )
            	        			    	{COMMA558_tree = (CommonTree)adaptor.Create(COMMA558);
            	        			    		adaptor.AddChild(root_0, COMMA558_tree);
            	        			    	}
            	        			    	PushFollow(FOLLOW_value_in_traptype_macro7412);
            	        			    	value559 = value();
            	        			    	state.followingStackPointer--;
            	        			    	if (state.failed) return retval;
            	        			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value559.Tree);

            	        			    }
            	        			    break;

            	        			default:
            	        			    goto loop136;
            	        	    }
            	        	} while (true);

            	        	loop136:
            	        		;	// Stops C# compiler whining that label 'loop136' has no statements

            	        	R_BRACE560=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_traptype_macro7416); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{R_BRACE560_tree = (CommonTree)adaptor.Create(R_BRACE560);
            	        		adaptor.AddChild(root_0, R_BRACE560_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:986:21: (=> 'DESCRIPTION' value )?
            	int alt138 = 2;
            	alt138 = dfa138.Predict(input);
            	switch (alt138) 
            	{
            	    case 1 :
            	        // Smi.g:986:22: => 'DESCRIPTION' value
            	        {

            	        	string_literal561=(IToken)Match(input,141,FOLLOW_141_in_traptype_macro7448); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal561_tree = (CommonTree)adaptor.Create(string_literal561);
            	        		adaptor.AddChild(root_0, string_literal561_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7450);
            	        	value562 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value562.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:986:63: ( 'REFERENCE' value )?
            	int alt139 = 2;
            	int LA139_0 = input.LA(1);

            	if ( (LA139_0 == 177) )
            	{
            	    alt139 = 1;
            	}
            	switch (alt139) 
            	{
            	    case 1 :
            	        // Smi.g:986:64: 'REFERENCE' value
            	        {
            	        	string_literal563=(IToken)Match(input,177,FOLLOW_177_in_traptype_macro7455); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{string_literal563_tree = (CommonTree)adaptor.Create(string_literal563);
            	        		adaptor.AddChild(root_0, string_literal563_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_traptype_macro7457);
            	        	value564 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value564.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "traptype_macro"

    public class operation_errorlist_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "operation_errorlist"
    // Smi.g:988:0: operation_errorlist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.operation_errorlist_return operation_errorlist() // throws RecognitionException [1]
    {   
        SmiParser.operation_errorlist_return retval = new SmiParser.operation_errorlist_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA566 = null;
        SmiParser.typeorvalue_return typeorvalue565 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue567 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA566_tree=null;

        try 
    	{
            // Smi.g:988:22: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:988:22: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7467);
            	typeorvalue565 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue565.Tree);
            	// Smi.g:988:34: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt140 = 2;
            	    int LA140_0 = input.LA(1);

            	    if ( (LA140_0 == COMMA) )
            	    {
            	        alt140 = 1;
            	    }


            	    switch (alt140) 
            		{
            			case 1 :
            			    // Smi.g:988:35: COMMA typeorvalue
            			    {
            			    	COMMA566=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_operation_errorlist7470); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA566_tree = (CommonTree)adaptor.Create(COMMA566);
            			    		adaptor.AddChild(root_0, COMMA566_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_operation_errorlist7472);
            			    	typeorvalue567 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue567.Tree);

            			    }
            			    break;

            			default:
            			    goto loop140;
            	    }
            	} while (true);

            	loop140:
            		;	// Stops C# compiler whining that label 'loop140' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "operation_errorlist"

    public class linkedOp_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "linkedOp_list"
    // Smi.g:990:0: linkedOp_list : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.linkedOp_list_return linkedOp_list() // throws RecognitionException [1]
    {   
        SmiParser.linkedOp_list_return retval = new SmiParser.linkedOp_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA569 = null;
        SmiParser.typeorvalue_return typeorvalue568 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue570 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA569_tree=null;

        try 
    	{
            // Smi.g:990:16: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:990:16: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7482);
            	typeorvalue568 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue568.Tree);
            	// Smi.g:990:28: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt141 = 2;
            	    int LA141_0 = input.LA(1);

            	    if ( (LA141_0 == COMMA) )
            	    {
            	        alt141 = 1;
            	    }


            	    switch (alt141) 
            		{
            			case 1 :
            			    // Smi.g:990:29: COMMA typeorvalue
            			    {
            			    	COMMA569=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_linkedOp_list7485); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA569_tree = (CommonTree)adaptor.Create(COMMA569);
            			    		adaptor.AddChild(root_0, COMMA569_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_linkedOp_list7487);
            			    	typeorvalue570 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue570.Tree);

            			    }
            			    break;

            			default:
            			    goto loop141;
            	    }
            	} while (true);

            	loop141:
            		;	// Stops C# compiler whining that label 'loop141' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "linkedOp_list"

    public class typeorvalue_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeorvalue"
    // Smi.g:992:0: typeorvalue : (=> type | value );
    public SmiParser.typeorvalue_return typeorvalue() // throws RecognitionException [1]
    {   
        SmiParser.typeorvalue_return retval = new SmiParser.typeorvalue_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        SmiParser.type_return type571 = default(SmiParser.type_return);

        SmiParser.value_return value572 = default(SmiParser.value_return);



        try 
    	{
            // Smi.g:992:14: (=> type | value )
            int alt142 = 2;
            alt142 = dfa142.Predict(input);
            switch (alt142) 
            {
                case 1 :
                    // Smi.g:992:14: => type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_type_in_typeorvalue7503);
                    	type571 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type571.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:992:31: value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_value_in_typeorvalue7507);
                    	value572 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value572.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvalue"

    public class typeorvaluelist_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "typeorvaluelist"
    // Smi.g:995:0: typeorvaluelist : typeorvalue ( COMMA typeorvalue )* ;
    public SmiParser.typeorvaluelist_return typeorvaluelist() // throws RecognitionException [1]
    {   
        SmiParser.typeorvaluelist_return retval = new SmiParser.typeorvaluelist_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA574 = null;
        SmiParser.typeorvalue_return typeorvalue573 = default(SmiParser.typeorvalue_return);

        SmiParser.typeorvalue_return typeorvalue575 = default(SmiParser.typeorvalue_return);


        CommonTree COMMA574_tree=null;

        try 
    	{
            // Smi.g:995:18: ( typeorvalue ( COMMA typeorvalue )* )
            // Smi.g:995:18: typeorvalue ( COMMA typeorvalue )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7515);
            	typeorvalue573 = typeorvalue();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue573.Tree);
            	// Smi.g:995:30: ( COMMA typeorvalue )*
            	do 
            	{
            	    int alt143 = 2;
            	    int LA143_0 = input.LA(1);

            	    if ( (LA143_0 == COMMA) )
            	    {
            	        alt143 = 1;
            	    }


            	    switch (alt143) 
            		{
            			case 1 :
            			    // Smi.g:995:31: COMMA typeorvalue
            			    {
            			    	COMMA574=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_typeorvaluelist7518); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA574_tree = (CommonTree)adaptor.Create(COMMA574);
            			    		adaptor.AddChild(root_0, COMMA574_tree);
            			    	}
            			    	PushFollow(FOLLOW_typeorvalue_in_typeorvaluelist7520);
            			    	typeorvalue575 = typeorvalue();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, typeorvalue575.Tree);

            			    }
            			    break;

            			default:
            			    goto loop143;
            	    }
            	} while (true);

            	loop143:
            		;	// Stops C# compiler whining that label 'loop143' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "typeorvaluelist"

    public class elementType_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "elementType"
    // Smi.g:998:0: elementType : ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type );
    public SmiParser.elementType_return elementType() // throws RecognitionException [1]
    {   
        SmiParser.elementType_return retval = new SmiParser.elementType_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER576 = null;
        IToken OPTIONAL_KW580 = null;
        IToken DEFAULT_KW581 = null;
        IToken COMPONENTS_KW583 = null;
        IToken OF_KW584 = null;
        SmiParser.tag_return tag577 = default(SmiParser.tag_return);

        SmiParser.tag_default_return tag_default578 = default(SmiParser.tag_default_return);

        SmiParser.type_return type579 = default(SmiParser.type_return);

        SmiParser.value_return value582 = default(SmiParser.value_return);

        SmiParser.type_return type585 = default(SmiParser.type_return);


        CommonTree LOWER576_tree=null;
        CommonTree OPTIONAL_KW580_tree=null;
        CommonTree DEFAULT_KW581_tree=null;
        CommonTree COMPONENTS_KW583_tree=null;
        CommonTree OF_KW584_tree=null;

        try 
    	{
            // Smi.g:998:14: ( LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )? | COMPONENTS_KW OF_KW type )
            int alt147 = 2;
            int LA147_0 = input.LA(1);

            if ( (LA147_0 == LOWER) )
            {
                alt147 = 1;
            }
            else if ( (LA147_0 == COMPONENTS_KW) )
            {
                alt147 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d147s0 =
                    new NoViableAltException("", 147, 0, input);

                throw nvae_d147s0;
            }
            switch (alt147) 
            {
                case 1 :
                    // Smi.g:998:14: LOWER (=> tag )? ( tag_default )? type ( OPTIONAL_KW | DEFAULT_KW value )?
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	LOWER576=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_elementType7532); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{LOWER576_tree = (CommonTree)adaptor.Create(LOWER576);
                    		adaptor.AddChild(root_0, LOWER576_tree);
                    	}
                    	// Smi.g:998:21: (=> tag )?
                    	int alt144 = 2;
                    	alt144 = dfa144.Predict(input);
                    	switch (alt144) 
                    	{
                    	    case 1 :
                    	        // Smi.g:998:22: => tag
                    	        {

                    	        	PushFollow(FOLLOW_tag_in_elementType7550);
                    	        	tag577 = tag();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag577.Tree);

                    	        }
                    	        break;

                    	}

                    	// Smi.g:999:21: ( tag_default )?
                    	int alt145 = 2;
                    	int LA145_0 = input.LA(1);

                    	if ( (LA145_0 == AUTOMATIC_KW || LA145_0 == EXPLICIT_KW || LA145_0 == IMPLICIT_KW) )
                    	{
                    	    alt145 = 1;
                    	}
                    	switch (alt145) 
                    	{
                    	    case 1 :
                    	        // Smi.g:999:22: tag_default
                    	        {
                    	        	PushFollow(FOLLOW_tag_default_in_elementType7576);
                    	        	tag_default578 = tag_default();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tag_default578.Tree);

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_elementType7580);
                    	type579 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type579.Tree);
                    	// Smi.g:999:41: ( OPTIONAL_KW | DEFAULT_KW value )?
                    	int alt146 = 3;
                    	int LA146_0 = input.LA(1);

                    	if ( (LA146_0 == OPTIONAL_KW) )
                    	{
                    	    alt146 = 1;
                    	}
                    	else if ( (LA146_0 == DEFAULT_KW) )
                    	{
                    	    alt146 = 2;
                    	}
                    	switch (alt146) 
                    	{
                    	    case 1 :
                    	        // Smi.g:999:42: OPTIONAL_KW
                    	        {
                    	        	OPTIONAL_KW580=(IToken)Match(input,OPTIONAL_KW,FOLLOW_OPTIONAL_KW_in_elementType7583); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{OPTIONAL_KW580_tree = (CommonTree)adaptor.Create(OPTIONAL_KW580);
                    	        		adaptor.AddChild(root_0, OPTIONAL_KW580_tree);
                    	        	}

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:999:56: DEFAULT_KW value
                    	        {
                    	        	DEFAULT_KW581=(IToken)Match(input,DEFAULT_KW,FOLLOW_DEFAULT_KW_in_elementType7587); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{DEFAULT_KW581_tree = (CommonTree)adaptor.Create(DEFAULT_KW581);
                    	        		adaptor.AddChild(root_0, DEFAULT_KW581_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_value_in_elementType7589);
                    	        	value582 = value();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value582.Tree);

                    	        }
                    	        break;

                    	}


                    }
                    break;
                case 2 :
                    // Smi.g:1000:14: COMPONENTS_KW OF_KW type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	COMPONENTS_KW583=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_elementType7607); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{COMPONENTS_KW583_tree = (CommonTree)adaptor.Create(COMPONENTS_KW583);
                    		adaptor.AddChild(root_0, COMPONENTS_KW583_tree);
                    	}
                    	OF_KW584=(IToken)Match(input,OF_KW,FOLLOW_OF_KW_in_elementType7609); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{OF_KW584_tree = (CommonTree)adaptor.Create(OF_KW584);
                    		adaptor.AddChild(root_0, OF_KW584_tree);
                    	}
                    	PushFollow(FOLLOW_type_in_elementType7611);
                    	type585 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type585.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "elementType"

    public class namedNumber_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "namedNumber"
    // Smi.g:1004:0: namedNumber : LOWER L_PAREN ( signed_number | defined_value ) R_PAREN ;
    public SmiParser.namedNumber_return namedNumber() // throws RecognitionException [1]
    {   
        SmiParser.namedNumber_return retval = new SmiParser.namedNumber_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER586 = null;
        IToken L_PAREN587 = null;
        IToken R_PAREN590 = null;
        SmiParser.signed_number_return signed_number588 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value589 = default(SmiParser.defined_value_return);


        CommonTree LOWER586_tree=null;
        CommonTree L_PAREN587_tree=null;
        CommonTree R_PAREN590_tree=null;

        try 
    	{
            // Smi.g:1004:14: ( LOWER L_PAREN ( signed_number | defined_value ) R_PAREN )
            // Smi.g:1004:14: LOWER L_PAREN ( signed_number | defined_value ) R_PAREN
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER586=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_namedNumber7620); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER586_tree = (CommonTree)adaptor.Create(LOWER586);
            		adaptor.AddChild(root_0, LOWER586_tree);
            	}
            	L_PAREN587=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_namedNumber7622); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_PAREN587_tree = (CommonTree)adaptor.Create(L_PAREN587);
            		adaptor.AddChild(root_0, L_PAREN587_tree);
            	}
            	// Smi.g:1004:28: ( signed_number | defined_value )
            	int alt148 = 2;
            	int LA148_0 = input.LA(1);

            	if ( (LA148_0 == MINUS || LA148_0 == NUMBER) )
            	{
            	    alt148 = 1;
            	}
            	else if ( (LA148_0 == LOWER || LA148_0 == UPPER) )
            	{
            	    alt148 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d148s0 =
            	        new NoViableAltException("", 148, 0, input);

            	    throw nvae_d148s0;
            	}
            	switch (alt148) 
            	{
            	    case 1 :
            	        // Smi.g:1004:29: signed_number
            	        {
            	        	PushFollow(FOLLOW_signed_number_in_namedNumber7625);
            	        	signed_number588 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number588.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1004:45: defined_value
            	        {
            	        	PushFollow(FOLLOW_defined_value_in_namedNumber7629);
            	        	defined_value589 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value589.Tree);

            	        }
            	        break;

            	}

            	R_PAREN590=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_namedNumber7632); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_PAREN590_tree = (CommonTree)adaptor.Create(R_PAREN590);
            		adaptor.AddChild(root_0, R_PAREN590_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "namedNumber"

    public class signed_number_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "signed_number"
    // Smi.g:1006:0: signed_number : ( MINUS )? NUMBER ;
    public SmiParser.signed_number_return signed_number() // throws RecognitionException [1]
    {   
        SmiParser.signed_number_return retval = new SmiParser.signed_number_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MINUS591 = null;
        IToken NUMBER592 = null;

        CommonTree MINUS591_tree=null;
        CommonTree NUMBER592_tree=null;

        try 
    	{
            // Smi.g:1006:16: ( ( MINUS )? NUMBER )
            // Smi.g:1006:16: ( MINUS )? NUMBER
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:1006:16: ( MINUS )?
            	int alt149 = 2;
            	int LA149_0 = input.LA(1);

            	if ( (LA149_0 == MINUS) )
            	{
            	    alt149 = 1;
            	}
            	switch (alt149) 
            	{
            	    case 1 :
            	        // Smi.g:1006:17: MINUS
            	        {
            	        	MINUS591=(IToken)Match(input,MINUS,FOLLOW_MINUS_in_signed_number7640); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MINUS591_tree = (CommonTree)adaptor.Create(MINUS591);
            	        		adaptor.AddChild(root_0, MINUS591_tree);
            	        	}

            	        }
            	        break;

            	}

            	NUMBER592=(IToken)Match(input,NUMBER,FOLLOW_NUMBER_in_signed_number7644); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{NUMBER592_tree = (CommonTree)adaptor.Create(NUMBER592);
            		adaptor.AddChild(root_0, NUMBER592_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "signed_number"

    public class element_set_specs_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "element_set_specs"
    // Smi.g:1008:0: element_set_specs : element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? ;
    public SmiParser.element_set_specs_return element_set_specs() // throws RecognitionException [1]
    {   
        SmiParser.element_set_specs_return retval = new SmiParser.element_set_specs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA594 = null;
        IToken DOTDOTDOT595 = null;
        IToken COMMA596 = null;
        SmiParser.element_set_spec_return element_set_spec593 = default(SmiParser.element_set_spec_return);

        SmiParser.element_set_spec_return element_set_spec597 = default(SmiParser.element_set_spec_return);


        CommonTree COMMA594_tree=null;
        CommonTree DOTDOTDOT595_tree=null;
        CommonTree COMMA596_tree=null;

        try 
    	{
            // Smi.g:1008:20: ( element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )? )
            // Smi.g:1008:20: element_set_spec ( COMMA DOTDOTDOT )? ( COMMA element_set_spec )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7651);
            	element_set_spec593 = element_set_spec();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec593.Tree);
            	// Smi.g:1008:37: ( COMMA DOTDOTDOT )?
            	int alt150 = 2;
            	int LA150_0 = input.LA(1);

            	if ( (LA150_0 == COMMA) )
            	{
            	    int LA150_1 = input.LA(2);

            	    if ( (LA150_1 == DOTDOTDOT) )
            	    {
            	        alt150 = 1;
            	    }
            	}
            	switch (alt150) 
            	{
            	    case 1 :
            	        // Smi.g:1008:38: COMMA DOTDOTDOT
            	        {
            	        	COMMA594=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7654); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA594_tree = (CommonTree)adaptor.Create(COMMA594);
            	        		adaptor.AddChild(root_0, COMMA594_tree);
            	        	}
            	        	DOTDOTDOT595=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_element_set_specs7656); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{DOTDOTDOT595_tree = (CommonTree)adaptor.Create(DOTDOTDOT595);
            	        		adaptor.AddChild(root_0, DOTDOTDOT595_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1008:56: ( COMMA element_set_spec )?
            	int alt151 = 2;
            	int LA151_0 = input.LA(1);

            	if ( (LA151_0 == COMMA) )
            	{
            	    alt151 = 1;
            	}
            	switch (alt151) 
            	{
            	    case 1 :
            	        // Smi.g:1008:57: COMMA element_set_spec
            	        {
            	        	COMMA596=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_element_set_specs7661); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA596_tree = (CommonTree)adaptor.Create(COMMA596);
            	        		adaptor.AddChild(root_0, COMMA596_tree);
            	        	}
            	        	PushFollow(FOLLOW_element_set_spec_in_element_set_specs7663);
            	        	element_set_spec597 = element_set_spec();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec597.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_specs"

    public class exception_spec_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "exception_spec"
    // Smi.g:1010:0: exception_spec : EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) ;
    public SmiParser.exception_spec_return exception_spec() // throws RecognitionException [1]
    {   
        SmiParser.exception_spec_return retval = new SmiParser.exception_spec_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXCLAMATION598 = null;
        IToken COLON602 = null;
        SmiParser.signed_number_return signed_number599 = default(SmiParser.signed_number_return);

        SmiParser.defined_value_return defined_value600 = default(SmiParser.defined_value_return);

        SmiParser.type_return type601 = default(SmiParser.type_return);

        SmiParser.value_return value603 = default(SmiParser.value_return);


        CommonTree EXCLAMATION598_tree=null;
        CommonTree COLON602_tree=null;

        try 
    	{
            // Smi.g:1010:17: ( EXCLAMATION (=> signed_number |=> defined_value | type COLON value ) )
            // Smi.g:1010:17: EXCLAMATION (=> signed_number |=> defined_value | type COLON value )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	EXCLAMATION598=(IToken)Match(input,EXCLAMATION,FOLLOW_EXCLAMATION_in_exception_spec7673); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{EXCLAMATION598_tree = (CommonTree)adaptor.Create(EXCLAMATION598);
            		adaptor.AddChild(root_0, EXCLAMATION598_tree);
            	}
            	// Smi.g:1011:17: (=> signed_number |=> defined_value | type COLON value )
            	int alt152 = 3;
            	int LA152_0 = input.LA(1);

            	if ( (LA152_0 == MINUS) && (synpred42_Smi()) )
            	{
            	    alt152 = 1;
            	}
            	else if ( (LA152_0 == NUMBER) && (synpred42_Smi()) )
            	{
            	    alt152 = 1;
            	}
            	else if ( (LA152_0 == UPPER) )
            	{
            	    int LA152_3 = input.LA(2);

            	    if ( (LA152_3 == DOT) )
            	    {
            	        int LA152_6 = input.LA(3);

            	        if ( (LA152_6 == LOWER) && (synpred43_Smi()) )
            	        {
            	            alt152 = 2;
            	        }
            	        else if ( (LA152_6 == UPPER) )
            	        {
            	            alt152 = 3;
            	        }
            	        else 
            	        {
            	            if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	            NoViableAltException nvae_d152s6 =
            	                new NoViableAltException("", 152, 6, input);

            	            throw nvae_d152s6;
            	        }
            	    }
            	    else if ( (LA152_3 == COLON || LA152_3 == L_PAREN) )
            	    {
            	        alt152 = 3;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d152s3 =
            	            new NoViableAltException("", 152, 3, input);

            	        throw nvae_d152s3;
            	    }
            	}
            	else if ( (LA152_0 == LOWER) )
            	{
            	    int LA152_4 = input.LA(2);

            	    if ( (LA152_4 == LESS) )
            	    {
            	        alt152 = 3;
            	    }
            	    else if ( (LA152_4 == R_PAREN) && (synpred43_Smi()) )
            	    {
            	        alt152 = 2;
            	    }
            	    else 
            	    {
            	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        NoViableAltException nvae_d152s4 =
            	            new NoViableAltException("", 152, 4, input);

            	        throw nvae_d152s4;
            	    }
            	}
            	else if ( (LA152_0 == ANY_KW || (LA152_0 >= BIT_KW && LA152_0 <= BOOLEAN_KW) || LA152_0 == CHARACTER_KW || LA152_0 == CHOICE_KW || LA152_0 == EMBEDDED_KW || (LA152_0 >= ENUMERATED_KW && LA152_0 <= ERROR_KW) || LA152_0 == EXTERNAL_KW || (LA152_0 >= GENERAL_STR_KW && LA152_0 <= GRAPHIC_STR_KW) || LA152_0 == IA5_STRING_KW || LA152_0 == INTEGER_KW || LA152_0 == ISO646_STR_KW || LA152_0 == L_BRACKET || LA152_0 == NULL_KW || LA152_0 == NUMERIC_STR_KW || (LA152_0 >= OBJECT_KW && LA152_0 <= OCTET_KW) || LA152_0 == OPERATION_KW || LA152_0 == PRINTABLE_STR_KW || LA152_0 == REAL_KW || (LA152_0 >= SEQUENCE_KW && LA152_0 <= SET_KW) || LA152_0 == T61_STR_KW || LA152_0 == TELETEX_STR_KW || LA152_0 == UNIVERSAL_STR_KW || (LA152_0 >= UTC_TIME_KW && LA152_0 <= VISIBLE_STR_KW) || LA152_0 == 131 || LA152_0 == 137 || (LA152_0 >= 158 && LA152_0 <= 160) || (LA152_0 >= 162 && LA152_0 <= 164) || LA152_0 == 166 || LA152_0 == 179 || LA152_0 == 188 || LA152_0 == 191) )
            	{
            	    alt152 = 3;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d152s0 =
            	        new NoViableAltException("", 152, 0, input);

            	    throw nvae_d152s0;
            	}
            	switch (alt152) 
            	{
            	    case 1 :
            	        // Smi.g:1011:19: => signed_number
            	        {

            	        	PushFollow(FOLLOW_signed_number_in_exception_spec7700);
            	        	signed_number599 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number599.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1012:21: => defined_value
            	        {

            	        	PushFollow(FOLLOW_defined_value_in_exception_spec7729);
            	        	defined_value600 = defined_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value600.Tree);

            	        }
            	        break;
            	    case 3 :
            	        // Smi.g:1013:21: type COLON value
            	        {
            	        	PushFollow(FOLLOW_type_in_exception_spec7752);
            	        	type601 = type();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type601.Tree);
            	        	COLON602=(IToken)Match(input,COLON,FOLLOW_COLON_in_exception_spec7754); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON602_tree = (CommonTree)adaptor.Create(COLON602);
            	        		adaptor.AddChild(root_0, COLON602_tree);
            	        	}
            	        	PushFollow(FOLLOW_value_in_exception_spec7756);
            	        	value603 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value603.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "exception_spec"

    public class element_set_spec_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "element_set_spec"
    // Smi.g:1016:0: element_set_spec : ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements );
    public SmiParser.element_set_spec_return element_set_spec() // throws RecognitionException [1]
    {   
        SmiParser.element_set_spec_return retval = new SmiParser.element_set_spec_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken set605 = null;
        IToken ALL_KW607 = null;
        IToken EXCEPT_KW608 = null;
        SmiParser.intersections_return intersections604 = default(SmiParser.intersections_return);

        SmiParser.intersections_return intersections606 = default(SmiParser.intersections_return);

        SmiParser.constraint_elements_return constraint_elements609 = default(SmiParser.constraint_elements_return);


        CommonTree set605_tree=null;
        CommonTree ALL_KW607_tree=null;
        CommonTree EXCEPT_KW608_tree=null;

        try 
    	{
            // Smi.g:1016:19: ( intersections ( ( BAR | UNION_KW ) intersections )* | ALL_KW EXCEPT_KW constraint_elements )
            int alt154 = 2;
            int LA154_0 = input.LA(1);

            if ( (LA154_0 == ANY_KW || LA154_0 == B_STRING || (LA154_0 >= BIT_KW && LA154_0 <= BOOLEAN_KW) || (LA154_0 >= C_STRING && LA154_0 <= CHARACTER_KW) || LA154_0 == CHOICE_KW || LA154_0 == EMBEDDED_KW || (LA154_0 >= ENUMERATED_KW && LA154_0 <= ERROR_KW) || (LA154_0 >= EXTERNAL_KW && LA154_0 <= H_STRING) || LA154_0 == IA5_STRING_KW || LA154_0 == INCLUDES_KW || LA154_0 == INTEGER_KW || (LA154_0 >= ISO646_STR_KW && LA154_0 <= L_PAREN) || LA154_0 == LOWER || (LA154_0 >= MIN_KW && LA154_0 <= NUMERIC_STR_KW) || (LA154_0 >= OBJECT_KW && LA154_0 <= OCTET_KW) || LA154_0 == OPERATION_KW || LA154_0 == PATTERN_KW || LA154_0 == PLUS_INFINITY_KW || LA154_0 == PRINTABLE_STR_KW || LA154_0 == REAL_KW || (LA154_0 >= SEQUENCE_KW && LA154_0 <= SET_KW) || LA154_0 == SIZE_KW || LA154_0 == T61_STR_KW || (LA154_0 >= TELETEX_STR_KW && LA154_0 <= TRUE_KW) || (LA154_0 >= UNIVERSAL_STR_KW && LA154_0 <= WITH_KW) || LA154_0 == 131 || LA154_0 == 137 || (LA154_0 >= 158 && LA154_0 <= 160) || (LA154_0 >= 162 && LA154_0 <= 164) || LA154_0 == 166 || LA154_0 == 179 || LA154_0 == 188 || LA154_0 == 191) )
            {
                alt154 = 1;
            }
            else if ( (LA154_0 == ALL_KW) )
            {
                alt154 = 2;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d154s0 =
                    new NoViableAltException("", 154, 0, input);

                throw nvae_d154s0;
            }
            switch (alt154) 
            {
                case 1 :
                    // Smi.g:1016:19: intersections ( ( BAR | UNION_KW ) intersections )*
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_intersections_in_element_set_spec7781);
                    	intersections604 = intersections();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections604.Tree);
                    	// Smi.g:1016:33: ( ( BAR | UNION_KW ) intersections )*
                    	do 
                    	{
                    	    int alt153 = 2;
                    	    int LA153_0 = input.LA(1);

                    	    if ( (LA153_0 == BAR || LA153_0 == UNION_KW) )
                    	    {
                    	        alt153 = 1;
                    	    }


                    	    switch (alt153) 
                    		{
                    			case 1 :
                    			    // Smi.g:1016:35: ( BAR | UNION_KW ) intersections
                    			    {
                    			    	set605 = (IToken)input.LT(1);
                    			    	if ( input.LA(1) == BAR || input.LA(1) == UNION_KW ) 
                    			    	{
                    			    	    input.Consume();
                    			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set605));
                    			    	    state.errorRecovery = false;state.failed = false;
                    			    	}
                    			    	else 
                    			    	{
                    			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
                    			    	    throw mse;
                    			    	}

                    			    	PushFollow(FOLLOW_intersections_in_element_set_spec7793);
                    			    	intersections606 = intersections();
                    			    	state.followingStackPointer--;
                    			    	if (state.failed) return retval;
                    			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, intersections606.Tree);

                    			    }
                    			    break;

                    			default:
                    			    goto loop153;
                    	    }
                    	} while (true);

                    	loop153:
                    		;	// Stops C# compiler whining that label 'loop153' has no statements


                    }
                    break;
                case 2 :
                    // Smi.g:1017:19: ALL_KW EXCEPT_KW constraint_elements
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	ALL_KW607=(IToken)Match(input,ALL_KW,FOLLOW_ALL_KW_in_element_set_spec7817); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{ALL_KW607_tree = (CommonTree)adaptor.Create(ALL_KW607);
                    		adaptor.AddChild(root_0, ALL_KW607_tree);
                    	}
                    	EXCEPT_KW608=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_element_set_spec7819); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{EXCEPT_KW608_tree = (CommonTree)adaptor.Create(EXCEPT_KW608);
                    		adaptor.AddChild(root_0, EXCEPT_KW608_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_elements_in_element_set_spec7821);
                    	constraint_elements609 = constraint_elements();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements609.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "element_set_spec"

    public class intersections_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "intersections"
    // Smi.g:1019:0: intersections : constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* ;
    public SmiParser.intersections_return intersections() // throws RecognitionException [1]
    {   
        SmiParser.intersections_return retval = new SmiParser.intersections_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken EXCEPT_KW611 = null;
        IToken set613 = null;
        IToken EXCEPT_KW615 = null;
        SmiParser.constraint_elements_return constraint_elements610 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements612 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements614 = default(SmiParser.constraint_elements_return);

        SmiParser.constraint_elements_return constraint_elements616 = default(SmiParser.constraint_elements_return);


        CommonTree EXCEPT_KW611_tree=null;
        CommonTree set613_tree=null;
        CommonTree EXCEPT_KW615_tree=null;

        try 
    	{
            // Smi.g:1019:16: ( constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )* )
            // Smi.g:1019:16: constraint_elements ( EXCEPT_KW constraint_elements )? ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_constraint_elements_in_intersections7828);
            	constraint_elements610 = constraint_elements();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements610.Tree);
            	// Smi.g:1019:36: ( EXCEPT_KW constraint_elements )?
            	int alt155 = 2;
            	int LA155_0 = input.LA(1);

            	if ( (LA155_0 == EXCEPT_KW) )
            	{
            	    alt155 = 1;
            	}
            	switch (alt155) 
            	{
            	    case 1 :
            	        // Smi.g:1019:37: EXCEPT_KW constraint_elements
            	        {
            	        	EXCEPT_KW611=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7831); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{EXCEPT_KW611_tree = (CommonTree)adaptor.Create(EXCEPT_KW611);
            	        		adaptor.AddChild(root_0, EXCEPT_KW611_tree);
            	        	}
            	        	PushFollow(FOLLOW_constraint_elements_in_intersections7833);
            	        	constraint_elements612 = constraint_elements();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements612.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1020:17: ( ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )? )*
            	do 
            	{
            	    int alt157 = 2;
            	    int LA157_0 = input.LA(1);

            	    if ( ((LA157_0 >= INTERSECTION && LA157_0 <= INTERSECTION_KW)) )
            	    {
            	        alt157 = 1;
            	    }


            	    switch (alt157) 
            		{
            			case 1 :
            			    // Smi.g:1020:19: ( INTERSECTION | INTERSECTION_KW ) constraint_elements ( EXCEPT_KW constraint_elements )?
            			    {
            			    	set613 = (IToken)input.LT(1);
            			    	if ( (input.LA(1) >= INTERSECTION && input.LA(1) <= INTERSECTION_KW) ) 
            			    	{
            			    	    input.Consume();
            			    	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set613));
            			    	    state.errorRecovery = false;state.failed = false;
            			    	}
            			    	else 
            			    	{
            			    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            			    	    MismatchedSetException mse = new MismatchedSetException(null,input);
            			    	    throw mse;
            			    	}

            			    	PushFollow(FOLLOW_constraint_elements_in_intersections7864);
            			    	constraint_elements614 = constraint_elements();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements614.Tree);
            			    	// Smi.g:1020:72: ( EXCEPT_KW constraint_elements )?
            			    	int alt156 = 2;
            			    	int LA156_0 = input.LA(1);

            			    	if ( (LA156_0 == EXCEPT_KW) )
            			    	{
            			    	    alt156 = 1;
            			    	}
            			    	switch (alt156) 
            			    	{
            			    	    case 1 :
            			    	        // Smi.g:1020:73: EXCEPT_KW constraint_elements
            			    	        {
            			    	        	EXCEPT_KW615=(IToken)Match(input,EXCEPT_KW,FOLLOW_EXCEPT_KW_in_intersections7867); if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 )
            			    	        	{EXCEPT_KW615_tree = (CommonTree)adaptor.Create(EXCEPT_KW615);
            			    	        		adaptor.AddChild(root_0, EXCEPT_KW615_tree);
            			    	        	}
            			    	        	PushFollow(FOLLOW_constraint_elements_in_intersections7869);
            			    	        	constraint_elements616 = constraint_elements();
            			    	        	state.followingStackPointer--;
            			    	        	if (state.failed) return retval;
            			    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint_elements616.Tree);

            			    	        }
            			    	        break;

            			    	}


            			    }
            			    break;

            			default:
            			    goto loop157;
            	    }
            	} while (true);

            	loop157:
            		;	// Stops C# compiler whining that label 'loop157' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "intersections"

    public class constraint_elements_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "constraint_elements"
    // Smi.g:1022:0: constraint_elements : (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );
    public SmiParser.constraint_elements_return constraint_elements() // throws RecognitionException [1]
    {   
        SmiParser.constraint_elements_return retval = new SmiParser.constraint_elements_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken SIZE_KW619 = null;
        IToken FROM_KW621 = null;
        IToken L_PAREN623 = null;
        IToken R_PAREN625 = null;
        IToken INCLUDES_KW626 = null;
        IToken PATTERN_KW628 = null;
        IToken WITH_KW630 = null;
        IToken COMPONENT_KW631 = null;
        IToken COMPONENTS_KW633 = null;
        IToken L_BRACE634 = null;
        IToken DOTDOTDOT635 = null;
        IToken COMMA636 = null;
        IToken R_BRACE638 = null;
        SmiParser.value_return value617 = default(SmiParser.value_return);

        SmiParser.value_range_return value_range618 = default(SmiParser.value_range_return);

        SmiParser.constraint_return constraint620 = default(SmiParser.constraint_return);

        SmiParser.constraint_return constraint622 = default(SmiParser.constraint_return);

        SmiParser.element_set_spec_return element_set_spec624 = default(SmiParser.element_set_spec_return);

        SmiParser.type_return type627 = default(SmiParser.type_return);

        SmiParser.value_return value629 = default(SmiParser.value_return);

        SmiParser.constraint_return constraint632 = default(SmiParser.constraint_return);

        SmiParser.type_constraint_list_return type_constraint_list637 = default(SmiParser.type_constraint_list_return);


        CommonTree SIZE_KW619_tree=null;
        CommonTree FROM_KW621_tree=null;
        CommonTree L_PAREN623_tree=null;
        CommonTree R_PAREN625_tree=null;
        CommonTree INCLUDES_KW626_tree=null;
        CommonTree PATTERN_KW628_tree=null;
        CommonTree WITH_KW630_tree=null;
        CommonTree COMPONENT_KW631_tree=null;
        CommonTree COMPONENTS_KW633_tree=null;
        CommonTree L_BRACE634_tree=null;
        CommonTree DOTDOTDOT635_tree=null;
        CommonTree COMMA636_tree=null;
        CommonTree R_BRACE638_tree=null;

        try 
    	{
            // Smi.g:1022:22: (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) )
            int alt161 = 8;
            alt161 = dfa161.Predict(input);
            switch (alt161) 
            {
                case 1 :
                    // Smi.g:1022:22: => value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_in_constraint_elements7888);
                    	value617 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value617.Tree);

                    }
                    break;
                case 2 :
                    // Smi.g:1023:22: => value_range
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	PushFollow(FOLLOW_value_range_in_constraint_elements7918);
                    	value_range618 = value_range();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value_range618.Tree);

                    }
                    break;
                case 3 :
                    // Smi.g:1024:22: SIZE_KW constraint
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	SIZE_KW619=(IToken)Match(input,SIZE_KW,FOLLOW_SIZE_KW_in_constraint_elements7941); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{SIZE_KW619_tree = (CommonTree)adaptor.Create(SIZE_KW619);
                    		adaptor.AddChild(root_0, SIZE_KW619_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7943);
                    	constraint620 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint620.Tree);

                    }
                    break;
                case 4 :
                    // Smi.g:1025:22: FROM_KW constraint
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	FROM_KW621=(IToken)Match(input,FROM_KW,FOLLOW_FROM_KW_in_constraint_elements7967); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{FROM_KW621_tree = (CommonTree)adaptor.Create(FROM_KW621);
                    		adaptor.AddChild(root_0, FROM_KW621_tree);
                    	}
                    	PushFollow(FOLLOW_constraint_in_constraint_elements7969);
                    	constraint622 = constraint();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint622.Tree);

                    }
                    break;
                case 5 :
                    // Smi.g:1026:22: L_PAREN element_set_spec R_PAREN
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_PAREN623=(IToken)Match(input,L_PAREN,FOLLOW_L_PAREN_in_constraint_elements7993); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_PAREN623_tree = (CommonTree)adaptor.Create(L_PAREN623);
                    		adaptor.AddChild(root_0, L_PAREN623_tree);
                    	}
                    	PushFollow(FOLLOW_element_set_spec_in_constraint_elements7995);
                    	element_set_spec624 = element_set_spec();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, element_set_spec624.Tree);
                    	R_PAREN625=(IToken)Match(input,R_PAREN,FOLLOW_R_PAREN_in_constraint_elements7997); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_PAREN625_tree = (CommonTree)adaptor.Create(R_PAREN625);
                    		adaptor.AddChild(root_0, R_PAREN625_tree);
                    	}

                    }
                    break;
                case 6 :
                    // Smi.g:1027:22: ( INCLUDES_KW )? type
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	// Smi.g:1027:22: ( INCLUDES_KW )?
                    	int alt158 = 2;
                    	int LA158_0 = input.LA(1);

                    	if ( (LA158_0 == INCLUDES_KW) )
                    	{
                    	    alt158 = 1;
                    	}
                    	switch (alt158) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1027:23: INCLUDES_KW
                    	        {
                    	        	INCLUDES_KW626=(IToken)Match(input,INCLUDES_KW,FOLLOW_INCLUDES_KW_in_constraint_elements8022); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{INCLUDES_KW626_tree = (CommonTree)adaptor.Create(INCLUDES_KW626);
                    	        		adaptor.AddChild(root_0, INCLUDES_KW626_tree);
                    	        	}

                    	        }
                    	        break;

                    	}

                    	PushFollow(FOLLOW_type_in_constraint_elements8026);
                    	type627 = type();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type627.Tree);

                    }
                    break;
                case 7 :
                    // Smi.g:1028:22: PATTERN_KW value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PATTERN_KW628=(IToken)Match(input,PATTERN_KW,FOLLOW_PATTERN_KW_in_constraint_elements8050); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{PATTERN_KW628_tree = (CommonTree)adaptor.Create(PATTERN_KW628);
                    		adaptor.AddChild(root_0, PATTERN_KW628_tree);
                    	}
                    	PushFollow(FOLLOW_value_in_constraint_elements8052);
                    	value629 = value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value629.Tree);

                    }
                    break;
                case 8 :
                    // Smi.g:1029:22: WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	WITH_KW630=(IToken)Match(input,WITH_KW,FOLLOW_WITH_KW_in_constraint_elements8076); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{WITH_KW630_tree = (CommonTree)adaptor.Create(WITH_KW630);
                    		adaptor.AddChild(root_0, WITH_KW630_tree);
                    	}
                    	// Smi.g:1029:30: ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE )
                    	int alt160 = 2;
                    	int LA160_0 = input.LA(1);

                    	if ( (LA160_0 == COMPONENT_KW) )
                    	{
                    	    alt160 = 1;
                    	}
                    	else if ( (LA160_0 == COMPONENTS_KW) )
                    	{
                    	    alt160 = 2;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d160s0 =
                    	        new NoViableAltException("", 160, 0, input);

                    	    throw nvae_d160s0;
                    	}
                    	switch (alt160) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1029:31: COMPONENT_KW constraint
                    	        {
                    	        	COMPONENT_KW631=(IToken)Match(input,COMPONENT_KW,FOLLOW_COMPONENT_KW_in_constraint_elements8079); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENT_KW631_tree = (CommonTree)adaptor.Create(COMPONENT_KW631);
                    	        		adaptor.AddChild(root_0, COMPONENT_KW631_tree);
                    	        	}
                    	        	PushFollow(FOLLOW_constraint_in_constraint_elements8081);
                    	        	constraint632 = constraint();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint632.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1030:33: COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE
                    	        {
                    	        	COMPONENTS_KW633=(IToken)Match(input,COMPONENTS_KW,FOLLOW_COMPONENTS_KW_in_constraint_elements8116); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{COMPONENTS_KW633_tree = (CommonTree)adaptor.Create(COMPONENTS_KW633);
                    	        		adaptor.AddChild(root_0, COMPONENTS_KW633_tree);
                    	        	}
                    	        	L_BRACE634=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_constraint_elements8118); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{L_BRACE634_tree = (CommonTree)adaptor.Create(L_BRACE634);
                    	        		adaptor.AddChild(root_0, L_BRACE634_tree);
                    	        	}
                    	        	// Smi.g:1030:55: ( DOTDOTDOT COMMA )?
                    	        	int alt159 = 2;
                    	        	int LA159_0 = input.LA(1);

                    	        	if ( (LA159_0 == DOTDOTDOT) )
                    	        	{
                    	        	    alt159 = 1;
                    	        	}
                    	        	switch (alt159) 
                    	        	{
                    	        	    case 1 :
                    	        	        // Smi.g:1030:56: DOTDOTDOT COMMA
                    	        	        {
                    	        	        	DOTDOTDOT635=(IToken)Match(input,DOTDOTDOT,FOLLOW_DOTDOTDOT_in_constraint_elements8121); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{DOTDOTDOT635_tree = (CommonTree)adaptor.Create(DOTDOTDOT635);
                    	        	        		adaptor.AddChild(root_0, DOTDOTDOT635_tree);
                    	        	        	}
                    	        	        	COMMA636=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_constraint_elements8123); if (state.failed) return retval;
                    	        	        	if ( state.backtracking == 0 )
                    	        	        	{COMMA636_tree = (CommonTree)adaptor.Create(COMMA636);
                    	        	        		adaptor.AddChild(root_0, COMMA636_tree);
                    	        	        	}

                    	        	        }
                    	        	        break;

                    	        	}

                    	        	PushFollow(FOLLOW_type_constraint_list_in_constraint_elements8160);
                    	        	type_constraint_list637 = type_constraint_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, type_constraint_list637.Tree);
                    	        	R_BRACE638=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_constraint_elements8162); if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 )
                    	        	{R_BRACE638_tree = (CommonTree)adaptor.Create(R_BRACE638);
                    	        		adaptor.AddChild(root_0, R_BRACE638_tree);
                    	        	}

                    	        }
                    	        break;

                    	}


                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "constraint_elements"

    public class value_range_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "value_range"
    // Smi.g:1033:0: value_range : ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) ;
    public SmiParser.value_range_return value_range() // throws RecognitionException [1]
    {   
        SmiParser.value_range_return retval = new SmiParser.value_range_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken MIN_KW640 = null;
        IToken LESS641 = null;
        IToken DOTDOT642 = null;
        IToken LESS643 = null;
        IToken MAX_KW645 = null;
        SmiParser.value_return value639 = default(SmiParser.value_return);

        SmiParser.value_return value644 = default(SmiParser.value_return);


        CommonTree MIN_KW640_tree=null;
        CommonTree LESS641_tree=null;
        CommonTree DOTDOT642_tree=null;
        CommonTree LESS643_tree=null;
        CommonTree MAX_KW645_tree=null;

        try 
    	{
            // Smi.g:1033:14: ( ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW ) )
            // Smi.g:1033:14: ( value | MIN_KW ) ( LESS )? DOTDOT ( LESS )? ( value | MAX_KW )
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	// Smi.g:1033:14: ( value | MIN_KW )
            	int alt162 = 2;
            	int LA162_0 = input.LA(1);

            	if ( (LA162_0 == B_STRING || LA162_0 == C_STRING || LA162_0 == FALSE_KW || LA162_0 == H_STRING || LA162_0 == L_BRACE || LA162_0 == LOWER || (LA162_0 >= MINUS && LA162_0 <= NUMBER) || LA162_0 == PLUS_INFINITY_KW || LA162_0 == TRUE_KW || LA162_0 == UPPER) )
            	{
            	    alt162 = 1;
            	}
            	else if ( (LA162_0 == MIN_KW) )
            	{
            	    alt162 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d162s0 =
            	        new NoViableAltException("", 162, 0, input);

            	    throw nvae_d162s0;
            	}
            	switch (alt162) 
            	{
            	    case 1 :
            	        // Smi.g:1033:15: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8171);
            	        	value639 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value639.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1033:23: MIN_KW
            	        {
            	        	MIN_KW640=(IToken)Match(input,MIN_KW,FOLLOW_MIN_KW_in_value_range8175); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MIN_KW640_tree = (CommonTree)adaptor.Create(MIN_KW640);
            	        		adaptor.AddChild(root_0, MIN_KW640_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1033:31: ( LESS )?
            	int alt163 = 2;
            	int LA163_0 = input.LA(1);

            	if ( (LA163_0 == LESS) )
            	{
            	    alt163 = 1;
            	}
            	switch (alt163) 
            	{
            	    case 1 :
            	        // Smi.g:1033:32: LESS
            	        {
            	        	LESS641=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8179); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS641_tree = (CommonTree)adaptor.Create(LESS641);
            	        		adaptor.AddChild(root_0, LESS641_tree);
            	        	}

            	        }
            	        break;

            	}

            	DOTDOT642=(IToken)Match(input,DOTDOT,FOLLOW_DOTDOT_in_value_range8183); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{DOTDOT642_tree = (CommonTree)adaptor.Create(DOTDOT642);
            		adaptor.AddChild(root_0, DOTDOT642_tree);
            	}
            	// Smi.g:1033:46: ( LESS )?
            	int alt164 = 2;
            	int LA164_0 = input.LA(1);

            	if ( (LA164_0 == LESS) )
            	{
            	    alt164 = 1;
            	}
            	switch (alt164) 
            	{
            	    case 1 :
            	        // Smi.g:1033:47: LESS
            	        {
            	        	LESS643=(IToken)Match(input,LESS,FOLLOW_LESS_in_value_range8186); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{LESS643_tree = (CommonTree)adaptor.Create(LESS643);
            	        		adaptor.AddChild(root_0, LESS643_tree);
            	        	}

            	        }
            	        break;

            	}

            	// Smi.g:1033:54: ( value | MAX_KW )
            	int alt165 = 2;
            	int LA165_0 = input.LA(1);

            	if ( (LA165_0 == B_STRING || LA165_0 == C_STRING || LA165_0 == FALSE_KW || LA165_0 == H_STRING || LA165_0 == L_BRACE || LA165_0 == LOWER || (LA165_0 >= MINUS && LA165_0 <= NUMBER) || LA165_0 == PLUS_INFINITY_KW || LA165_0 == TRUE_KW || LA165_0 == UPPER) )
            	{
            	    alt165 = 1;
            	}
            	else if ( (LA165_0 == MAX_KW) )
            	{
            	    alt165 = 2;
            	}
            	else 
            	{
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d165s0 =
            	        new NoViableAltException("", 165, 0, input);

            	    throw nvae_d165s0;
            	}
            	switch (alt165) 
            	{
            	    case 1 :
            	        // Smi.g:1033:55: value
            	        {
            	        	PushFollow(FOLLOW_value_in_value_range8191);
            	        	value644 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value644.Tree);

            	        }
            	        break;
            	    case 2 :
            	        // Smi.g:1033:63: MAX_KW
            	        {
            	        	MAX_KW645=(IToken)Match(input,MAX_KW,FOLLOW_MAX_KW_in_value_range8195); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{MAX_KW645_tree = (CommonTree)adaptor.Create(MAX_KW645);
            	        		adaptor.AddChild(root_0, MAX_KW645_tree);
            	        	}

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "value_range"

    public class type_constraint_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "type_constraint_list"
    // Smi.g:1035:0: type_constraint_list : named_constraint ( COMMA named_constraint )* ;
    public SmiParser.type_constraint_list_return type_constraint_list() // throws RecognitionException [1]
    {   
        SmiParser.type_constraint_list_return retval = new SmiParser.type_constraint_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA647 = null;
        SmiParser.named_constraint_return named_constraint646 = default(SmiParser.named_constraint_return);

        SmiParser.named_constraint_return named_constraint648 = default(SmiParser.named_constraint_return);


        CommonTree COMMA647_tree=null;

        try 
    	{
            // Smi.g:1035:23: ( named_constraint ( COMMA named_constraint )* )
            // Smi.g:1035:23: named_constraint ( COMMA named_constraint )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8204);
            	named_constraint646 = named_constraint();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint646.Tree);
            	// Smi.g:1035:40: ( COMMA named_constraint )*
            	do 
            	{
            	    int alt166 = 2;
            	    int LA166_0 = input.LA(1);

            	    if ( (LA166_0 == COMMA) )
            	    {
            	        alt166 = 1;
            	    }


            	    switch (alt166) 
            		{
            			case 1 :
            			    // Smi.g:1035:41: COMMA named_constraint
            			    {
            			    	COMMA647=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_type_constraint_list8207); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA647_tree = (CommonTree)adaptor.Create(COMMA647);
            			    		adaptor.AddChild(root_0, COMMA647_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_constraint_in_type_constraint_list8209);
            			    	named_constraint648 = named_constraint();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_constraint648.Tree);

            			    }
            			    break;

            			default:
            			    goto loop166;
            	    }
            	} while (true);

            	loop166:
            		;	// Stops C# compiler whining that label 'loop166' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "type_constraint_list"

    public class named_constraint_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "named_constraint"
    // Smi.g:1037:0: named_constraint : LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? ;
    public SmiParser.named_constraint_return named_constraint() // throws RecognitionException [1]
    {   
        SmiParser.named_constraint_return retval = new SmiParser.named_constraint_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER649 = null;
        IToken set651 = null;
        SmiParser.constraint_return constraint650 = default(SmiParser.constraint_return);


        CommonTree LOWER649_tree=null;
        CommonTree set651_tree=null;

        try 
    	{
            // Smi.g:1037:19: ( LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )? )
            // Smi.g:1037:19: LOWER ( constraint )? ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER649=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_constraint8219); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER649_tree = (CommonTree)adaptor.Create(LOWER649);
            		adaptor.AddChild(root_0, LOWER649_tree);
            	}
            	// Smi.g:1037:25: ( constraint )?
            	int alt167 = 2;
            	int LA167_0 = input.LA(1);

            	if ( (LA167_0 == L_PAREN) )
            	{
            	    alt167 = 1;
            	}
            	switch (alt167) 
            	{
            	    case 1 :
            	        // Smi.g:1037:26: constraint
            	        {
            	        	PushFollow(FOLLOW_constraint_in_named_constraint8222);
            	        	constraint650 = constraint();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, constraint650.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1037:39: ( PRESENT_KW | ABSENT_KW | OPTIONAL_KW )?
            	int alt168 = 2;
            	int LA168_0 = input.LA(1);

            	if ( (LA168_0 == ABSENT_KW || LA168_0 == OPTIONAL_KW || LA168_0 == PRESENT_KW) )
            	{
            	    alt168 = 1;
            	}
            	switch (alt168) 
            	{
            	    case 1 :
            	        // Smi.g:
            	        {
            	        	set651 = (IToken)input.LT(1);
            	        	if ( input.LA(1) == ABSENT_KW || input.LA(1) == OPTIONAL_KW || input.LA(1) == PRESENT_KW ) 
            	        	{
            	        	    input.Consume();
            	        	    if ( state.backtracking == 0 ) adaptor.AddChild(root_0, (CommonTree)adaptor.Create(set651));
            	        	    state.errorRecovery = false;state.failed = false;
            	        	}
            	        	else 
            	        	{
            	        	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	        	    MismatchedSetException mse = new MismatchedSetException(null,input);
            	        	    throw mse;
            	        	}


            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_constraint"

    public class choice_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "choice_value"
    // Smi.g:1039:0: choice_value : LOWER ( COLON )? value ;
    public SmiParser.choice_value_return choice_value() // throws RecognitionException [1]
    {   
        SmiParser.choice_value_return retval = new SmiParser.choice_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER652 = null;
        IToken COLON653 = null;
        SmiParser.value_return value654 = default(SmiParser.value_return);


        CommonTree LOWER652_tree=null;
        CommonTree COLON653_tree=null;

        try 
    	{
            // Smi.g:1039:15: ( LOWER ( COLON )? value )
            // Smi.g:1039:15: LOWER ( COLON )? value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER652=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_choice_value8245); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER652_tree = (CommonTree)adaptor.Create(LOWER652);
            		adaptor.AddChild(root_0, LOWER652_tree);
            	}
            	// Smi.g:1039:21: ( COLON )?
            	int alt169 = 2;
            	int LA169_0 = input.LA(1);

            	if ( (LA169_0 == COLON) )
            	{
            	    alt169 = 1;
            	}
            	switch (alt169) 
            	{
            	    case 1 :
            	        // Smi.g:1039:22: COLON
            	        {
            	        	COLON653=(IToken)Match(input,COLON,FOLLOW_COLON_in_choice_value8248); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COLON653_tree = (CommonTree)adaptor.Create(COLON653);
            	        		adaptor.AddChild(root_0, COLON653_tree);
            	        	}

            	        }
            	        break;

            	}

            	PushFollow(FOLLOW_value_in_choice_value8252);
            	value654 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value654.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "choice_value"

    public class sequence_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequence_value"
    // Smi.g:1041:0: sequence_value : L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE ;
    public SmiParser.sequence_value_return sequence_value() // throws RecognitionException [1]
    {   
        SmiParser.sequence_value_return retval = new SmiParser.sequence_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE655 = null;
        IToken COMMA657 = null;
        IToken R_BRACE659 = null;
        SmiParser.named_value_return named_value656 = default(SmiParser.named_value_return);

        SmiParser.named_value_return named_value658 = default(SmiParser.named_value_return);


        CommonTree L_BRACE655_tree=null;
        CommonTree COMMA657_tree=null;
        CommonTree R_BRACE659_tree=null;

        try 
    	{
            // Smi.g:1041:17: ( L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE )
            // Smi.g:1041:17: L_BRACE ( named_value )? ( COMMA named_value )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE655=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequence_value8259); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE655_tree = (CommonTree)adaptor.Create(L_BRACE655);
            		adaptor.AddChild(root_0, L_BRACE655_tree);
            	}
            	// Smi.g:1041:25: ( named_value )?
            	int alt170 = 2;
            	int LA170_0 = input.LA(1);

            	if ( (LA170_0 == LOWER) )
            	{
            	    alt170 = 1;
            	}
            	switch (alt170) 
            	{
            	    case 1 :
            	        // Smi.g:1041:26: named_value
            	        {
            	        	PushFollow(FOLLOW_named_value_in_sequence_value8262);
            	        	named_value656 = named_value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value656.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1041:40: ( COMMA named_value )*
            	do 
            	{
            	    int alt171 = 2;
            	    int LA171_0 = input.LA(1);

            	    if ( (LA171_0 == COMMA) )
            	    {
            	        alt171 = 1;
            	    }


            	    switch (alt171) 
            		{
            			case 1 :
            			    // Smi.g:1041:41: COMMA named_value
            			    {
            			    	COMMA657=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequence_value8267); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA657_tree = (CommonTree)adaptor.Create(COMMA657);
            			    		adaptor.AddChild(root_0, COMMA657_tree);
            			    	}
            			    	PushFollow(FOLLOW_named_value_in_sequence_value8269);
            			    	named_value658 = named_value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, named_value658.Tree);

            			    }
            			    break;

            			default:
            			    goto loop171;
            	    }
            	} while (true);

            	loop171:
            		;	// Stops C# compiler whining that label 'loop171' has no statements

            	R_BRACE659=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequence_value8273); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE659_tree = (CommonTree)adaptor.Create(R_BRACE659);
            		adaptor.AddChild(root_0, R_BRACE659_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequence_value"

    public class sequenceof_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "sequenceof_value"
    // Smi.g:1043:0: sequenceof_value : L_BRACE ( value )? ( COMMA value )* R_BRACE ;
    public SmiParser.sequenceof_value_return sequenceof_value() // throws RecognitionException [1]
    {   
        SmiParser.sequenceof_value_return retval = new SmiParser.sequenceof_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken L_BRACE660 = null;
        IToken COMMA662 = null;
        IToken R_BRACE664 = null;
        SmiParser.value_return value661 = default(SmiParser.value_return);

        SmiParser.value_return value663 = default(SmiParser.value_return);


        CommonTree L_BRACE660_tree=null;
        CommonTree COMMA662_tree=null;
        CommonTree R_BRACE664_tree=null;

        try 
    	{
            // Smi.g:1043:19: ( L_BRACE ( value )? ( COMMA value )* R_BRACE )
            // Smi.g:1043:19: L_BRACE ( value )? ( COMMA value )* R_BRACE
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	L_BRACE660=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_sequenceof_value8280); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{L_BRACE660_tree = (CommonTree)adaptor.Create(L_BRACE660);
            		adaptor.AddChild(root_0, L_BRACE660_tree);
            	}
            	// Smi.g:1043:27: ( value )?
            	int alt172 = 2;
            	int LA172_0 = input.LA(1);

            	if ( (LA172_0 == B_STRING || LA172_0 == C_STRING || LA172_0 == FALSE_KW || LA172_0 == H_STRING || LA172_0 == L_BRACE || LA172_0 == LOWER || (LA172_0 >= MINUS && LA172_0 <= NUMBER) || LA172_0 == PLUS_INFINITY_KW || LA172_0 == TRUE_KW || LA172_0 == UPPER) )
            	{
            	    alt172 = 1;
            	}
            	switch (alt172) 
            	{
            	    case 1 :
            	        // Smi.g:1043:28: value
            	        {
            	        	PushFollow(FOLLOW_value_in_sequenceof_value8283);
            	        	value661 = value();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value661.Tree);

            	        }
            	        break;

            	}

            	// Smi.g:1043:36: ( COMMA value )*
            	do 
            	{
            	    int alt173 = 2;
            	    int LA173_0 = input.LA(1);

            	    if ( (LA173_0 == COMMA) )
            	    {
            	        alt173 = 1;
            	    }


            	    switch (alt173) 
            		{
            			case 1 :
            			    // Smi.g:1043:37: COMMA value
            			    {
            			    	COMMA662=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_sequenceof_value8288); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA662_tree = (CommonTree)adaptor.Create(COMMA662);
            			    		adaptor.AddChild(root_0, COMMA662_tree);
            			    	}
            			    	PushFollow(FOLLOW_value_in_sequenceof_value8290);
            			    	value663 = value();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value663.Tree);

            			    }
            			    break;

            			default:
            			    goto loop173;
            	    }
            	} while (true);

            	loop173:
            		;	// Stops C# compiler whining that label 'loop173' has no statements

            	R_BRACE664=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_sequenceof_value8294); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{R_BRACE664_tree = (CommonTree)adaptor.Create(R_BRACE664);
            		adaptor.AddChild(root_0, R_BRACE664_tree);
            	}

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "sequenceof_value"

    public class cstr_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "cstr_value"
    // Smi.g:1045:0: cstr_value : (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE );
    public SmiParser.cstr_value_return cstr_value() // throws RecognitionException [1]
    {   
        SmiParser.cstr_value_return retval = new SmiParser.cstr_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken H_STRING665 = null;
        IToken B_STRING666 = null;
        IToken L_BRACE667 = null;
        IToken R_BRACE671 = null;
        SmiParser.id_list_return id_list668 = default(SmiParser.id_list_return);

        SmiParser.char_defs_list_return char_defs_list669 = default(SmiParser.char_defs_list_return);

        SmiParser.tuple_or_quad_return tuple_or_quad670 = default(SmiParser.tuple_or_quad_return);


        CommonTree H_STRING665_tree=null;
        CommonTree B_STRING666_tree=null;
        CommonTree L_BRACE667_tree=null;
        CommonTree R_BRACE671_tree=null;

        try 
    	{
            // Smi.g:1045:13: (=> H_STRING |=> B_STRING | L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE )
            int alt175 = 3;
            int LA175_0 = input.LA(1);

            if ( (LA175_0 == H_STRING) && (synpred46_Smi()) )
            {
                alt175 = 1;
            }
            else if ( (LA175_0 == B_STRING) && (synpred47_Smi()) )
            {
                alt175 = 2;
            }
            else if ( (LA175_0 == L_BRACE) )
            {
                alt175 = 3;
            }
            else 
            {
                if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                NoViableAltException nvae_d175s0 =
                    new NoViableAltException("", 175, 0, input);

                throw nvae_d175s0;
            }
            switch (alt175) 
            {
                case 1 :
                    // Smi.g:1045:13: => H_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	H_STRING665=(IToken)Match(input,H_STRING,FOLLOW_H_STRING_in_cstr_value8307); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{H_STRING665_tree = (CommonTree)adaptor.Create(H_STRING665);
                    		adaptor.AddChild(root_0, H_STRING665_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1046:13: => B_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();


                    	B_STRING666=(IToken)Match(input,B_STRING,FOLLOW_B_STRING_in_cstr_value8328); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{B_STRING666_tree = (CommonTree)adaptor.Create(B_STRING666);
                    		adaptor.AddChild(root_0, B_STRING666_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1047:13: L_BRACE (=> id_list |=> char_defs_list | tuple_or_quad ) R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_BRACE667=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_cstr_value8343); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE667_tree = (CommonTree)adaptor.Create(L_BRACE667);
                    		adaptor.AddChild(root_0, L_BRACE667_tree);
                    	}
                    	// Smi.g:1048:13: (=> id_list |=> char_defs_list | tuple_or_quad )
                    	int alt174 = 3;
                    	int LA174_0 = input.LA(1);

                    	if ( (LA174_0 == LOWER) )
                    	{
                    	    int LA174_1 = input.LA(2);

                    	    if ( (synpred48_Smi()) )
                    	    {
                    	        alt174 = 1;
                    	    }
                    	    else if ( (synpred49_Smi()) )
                    	    {
                    	        alt174 = 2;
                    	    }
                    	    else 
                    	    {
                    	        if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	        NoViableAltException nvae_d174s1 =
                    	            new NoViableAltException("", 174, 1, input);

                    	        throw nvae_d174s1;
                    	    }
                    	}
                    	else if ( (LA174_0 == C_STRING) && (synpred49_Smi()) )
                    	{
                    	    alt174 = 2;
                    	}
                    	else if ( (LA174_0 == L_BRACE) && (synpred49_Smi()) )
                    	{
                    	    alt174 = 2;
                    	}
                    	else if ( (LA174_0 == UPPER) && (synpred49_Smi()) )
                    	{
                    	    alt174 = 2;
                    	}
                    	else if ( (LA174_0 == MINUS || LA174_0 == NUMBER) )
                    	{
                    	    alt174 = 3;
                    	}
                    	else 
                    	{
                    	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
                    	    NoViableAltException nvae_d174s0 =
                    	        new NoViableAltException("", 174, 0, input);

                    	    throw nvae_d174s0;
                    	}
                    	switch (alt174) 
                    	{
                    	    case 1 :
                    	        // Smi.g:1048:15: => id_list
                    	        {

                    	        	PushFollow(FOLLOW_id_list_in_cstr_value8366);
                    	        	id_list668 = id_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, id_list668.Tree);

                    	        }
                    	        break;
                    	    case 2 :
                    	        // Smi.g:1049:17: => char_defs_list
                    	        {

                    	        	PushFollow(FOLLOW_char_defs_list_in_cstr_value8391);
                    	        	char_defs_list669 = char_defs_list();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs_list669.Tree);

                    	        }
                    	        break;
                    	    case 3 :
                    	        // Smi.g:1050:17: tuple_or_quad
                    	        {
                    	        	PushFollow(FOLLOW_tuple_or_quad_in_cstr_value8410);
                    	        	tuple_or_quad670 = tuple_or_quad();
                    	        	state.followingStackPointer--;
                    	        	if (state.failed) return retval;
                    	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad670.Tree);

                    	        }
                    	        break;

                    	}

                    	R_BRACE671=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_cstr_value8426); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE671_tree = (CommonTree)adaptor.Create(R_BRACE671);
                    		adaptor.AddChild(root_0, R_BRACE671_tree);
                    	}

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "cstr_value"

    public class id_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "id_list"
    // Smi.g:1053:0: id_list : LOWER ( COMMA LOWER )* ;
    public SmiParser.id_list_return id_list() // throws RecognitionException [1]
    {   
        SmiParser.id_list_return retval = new SmiParser.id_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER672 = null;
        IToken COMMA673 = null;
        IToken LOWER674 = null;

        CommonTree LOWER672_tree=null;
        CommonTree COMMA673_tree=null;
        CommonTree LOWER674_tree=null;

        try 
    	{
            // Smi.g:1053:10: ( LOWER ( COMMA LOWER )* )
            // Smi.g:1053:10: LOWER ( COMMA LOWER )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER672=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8433); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER672_tree = (CommonTree)adaptor.Create(LOWER672);
            		adaptor.AddChild(root_0, LOWER672_tree);
            	}
            	// Smi.g:1053:16: ( COMMA LOWER )*
            	do 
            	{
            	    int alt176 = 2;
            	    int LA176_0 = input.LA(1);

            	    if ( (LA176_0 == COMMA) )
            	    {
            	        alt176 = 1;
            	    }


            	    switch (alt176) 
            		{
            			case 1 :
            			    // Smi.g:1053:17: COMMA LOWER
            			    {
            			    	COMMA673=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_id_list8436); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA673_tree = (CommonTree)adaptor.Create(COMMA673);
            			    		adaptor.AddChild(root_0, COMMA673_tree);
            			    	}
            			    	LOWER674=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_id_list8438); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{LOWER674_tree = (CommonTree)adaptor.Create(LOWER674);
            			    		adaptor.AddChild(root_0, LOWER674_tree);
            			    	}

            			    }
            			    break;

            			default:
            			    goto loop176;
            	    }
            	} while (true);

            	loop176:
            		;	// Stops C# compiler whining that label 'loop176' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "id_list"

    public class char_defs_list_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "char_defs_list"
    // Smi.g:1055:0: char_defs_list : char_defs ( COMMA char_defs )* ;
    public SmiParser.char_defs_list_return char_defs_list() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_list_return retval = new SmiParser.char_defs_list_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA676 = null;
        SmiParser.char_defs_return char_defs675 = default(SmiParser.char_defs_return);

        SmiParser.char_defs_return char_defs677 = default(SmiParser.char_defs_return);


        CommonTree COMMA676_tree=null;

        try 
    	{
            // Smi.g:1055:17: ( char_defs ( COMMA char_defs )* )
            // Smi.g:1055:17: char_defs ( COMMA char_defs )*
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_char_defs_in_char_defs_list8448);
            	char_defs675 = char_defs();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs675.Tree);
            	// Smi.g:1055:27: ( COMMA char_defs )*
            	do 
            	{
            	    int alt177 = 2;
            	    int LA177_0 = input.LA(1);

            	    if ( (LA177_0 == COMMA) )
            	    {
            	        alt177 = 1;
            	    }


            	    switch (alt177) 
            		{
            			case 1 :
            			    // Smi.g:1055:28: COMMA char_defs
            			    {
            			    	COMMA676=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_char_defs_list8451); if (state.failed) return retval;
            			    	if ( state.backtracking == 0 )
            			    	{COMMA676_tree = (CommonTree)adaptor.Create(COMMA676);
            			    		adaptor.AddChild(root_0, COMMA676_tree);
            			    	}
            			    	PushFollow(FOLLOW_char_defs_in_char_defs_list8453);
            			    	char_defs677 = char_defs();
            			    	state.followingStackPointer--;
            			    	if (state.failed) return retval;
            			    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, char_defs677.Tree);

            			    }
            			    break;

            			default:
            			    goto loop177;
            	    }
            	} while (true);

            	loop177:
            		;	// Stops C# compiler whining that label 'loop177' has no statements


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs_list"

    public class tuple_or_quad_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "tuple_or_quad"
    // Smi.g:1058:0: tuple_or_quad : signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? ;
    public SmiParser.tuple_or_quad_return tuple_or_quad() // throws RecognitionException [1]
    {   
        SmiParser.tuple_or_quad_return retval = new SmiParser.tuple_or_quad_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken COMMA679 = null;
        IToken COMMA681 = null;
        IToken COMMA683 = null;
        SmiParser.signed_number_return signed_number678 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number680 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number682 = default(SmiParser.signed_number_return);

        SmiParser.signed_number_return signed_number684 = default(SmiParser.signed_number_return);


        CommonTree COMMA679_tree=null;
        CommonTree COMMA681_tree=null;
        CommonTree COMMA683_tree=null;

        try 
    	{
            // Smi.g:1058:16: ( signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )? )
            // Smi.g:1058:16: signed_number COMMA signed_number ( COMMA signed_number COMMA signed_number )?
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8464);
            	signed_number678 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number678.Tree);
            	COMMA679=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8466); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{COMMA679_tree = (CommonTree)adaptor.Create(COMMA679);
            		adaptor.AddChild(root_0, COMMA679_tree);
            	}
            	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8468);
            	signed_number680 = signed_number();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number680.Tree);
            	// Smi.g:1058:50: ( COMMA signed_number COMMA signed_number )?
            	int alt178 = 2;
            	int LA178_0 = input.LA(1);

            	if ( (LA178_0 == COMMA) )
            	{
            	    alt178 = 1;
            	}
            	switch (alt178) 
            	{
            	    case 1 :
            	        // Smi.g:1058:51: COMMA signed_number COMMA signed_number
            	        {
            	        	COMMA681=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8471); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA681_tree = (CommonTree)adaptor.Create(COMMA681);
            	        		adaptor.AddChild(root_0, COMMA681_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8473);
            	        	signed_number682 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number682.Tree);
            	        	COMMA683=(IToken)Match(input,COMMA,FOLLOW_COMMA_in_tuple_or_quad8475); if (state.failed) return retval;
            	        	if ( state.backtracking == 0 )
            	        	{COMMA683_tree = (CommonTree)adaptor.Create(COMMA683);
            	        		adaptor.AddChild(root_0, COMMA683_tree);
            	        	}
            	        	PushFollow(FOLLOW_signed_number_in_tuple_or_quad8477);
            	        	signed_number684 = signed_number();
            	        	state.followingStackPointer--;
            	        	if (state.failed) return retval;
            	        	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, signed_number684.Tree);

            	        }
            	        break;

            	}


            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "tuple_or_quad"

    public class char_defs_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "char_defs"
    // Smi.g:1061:0: char_defs : ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value );
    public SmiParser.char_defs_return char_defs() // throws RecognitionException [1]
    {   
        SmiParser.char_defs_return retval = new SmiParser.char_defs_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken C_STRING685 = null;
        IToken L_BRACE686 = null;
        IToken R_BRACE688 = null;
        SmiParser.tuple_or_quad_return tuple_or_quad687 = default(SmiParser.tuple_or_quad_return);

        SmiParser.defined_value_return defined_value689 = default(SmiParser.defined_value_return);


        CommonTree C_STRING685_tree=null;
        CommonTree L_BRACE686_tree=null;
        CommonTree R_BRACE688_tree=null;

        try 
    	{
            // Smi.g:1061:12: ( C_STRING | L_BRACE tuple_or_quad R_BRACE | defined_value )
            int alt179 = 3;
            switch ( input.LA(1) ) 
            {
            case C_STRING:
            	{
                alt179 = 1;
                }
                break;
            case L_BRACE:
            	{
                alt179 = 2;
                }
                break;
            case LOWER:
            case UPPER:
            	{
                alt179 = 3;
                }
                break;
            	default:
            	    if ( state.backtracking > 0 ) {state.failed = true; return retval;}
            	    NoViableAltException nvae_d179s0 =
            	        new NoViableAltException("", 179, 0, input);

            	    throw nvae_d179s0;
            }

            switch (alt179) 
            {
                case 1 :
                    // Smi.g:1061:12: C_STRING
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	C_STRING685=(IToken)Match(input,C_STRING,FOLLOW_C_STRING_in_char_defs8488); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{C_STRING685_tree = (CommonTree)adaptor.Create(C_STRING685);
                    		adaptor.AddChild(root_0, C_STRING685_tree);
                    	}

                    }
                    break;
                case 2 :
                    // Smi.g:1062:12: L_BRACE tuple_or_quad R_BRACE
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	L_BRACE686=(IToken)Match(input,L_BRACE,FOLLOW_L_BRACE_in_char_defs8502); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{L_BRACE686_tree = (CommonTree)adaptor.Create(L_BRACE686);
                    		adaptor.AddChild(root_0, L_BRACE686_tree);
                    	}
                    	PushFollow(FOLLOW_tuple_or_quad_in_char_defs8504);
                    	tuple_or_quad687 = tuple_or_quad();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, tuple_or_quad687.Tree);
                    	R_BRACE688=(IToken)Match(input,R_BRACE,FOLLOW_R_BRACE_in_char_defs8506); if (state.failed) return retval;
                    	if ( state.backtracking == 0 )
                    	{R_BRACE688_tree = (CommonTree)adaptor.Create(R_BRACE688);
                    		adaptor.AddChild(root_0, R_BRACE688_tree);
                    	}

                    }
                    break;
                case 3 :
                    // Smi.g:1063:12: defined_value
                    {
                    	root_0 = (CommonTree)adaptor.GetNilNode();

                    	PushFollow(FOLLOW_defined_value_in_char_defs8519);
                    	defined_value689 = defined_value();
                    	state.followingStackPointer--;
                    	if (state.failed) return retval;
                    	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, defined_value689.Tree);

                    }
                    break;

            }
            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "char_defs"

    public class named_value_return : ParserRuleReturnScope
    {
        private CommonTree tree;
        override public object Tree
        {
        	get { return tree; }
        	set { tree = (CommonTree) value; }
        }
    };

    // $ANTLR start "named_value"
    // Smi.g:1068:0: named_value : LOWER value ;
    public SmiParser.named_value_return named_value() // throws RecognitionException [1]
    {   
        SmiParser.named_value_return retval = new SmiParser.named_value_return();
        retval.Start = input.LT(1);

        CommonTree root_0 = null;

        IToken LOWER690 = null;
        SmiParser.value_return value691 = default(SmiParser.value_return);


        CommonTree LOWER690_tree=null;

        try 
    	{
            // Smi.g:1068:14: ( LOWER value )
            // Smi.g:1068:14: LOWER value
            {
            	root_0 = (CommonTree)adaptor.GetNilNode();

            	LOWER690=(IToken)Match(input,LOWER,FOLLOW_LOWER_in_named_value8529); if (state.failed) return retval;
            	if ( state.backtracking == 0 )
            	{LOWER690_tree = (CommonTree)adaptor.Create(LOWER690);
            		adaptor.AddChild(root_0, LOWER690_tree);
            	}
            	PushFollow(FOLLOW_value_in_named_value8531);
            	value691 = value();
            	state.followingStackPointer--;
            	if (state.failed) return retval;
            	if ( state.backtracking == 0 ) adaptor.AddChild(root_0, value691.Tree);

            }

            retval.Stop = input.LT(-1);

            if ( (state.backtracking==0) )
            {	retval.Tree = (CommonTree)adaptor.RulePostProcessing(root_0);
            	adaptor.SetTokenBoundaries(retval.Tree, (IToken) retval.Start, (IToken) retval.Stop);}
        }
        catch (RecognitionException re) 
    	{
            ReportError(re);
            Recover(input,re);
    	// Conversion of the second argument necessary, but harmless
    	retval.Tree = (CommonTree)adaptor.ErrorNode(input, (IToken) retval.Start, input.LT(-1), re);

        }
        finally 
    	{
        }
        return retval;
    }
    // $ANTLR end "named_value"

    // $ANTLR start "synpred1_Smi"
    public void synpred1_Smi_fragment() {
        // Smi.g:610:27: ( LOWER ( LOWER | NUMBER ) )
        // Smi.g:610:28: LOWER ( LOWER | NUMBER )
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred1_Smi1981); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred1_Smi"

    // $ANTLR start "synpred10_Smi"
    public void synpred10_Smi_fragment() {
        // Smi.g:666:8: ( sequence_value )
        // Smi.g:666:9: sequence_value
        {
        	PushFollow(FOLLOW_sequence_value_in_synpred10_Smi2607);
        	sequence_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred10_Smi"

    // $ANTLR start "synpred11_Smi"
    public void synpred11_Smi_fragment() {
        // Smi.g:667:8: ( sequenceof_value )
        // Smi.g:667:9: sequenceof_value
        {
        	PushFollow(FOLLOW_sequenceof_value_in_synpred11_Smi2623);
        	sequenceof_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred11_Smi"

    // $ANTLR start "synpred12_Smi"
    public void synpred12_Smi_fragment() {
        // Smi.g:668:8: ( cstr_value )
        // Smi.g:668:9: cstr_value
        {
        	PushFollow(FOLLOW_cstr_value_in_synpred12_Smi2639);
        	cstr_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred12_Smi"

    // $ANTLR start "synpred13_Smi"
    public void synpred13_Smi_fragment() {
        // Smi.g:669:8: ( obj_id_comp_lst )
        // Smi.g:669:9: obj_id_comp_lst
        {
        	PushFollow(FOLLOW_obj_id_comp_lst_in_synpred13_Smi2655);
        	obj_id_comp_lst();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred13_Smi"

    // $ANTLR start "synpred14_Smi"
    public void synpred14_Smi_fragment() {
        // Smi.g:670:8: ( PLUS_INFINITY_KW )
        // Smi.g:670:9: PLUS_INFINITY_KW
        {
        	Match(input,PLUS_INFINITY_KW,FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2671); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred14_Smi"

    // $ANTLR start "synpred15_Smi"
    public void synpred15_Smi_fragment() {
        // Smi.g:671:8: ( MINUS_INFINITY_KW )
        // Smi.g:671:9: MINUS_INFINITY_KW
        {
        	Match(input,MINUS_INFINITY_KW,FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2687); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred15_Smi"

    // $ANTLR start "synpred16_Smi"
    public void synpred16_Smi_fragment() {
        // Smi.g:700:36: ( L_BRACE namedNumber )
        // Smi.g:700:37: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred16_Smi3000); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred16_Smi3002);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred16_Smi"

    // $ANTLR start "synpred17_Smi"
    public void synpred17_Smi_fragment() {
        // Smi.g:716:27: ( L_BRACE namedNumber )
        // Smi.g:716:28: L_BRACE namedNumber
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred17_Smi3093); if (state.failed) return ;
        	PushFollow(FOLLOW_namedNumber_in_synpred17_Smi3095);
        	namedNumber();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred17_Smi"

    // $ANTLR start "synpred18_Smi"
    public void synpred18_Smi_fragment() {
        // Smi.g:760:44: ( LOWER )
        // Smi.g:760:45: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred18_Smi3453); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred18_Smi"

    // $ANTLR start "synpred19_Smi"
    public void synpred19_Smi_fragment() {
        // Smi.g:761:23: ( RESULT_KW )
        // Smi.g:761:24: RESULT_KW
        {
        	Match(input,RESULT_KW,FOLLOW_RESULT_KW_in_synpred19_Smi3491); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred19_Smi"

    // $ANTLR start "synpred2_Smi"
    public void synpred2_Smi_fragment() {
        // Smi.g:644:29: ( defined_value )
        // Smi.g:644:30: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred2_Smi2279);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred2_Smi"

    // $ANTLR start "synpred20_Smi"
    public void synpred20_Smi_fragment() {
        // Smi.g:762:26: ( LOWER )
        // Smi.g:762:27: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred20_Smi3525); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred20_Smi"

    // $ANTLR start "synpred21_Smi"
    public void synpred21_Smi_fragment() {
        // Smi.g:762:38: ( LOWER )
        // Smi.g:762:39: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred21_Smi3532); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred21_Smi"

    // $ANTLR start "synpred22_Smi"
    public void synpred22_Smi_fragment() {
        // Smi.g:764:23: ( ERRORS_KW )
        // Smi.g:764:24: ERRORS_KW
        {
        	Match(input,ERRORS_KW,FOLLOW_ERRORS_KW_in_synpred22_Smi3578); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred22_Smi"

    // $ANTLR start "synpred23_Smi"
    public void synpred23_Smi_fragment() {
        // Smi.g:765:23: ( LINKED_KW )
        // Smi.g:765:24: LINKED_KW
        {
        	Match(input,LINKED_KW,FOLLOW_LINKED_KW_in_synpred23_Smi3621); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred23_Smi"

    // $ANTLR start "synpred24_Smi"
    public void synpred24_Smi_fragment() {
        // Smi.g:775:39: ( LOWER )
        // Smi.g:775:40: LOWER
        {
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred24_Smi3663); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred24_Smi"

    // $ANTLR start "synpred25_Smi"
    public void synpred25_Smi_fragment() {
        // Smi.g:806:23: ( smi_type L_BRACE )
        // Smi.g:806:24: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred25_Smi3993);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred25_Smi3995); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred25_Smi"

    // $ANTLR start "synpred26_Smi"
    public void synpred26_Smi_fragment() {
        // Smi.g:807:24: ( smi_type )
        // Smi.g:807:25: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred26_Smi4029);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred26_Smi"

    // $ANTLR start "synpred27_Smi"
    public void synpred27_Smi_fragment() {
        // Smi.g:816:21: ( 'DESCRIPTION' )
        // Smi.g:816:22: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred27_Smi4333); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred27_Smi"

    // $ANTLR start "synpred28_Smi"
    public void synpred28_Smi_fragment() {
        // Smi.g:819:7: (~ ( 'PIB-INDEX' ) )
        // Smi.g:
        {
        	if ( (input.LA(1) >= ABSENT_KW && input.LA(1) <= 169) || (input.LA(1) >= 171 && input.LA(1) <= 197) ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred28_Smi"

    // $ANTLR start "synpred29_Smi"
    public void synpred29_Smi_fragment() {
        // Smi.g:826:7: ( 'DEFVAL' )
        // Smi.g:826:8: 'DEFVAL'
        {
        	Match(input,140,FOLLOW_140_in_synpred29_Smi4729); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred29_Smi"

    // $ANTLR start "synpred3_Smi"
    public void synpred3_Smi_fragment() {
        // Smi.g:659:8: ( TRUE_KW )
        // Smi.g:659:9: TRUE_KW
        {
        	Match(input,TRUE_KW,FOLLOW_TRUE_KW_in_synpred3_Smi2495); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred3_Smi"

    // $ANTLR start "synpred30_Smi"
    public void synpred30_Smi_fragment() {
        // Smi.g:827:23: ( L_BRACE LOWER ( COMMA | R_BRACE ) )
        // Smi.g:827:24: L_BRACE LOWER ( COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred30_Smi4762); if (state.failed) return ;
        	Match(input,LOWER,FOLLOW_LOWER_in_synpred30_Smi4764); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred30_Smi"

    // $ANTLR start "synpred31_Smi"
    public void synpred31_Smi_fragment() {
        // Smi.g:891:40: ( smi_type L_BRACE )
        // Smi.g:891:41: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred31_Smi5684);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred31_Smi5686); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred31_Smi"

    // $ANTLR start "synpred32_Smi"
    public void synpred32_Smi_fragment() {
        // Smi.g:926:42: ( UPPER )
        // Smi.g:926:43: UPPER
        {
        	Match(input,UPPER,FOLLOW_UPPER_in_synpred32_Smi6162); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred32_Smi"

    // $ANTLR start "synpred33_Smi"
    public void synpred33_Smi_fragment() {
        // Smi.g:926:60: ( value )
        // Smi.g:926:61: value
        {
        	PushFollow(FOLLOW_value_in_synpred33_Smi6171);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred33_Smi"

    // $ANTLR start "synpred34_Smi"
    public void synpred34_Smi_fragment() {
        // Smi.g:936:32: ( smi_type L_BRACE )
        // Smi.g:936:33: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred34_Smi6554);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred34_Smi6556); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred34_Smi"

    // $ANTLR start "synpred35_Smi"
    public void synpred35_Smi_fragment() {
        // Smi.g:937:32: ( smi_type )
        // Smi.g:937:33: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred35_Smi6608);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred35_Smi"

    // $ANTLR start "synpred36_Smi"
    public void synpred36_Smi_fragment() {
        // Smi.g:967:56: ( L_BRACE ( LOWER | COMMA | R_BRACE ) )
        // Smi.g:967:57: L_BRACE ( LOWER | COMMA | R_BRACE )
        {
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred36_Smi7100); if (state.failed) return ;
        	if ( input.LA(1) == COMMA || input.LA(1) == LOWER || input.LA(1) == R_BRACE ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred36_Smi"

    // $ANTLR start "synpred37_Smi"
    public void synpred37_Smi_fragment() {
        // Smi.g:969:33: ( smi_type L_BRACE )
        // Smi.g:969:34: smi_type L_BRACE
        {
        	PushFollow(FOLLOW_smi_type_in_synpred37_Smi7187);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;
        	Match(input,L_BRACE,FOLLOW_L_BRACE_in_synpred37_Smi7189); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred37_Smi"

    // $ANTLR start "synpred38_Smi"
    public void synpred38_Smi_fragment() {
        // Smi.g:971:33: ( smi_type )
        // Smi.g:971:34: smi_type
        {
        	PushFollow(FOLLOW_smi_type_in_synpred38_Smi7279);
        	smi_type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred38_Smi"

    // $ANTLR start "synpred39_Smi"
    public void synpred39_Smi_fragment() {
        // Smi.g:986:22: ( 'DESCRIPTION' )
        // Smi.g:986:23: 'DESCRIPTION'
        {
        	Match(input,141,FOLLOW_141_in_synpred39_Smi7443); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred39_Smi"

    // $ANTLR start "synpred4_Smi"
    public void synpred4_Smi_fragment() {
        // Smi.g:660:8: ( FALSE_KW )
        // Smi.g:660:9: FALSE_KW
        {
        	Match(input,FALSE_KW,FOLLOW_FALSE_KW_in_synpred4_Smi2511); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred4_Smi"

    // $ANTLR start "synpred40_Smi"
    public void synpred40_Smi_fragment() {
        // Smi.g:992:14: ( type )
        // Smi.g:992:15: type
        {
        	PushFollow(FOLLOW_type_in_synpred40_Smi7498);
        	type();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred40_Smi"

    // $ANTLR start "synpred41_Smi"
    public void synpred41_Smi_fragment() {
        // Smi.g:998:22: ( L_BRACKET ( NUMBER | UPPER | LOWER ) )
        // Smi.g:998:23: L_BRACKET ( NUMBER | UPPER | LOWER )
        {
        	Match(input,L_BRACKET,FOLLOW_L_BRACKET_in_synpred41_Smi7537); if (state.failed) return ;
        	if ( input.LA(1) == LOWER || input.LA(1) == NUMBER || input.LA(1) == UPPER ) 
        	{
        	    input.Consume();
        	    state.errorRecovery = false;state.failed = false;
        	}
        	else 
        	{
        	    if ( state.backtracking > 0 ) {state.failed = true; return ;}
        	    MismatchedSetException mse = new MismatchedSetException(null,input);
        	    throw mse;
        	}


        }
    }
    // $ANTLR end "synpred41_Smi"

    // $ANTLR start "synpred42_Smi"
    public void synpred42_Smi_fragment() {
        // Smi.g:1011:19: ( signed_number )
        // Smi.g:1011:20: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred42_Smi7695);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred42_Smi"

    // $ANTLR start "synpred43_Smi"
    public void synpred43_Smi_fragment() {
        // Smi.g:1012:21: ( defined_value )
        // Smi.g:1012:22: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred43_Smi7724);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred43_Smi"

    // $ANTLR start "synpred44_Smi"
    public void synpred44_Smi_fragment() {
        // Smi.g:1022:22: ( value )
        // Smi.g:1022:23: value
        {
        	PushFollow(FOLLOW_value_in_synpred44_Smi7883);
        	value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred44_Smi"

    // $ANTLR start "synpred45_Smi"
    public void synpred45_Smi_fragment() {
        // Smi.g:1023:22: ( value_range )
        // Smi.g:1023:23: value_range
        {
        	PushFollow(FOLLOW_value_range_in_synpred45_Smi7913);
        	value_range();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred45_Smi"

    // $ANTLR start "synpred46_Smi"
    public void synpred46_Smi_fragment() {
        // Smi.g:1045:13: ( H_STRING )
        // Smi.g:1045:14: H_STRING
        {
        	Match(input,H_STRING,FOLLOW_H_STRING_in_synpred46_Smi8302); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred46_Smi"

    // $ANTLR start "synpred47_Smi"
    public void synpred47_Smi_fragment() {
        // Smi.g:1046:13: ( B_STRING )
        // Smi.g:1046:14: B_STRING
        {
        	Match(input,B_STRING,FOLLOW_B_STRING_in_synpred47_Smi8323); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred47_Smi"

    // $ANTLR start "synpred48_Smi"
    public void synpred48_Smi_fragment() {
        // Smi.g:1048:15: ( id_list )
        // Smi.g:1048:16: id_list
        {
        	PushFollow(FOLLOW_id_list_in_synpred48_Smi8361);
        	id_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred48_Smi"

    // $ANTLR start "synpred49_Smi"
    public void synpred49_Smi_fragment() {
        // Smi.g:1049:17: ( char_defs_list )
        // Smi.g:1049:18: char_defs_list
        {
        	PushFollow(FOLLOW_char_defs_list_in_synpred49_Smi8386);
        	char_defs_list();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred49_Smi"

    // $ANTLR start "synpred5_Smi"
    public void synpred5_Smi_fragment() {
        // Smi.g:661:8: ( NULL_KW )
        // Smi.g:661:9: NULL_KW
        {
        	Match(input,NULL_KW,FOLLOW_NULL_KW_in_synpred5_Smi2527); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred5_Smi"

    // $ANTLR start "synpred6_Smi"
    public void synpred6_Smi_fragment() {
        // Smi.g:662:8: ( C_STRING )
        // Smi.g:662:9: C_STRING
        {
        	Match(input,C_STRING,FOLLOW_C_STRING_in_synpred6_Smi2544); if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred6_Smi"

    // $ANTLR start "synpred7_Smi"
    public void synpred7_Smi_fragment() {
        // Smi.g:663:8: ( defined_value )
        // Smi.g:663:9: defined_value
        {
        	PushFollow(FOLLOW_defined_value_in_synpred7_Smi2560);
        	defined_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred7_Smi"

    // $ANTLR start "synpred8_Smi"
    public void synpred8_Smi_fragment() {
        // Smi.g:664:8: ( signed_number )
        // Smi.g:664:9: signed_number
        {
        	PushFollow(FOLLOW_signed_number_in_synpred8_Smi2576);
        	signed_number();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred8_Smi"

    // $ANTLR start "synpred9_Smi"
    public void synpred9_Smi_fragment() {
        // Smi.g:665:8: ( choice_value )
        // Smi.g:665:9: choice_value
        {
        	PushFollow(FOLLOW_choice_value_in_synpred9_Smi2591);
        	choice_value();
        	state.followingStackPointer--;
        	if (state.failed) return ;

        }
    }
    // $ANTLR end "synpred9_Smi"

    // Delegated rules

   	public bool synpred1_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred1_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred2_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred2_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred7_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred7_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred9_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred9_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred10_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred10_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred11_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred11_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred12_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred12_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred13_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred13_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred3_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred3_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred4_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred4_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred5_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred5_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred6_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred6_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred8_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred8_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred14_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred14_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred15_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred15_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred16_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred16_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred17_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred17_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred18_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred18_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred21_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred21_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred20_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred20_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred19_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred19_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred22_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred22_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred23_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred23_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred24_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred24_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred26_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred26_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred25_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred25_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred27_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred27_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred28_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred28_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred30_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred30_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred29_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred29_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred31_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred31_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred33_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred33_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred32_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred32_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred35_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred35_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred34_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred34_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred36_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred36_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred38_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred38_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred37_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred37_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred39_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred39_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred40_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred40_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred41_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred41_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred42_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred42_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred43_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred43_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred44_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred44_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred45_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred45_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred48_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred48_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred49_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred49_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred46_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred46_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}
   	public bool synpred47_Smi() 
   	{
   	    state.backtracking++;
   	    int start = input.Mark();
   	    try 
   	    {
   	        synpred47_Smi_fragment(); // can never throw exception
   	    }
   	    catch (RecognitionException re) 
   	    {
   	        Console.Error.WriteLine("impossible: "+re);
   	    }
   	    bool success = !state.failed;
   	    input.Rewind(start);
   	    state.backtracking--;
   	    state.failed = false;
   	    return success;
   	}


   	protected DFA21 dfa21;
   	protected DFA24 dfa24;
   	protected DFA25 dfa25;
   	protected DFA26 dfa26;
   	protected DFA47 dfa47;
   	protected DFA50 dfa50;
   	protected DFA49 dfa49;
   	protected DFA56 dfa56;
   	protected DFA67 dfa67;
   	protected DFA76 dfa76;
   	protected DFA82 dfa82;
   	protected DFA81 dfa81;
   	protected DFA98 dfa98;
   	protected DFA107 dfa107;
   	protected DFA106 dfa106;
   	protected DFA118 dfa118;
   	protected DFA131 dfa131;
   	protected DFA135 dfa135;
   	protected DFA138 dfa138;
   	protected DFA142 dfa142;
   	protected DFA144 dfa144;
   	protected DFA161 dfa161;
	private void InitializeCyclicDFAs()
	{
    	this.dfa21 = new DFA21(this);
    	this.dfa24 = new DFA24(this);
    	this.dfa25 = new DFA25(this);
    	this.dfa26 = new DFA26(this);
    	this.dfa47 = new DFA47(this);
    	this.dfa50 = new DFA50(this);
    	this.dfa49 = new DFA49(this);
    	this.dfa56 = new DFA56(this);
    	this.dfa67 = new DFA67(this);
    	this.dfa76 = new DFA76(this);
    	this.dfa82 = new DFA82(this);
    	this.dfa81 = new DFA81(this);
    	this.dfa98 = new DFA98(this);
    	this.dfa107 = new DFA107(this);
    	this.dfa106 = new DFA106(this);
    	this.dfa118 = new DFA118(this);
    	this.dfa131 = new DFA131(this);
    	this.dfa135 = new DFA135(this);
    	this.dfa138 = new DFA138(this);
    	this.dfa142 = new DFA142(this);
    	this.dfa144 = new DFA144(this);
    	this.dfa161 = new DFA161(this);
	    this.dfa21.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA21_SpecialStateTransition);

	    this.dfa25.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA25_SpecialStateTransition);

	    this.dfa47.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA47_SpecialStateTransition);
	    this.dfa50.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA50_SpecialStateTransition);
	    this.dfa49.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA49_SpecialStateTransition);
	    this.dfa56.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA56_SpecialStateTransition);
	    this.dfa67.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA67_SpecialStateTransition);
	    this.dfa76.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA76_SpecialStateTransition);
	    this.dfa82.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA82_SpecialStateTransition);
	    this.dfa81.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA81_SpecialStateTransition);
	    this.dfa98.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA98_SpecialStateTransition);
	    this.dfa107.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA107_SpecialStateTransition);
	    this.dfa106.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA106_SpecialStateTransition);
	    this.dfa118.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA118_SpecialStateTransition);
	    this.dfa131.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA131_SpecialStateTransition);
	    this.dfa135.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA135_SpecialStateTransition);
	    this.dfa138.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA138_SpecialStateTransition);
	    this.dfa142.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA142_SpecialStateTransition);
	    this.dfa144.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA144_SpecialStateTransition);
	    this.dfa161.specialStateTransitionHandler = new DFA.SpecialStateTransitionHandler(DFA161_SpecialStateTransition);
	}

    const string DFA21_eotS =
        "\x22\xFFFF";
    const string DFA21_eofS =
        "\x22\xFFFF";
    const string DFA21_minS =
        "\x1\x2B\x1\xFFFF\x2\x1D\x1E\xFFFF";
    const string DFA21_maxS =
        "\x1\xC0\x1\xFFFF\x1\x34\x1\xC0\x1E\xFFFF";
    const string DFA21_acceptS =
        "\x1\xFFFF\x1\x1\x2\xFFFF\x1\x3\x1D\x2";
    const string DFA21_specialS =
        "\x2\xFFFF\x1\x0\x1\x1\x1E\xFFFF}>";
    static readonly string[] DFA21_transitionS = {
            "\x1\x4\x19\xFFFF\x1\x1\x4\xFFFF\x1\x3\x8\xFFFF\x1\x4\x3\xFFFF"+
            "\x1\x4\xF\xFFFF\x1\x4\xF\xFFFF\x1\x2\x6\xFFFF\x4\x4\x1\xFFFF"+
            "\x4\x4\x1\xFFFF\x1\x4\x6\xFFFF\x1\x4\x2\xFFFF\x3\x4\x9\xFFFF"+
            "\x3\x4\x1\xFFFF\x3\x4\x1\xFFFF\x1\x4\x7\xFFFF\x1\x4\x1\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x4\x2\xFFFF\x3\x4\x4\xFFFF\x5\x4",
            "",
            "\x1\x4\x7\xFFFF\x1\x5\xE\xFFFF\x1\x4",
            "\x1\x4\xD\xFFFF\x1\xA\x8\xFFFF\x1\x4\x15\xFFFF\x1\x8\x8\xFFFF"+
            "\x1\x15\x3\xFFFF\x1\x9\xF\xFFFF\x1\x6\xF\xFFFF\x1\x7\x6\xFFFF"+
            "\x1\x18\x1\x1B\x1\x1A\x1\x19\x1\xFFFF\x1\x21\x1\x1C\x1\xE\x1"+
            "\xD\x1\xFFFF\x1\xB\x6\xFFFF\x1\x1D\x2\xFFFF\x1\xF\x1\x11\x1"+
            "\x10\x9\xFFFF\x3\x21\x1\xFFFF\x3\x21\x1\xFFFF\x1\x21\x7\xFFFF"+
            "\x1\x16\x1\xFFFF\x1\x20\x1\xFFFF\x1\x17\x2\xFFFF\x1\x14\x1\x1F"+
            "\x1\x1E\x4\xFFFF\x1\x21\x1\x12\x1\x13\x1\x21\x1\xC",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA21_eot = DFA.UnpackEncodedString(DFA21_eotS);
    static readonly short[] DFA21_eof = DFA.UnpackEncodedString(DFA21_eofS);
    static readonly char[] DFA21_min = DFA.UnpackEncodedStringToUnsignedChars(DFA21_minS);
    static readonly char[] DFA21_max = DFA.UnpackEncodedStringToUnsignedChars(DFA21_maxS);
    static readonly short[] DFA21_accept = DFA.UnpackEncodedString(DFA21_acceptS);
    static readonly short[] DFA21_special = DFA.UnpackEncodedString(DFA21_specialS);
    static readonly short[][] DFA21_transition = DFA.UnpackEncodedStringArray(DFA21_transitionS);

    protected class DFA21 : DFA
    {
        public DFA21(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 21;
            this.eot = DFA21_eot;
            this.eof = DFA21_eof;
            this.min = DFA21_min;
            this.max = DFA21_max;
            this.accept = DFA21_accept;
            this.special = DFA21_special;
            this.transition = DFA21_transition;

        }

        override public string Description
        {
            get { return "643:25: ( obj_id_comp_lst |=> defined_value )?"; }
        }

    }


    protected internal int DFA21_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA21_2 = input.LA(1);

                   	 
                   	int index21_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA21_2 == DOT) && (synpred2_Smi()) ) { s = 5; }

                   	else if ( (LA21_2 == COMMA || LA21_2 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index21_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA21_3 = input.LA(1);

                   	 
                   	int index21_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA21_3 == SEMI) && (synpred2_Smi()) ) { s = 6; }

                   	else if ( (LA21_3 == UPPER) && (synpred2_Smi()) ) { s = 7; }

                   	else if ( (LA21_3 == LOWER) && (synpred2_Smi()) ) { s = 8; }

                   	else if ( (LA21_3 == OPERATION_KW) && (synpred2_Smi()) ) { s = 9; }

                   	else if ( (LA21_3 == ERROR_KW) && (synpred2_Smi()) ) { s = 10; }

                   	else if ( (LA21_3 == 136) && (synpred2_Smi()) ) { s = 11; }

                   	else if ( (LA21_3 == 192) && (synpred2_Smi()) ) { s = 12; }

                   	else if ( (LA21_3 == 134) && (synpred2_Smi()) ) { s = 13; }

                   	else if ( (LA21_3 == 133) && (synpred2_Smi()) ) { s = 14; }

                   	else if ( (LA21_3 == 146) && (synpred2_Smi()) ) { s = 15; }

                   	else if ( (LA21_3 == 148) && (synpred2_Smi()) ) { s = 16; }

                   	else if ( (LA21_3 == 147) && (synpred2_Smi()) ) { s = 17; }

                   	else if ( (LA21_3 == 189) && (synpred2_Smi()) ) { s = 18; }

                   	else if ( (LA21_3 == 190) && (synpred2_Smi()) ) { s = 19; }

                   	else if ( (LA21_3 == 181) && (synpred2_Smi()) ) { s = 20; }

                   	else if ( (LA21_3 == OBJECT_KW) && (synpred2_Smi()) ) { s = 21; }

                   	else if ( (LA21_3 == 174) && (synpred2_Smi()) ) { s = 22; }

                   	else if ( (LA21_3 == 178) && (synpred2_Smi()) ) { s = 23; }

                   	else if ( (LA21_3 == 126) && (synpred2_Smi()) ) { s = 24; }

                   	else if ( (LA21_3 == 129) && (synpred2_Smi()) ) { s = 25; }

                   	else if ( (LA21_3 == 128) && (synpred2_Smi()) ) { s = 26; }

                   	else if ( (LA21_3 == 127) && (synpred2_Smi()) ) { s = 27; }

                   	else if ( (LA21_3 == 132) && (synpred2_Smi()) ) { s = 28; }

                   	else if ( (LA21_3 == 143) && (synpred2_Smi()) ) { s = 29; }

                   	else if ( (LA21_3 == 183) && (synpred2_Smi()) ) { s = 30; }

                   	else if ( (LA21_3 == 182) && (synpred2_Smi()) ) { s = 31; }

                   	else if ( (LA21_3 == 176) && (synpred2_Smi()) ) { s = 32; }

                   	else if ( (LA21_3 == 131 || (LA21_3 >= 158 && LA21_3 <= 160) || (LA21_3 >= 162 && LA21_3 <= 164) || LA21_3 == 166 || LA21_3 == 188 || LA21_3 == 191) && (synpred2_Smi()) ) { s = 33; }

                   	else if ( (LA21_3 == COMMA || LA21_3 == FROM_KW) ) { s = 4; }

                   	 
                   	input.Seek(index21_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae21 =
            new NoViableAltException(dfa.Description, 21, _s, input);
        dfa.Error(nvae21);
        throw nvae21;
    }
    const string DFA24_eotS =
        "\xB\xFFFF";
    const string DFA24_eofS =
        "\xB\xFFFF";
    const string DFA24_minS =
        "\x1\x7\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA24_maxS =
        "\x1\xBF\x2\xFFFF\x1\x3B\x1\x6D\x6\xFFFF";
    const string DFA24_acceptS =
        "\x1\xFFFF\x2\x1\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x2\x1";
    const string DFA24_specialS =
        "\xB\xFFFF}>";
    static readonly string[] DFA24_transitionS = {
            "\x1\x1\xA\xFFFF\x3\x1\x2\xFFFF\x1\x1\x2\xFFFF\x1\x1\xD\xFFFF"+
            "\x1\x1\x1\xFFFF\x1\x1\x1\x7\x6\xFFFF\x1\x1\x2\xFFFF\x3\x1\x2"+
            "\xFFFF\x1\x1\x6\xFFFF\x1\x2\x2\xFFFF\x1\x1\x1\xFFFF\x1\x2\x3"+
            "\xFFFF\x1\x6\x4\xFFFF\x1\x2\x1\xFFFF\x1\x1\x1\xFFFF\x1\x3\x1"+
            "\x4\x2\xFFFF\x1\x7\x7\xFFFF\x1\x1\x4\xFFFF\x1\x2\x3\xFFFF\x2"+
            "\x2\x4\xFFFF\x1\x1\x1\xFFFF\x1\x1\x5\xFFFF\x1\x1\x1\x5\x4\x1"+
            "\x7\xFFFF\x1\x7\x5\xFFFF\x1\x8\x14\xFFFF\x3\x7\x1\xFFFF\x3\x7"+
            "\x1\xFFFF\x1\x7\xC\xFFFF\x1\x2\x8\xFFFF\x1\x7\x2\xFFFF\x1\x7",
            "",
            "",
            "\x1\x9",
            "\x1\xA",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA24_eot = DFA.UnpackEncodedString(DFA24_eotS);
    static readonly short[] DFA24_eof = DFA.UnpackEncodedString(DFA24_eofS);
    static readonly char[] DFA24_min = DFA.UnpackEncodedStringToUnsignedChars(DFA24_minS);
    static readonly char[] DFA24_max = DFA.UnpackEncodedStringToUnsignedChars(DFA24_maxS);
    static readonly short[] DFA24_accept = DFA.UnpackEncodedString(DFA24_acceptS);
    static readonly short[] DFA24_special = DFA.UnpackEncodedString(DFA24_specialS);
    static readonly short[][] DFA24_transition = DFA.UnpackEncodedStringArray(DFA24_transitionS);

    protected class DFA24 : DFA
    {
        public DFA24(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 24;
            this.eot = DFA24_eot;
            this.eof = DFA24_eof;
            this.min = DFA24_min;
            this.max = DFA24_max;
            this.accept = DFA24_accept;
            this.special = DFA24_special;
            this.transition = DFA24_transition;

        }

        override public string Description
        {
            get { return "657:0: type : ( built_in_type | defined_type | selection_type | macros_type | smi_type );"; }
        }

    }

    const string DFA25_eotS =
        "\x12\xFFFF";
    const string DFA25_eofS =
        "\x12\xFFFF";
    const string DFA25_minS =
        "\x1\xD\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA25_maxS =
        "\x1\x77\x5\xFFFF\x1\x0\x2\xFFFF\x1\x0\x8\xFFFF";
    const string DFA25_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\xFFFF\x2\x6\x1\xFFFF"+
        "\x2\xA\x1\xC\x1\xD\x1\x7\x1\x8\x1\x9\x1\xB";
    const string DFA25_specialS =
        "\x1\x0\x5\xFFFF\x1\x1\x2\xFFFF\x1\x2\x8\xFFFF}>";
    static readonly string[] DFA25_transitionS = {
            "\x1\xB\x8\xFFFF\x1\x4\x1C\xFFFF\x1\x2\x4\xFFFF\x1\xA\xC\xFFFF"+
            "\x1\x9\x4\xFFFF\x1\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\xC\xFFFF"+
            "\x1\xC\x13\xFFFF\x1\x1\x5\xFFFF\x1\x5",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA25_eot = DFA.UnpackEncodedString(DFA25_eotS);
    static readonly short[] DFA25_eof = DFA.UnpackEncodedString(DFA25_eofS);
    static readonly char[] DFA25_min = DFA.UnpackEncodedStringToUnsignedChars(DFA25_minS);
    static readonly char[] DFA25_max = DFA.UnpackEncodedStringToUnsignedChars(DFA25_maxS);
    static readonly short[] DFA25_accept = DFA.UnpackEncodedString(DFA25_acceptS);
    static readonly short[] DFA25_special = DFA.UnpackEncodedString(DFA25_specialS);
    static readonly short[][] DFA25_transition = DFA.UnpackEncodedStringArray(DFA25_transitionS);

    protected class DFA25 : DFA
    {
        public DFA25(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 25;
            this.eot = DFA25_eot;
            this.eof = DFA25_eof;
            this.min = DFA25_min;
            this.max = DFA25_max;
            this.accept = DFA25_accept;
            this.special = DFA25_special;
            this.transition = DFA25_transition;

        }

        override public string Description
        {
            get { return "659:0: value : (=> TRUE_KW |=> FALSE_KW |=> NULL_KW |=> C_STRING |=> defined_value |=> signed_number |=> choice_value |=> sequence_value |=> sequenceof_value |=> cstr_value |=> obj_id_comp_lst |=> PLUS_INFINITY_KW |=> MINUS_INFINITY_KW );"; }
        }

    }


    protected internal int DFA25_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA25_0 = input.LA(1);

                   	 
                   	int index25_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA25_0 == TRUE_KW) && (synpred3_Smi()) ) { s = 1; }

                   	else if ( (LA25_0 == FALSE_KW) && (synpred4_Smi()) ) { s = 2; }

                   	else if ( (LA25_0 == NULL_KW) && (synpred5_Smi()) ) { s = 3; }

                   	else if ( (LA25_0 == C_STRING) && (synpred6_Smi()) ) { s = 4; }

                   	else if ( (LA25_0 == UPPER) && (synpred7_Smi()) ) { s = 5; }

                   	else if ( (LA25_0 == LOWER) ) { s = 6; }

                   	else if ( (LA25_0 == MINUS) && (synpred8_Smi()) ) { s = 7; }

                   	else if ( (LA25_0 == NUMBER) && (synpred8_Smi()) ) { s = 8; }

                   	else if ( (LA25_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA25_0 == H_STRING) && (synpred12_Smi()) ) { s = 10; }

                   	else if ( (LA25_0 == B_STRING) && (synpred12_Smi()) ) { s = 11; }

                   	else if ( (LA25_0 == PLUS_INFINITY_KW) && (synpred14_Smi()) ) { s = 12; }

                   	else if ( (LA25_0 == MINUS_INFINITY_KW) && (synpred15_Smi()) ) { s = 13; }

                   	 
                   	input.Seek(index25_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA25_6 = input.LA(1);

                   	 
                   	int index25_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred7_Smi()) ) { s = 5; }

                   	else if ( (synpred9_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index25_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA25_9 = input.LA(1);

                   	 
                   	int index25_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred10_Smi()) ) { s = 15; }

                   	else if ( (synpred11_Smi()) ) { s = 16; }

                   	else if ( (synpred12_Smi()) ) { s = 11; }

                   	else if ( (synpred13_Smi()) ) { s = 17; }

                   	 
                   	input.Seek(index25_9);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae25 =
            new NoViableAltException(dfa.Description, 25, _s, input);
        dfa.Error(nvae25);
        throw nvae25;
    }
    const string DFA26_eotS =
        "\x16\xFFFF";
    const string DFA26_eofS =
        "\x16\xFFFF";
    const string DFA26_minS =
        "\x1\x7\xE\xFFFF\x2\x45\x5\xFFFF";
    const string DFA26_maxS =
        "\x1\xB3\xE\xFFFF\x2\x6B\x5\xFFFF";
    const string DFA26_acceptS =
        "\x1\xFFFF\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9"+
        "\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x2\xFFFF\x1\x13\x1\xF\x1\x10\x1\x11"+
        "\x1\x12";
    const string DFA26_specialS =
        "\x16\xFFFF}>";
    static readonly string[] DFA26_transitionS = {
            "\x1\x1\xA\xFFFF\x1\x2\x1\x4\x1\x3\x2\xFFFF\x1\x4\x2\xFFFF\x1"+
            "\x5\xD\xFFFF\x1\x6\x1\xFFFF\x1\x7\x7\xFFFF\x1\x8\x2\xFFFF\x3"+
            "\x4\x2\xFFFF\x1\x4\x6\xFFFF\x1\x9\x2\xFFFF\x1\x4\x1\xFFFF\x1"+
            "\x11\x8\xFFFF\x1\xA\x1\xFFFF\x1\x4\x1\xFFFF\x1\xB\x1\xC\xA\xFFFF"+
            "\x1\x4\x4\xFFFF\x1\xD\x3\xFFFF\x1\xF\x1\x10\x4\xFFFF\x1\x4\x1"+
            "\xFFFF\x1\x4\x5\xFFFF\x1\x4\x1\xFFFF\x4\x4\x37\xFFFF\x1\xE",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x12\xF\xFFFF\x1\x13\x15\xFFFF\x1\x13",
            "\x1\x14\xF\xFFFF\x1\x15\x15\xFFFF\x1\x15",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA26_eot = DFA.UnpackEncodedString(DFA26_eotS);
    static readonly short[] DFA26_eof = DFA.UnpackEncodedString(DFA26_eofS);
    static readonly char[] DFA26_min = DFA.UnpackEncodedStringToUnsignedChars(DFA26_minS);
    static readonly char[] DFA26_max = DFA.UnpackEncodedStringToUnsignedChars(DFA26_maxS);
    static readonly short[] DFA26_accept = DFA.UnpackEncodedString(DFA26_acceptS);
    static readonly short[] DFA26_special = DFA.UnpackEncodedString(DFA26_specialS);
    static readonly short[][] DFA26_transition = DFA.UnpackEncodedStringArray(DFA26_transitionS);

    protected class DFA26 : DFA
    {
        public DFA26(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 26;
            this.eot = DFA26_eot;
            this.eof = DFA26_eof;
            this.min = DFA26_min;
            this.max = DFA26_max;
            this.accept = DFA26_accept;
            this.special = DFA26_special;
            this.transition = DFA26_transition;

        }

        override public string Description
        {
            get { return "673:0: built_in_type : ( any_type | bit_string_type | boolean_type | character_str_type | choice_type | embedded_type EMBEDDED_KW PDV_KW | enum_type | external_type | integer_type | null_type | object_identifier_type | octetString_type | real_type | relativeOid_type | sequence_type | sequenceof_type | set_type | setof_type | tagged_type );"; }
        }

    }

    const string DFA47_eotS =
        "\x24\xFFFF";
    const string DFA47_eofS =
        "\x24\xFFFF";
    const string DFA47_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA47_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA47_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA47_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA47_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA47_eot = DFA.UnpackEncodedString(DFA47_eotS);
    static readonly short[] DFA47_eof = DFA.UnpackEncodedString(DFA47_eofS);
    static readonly char[] DFA47_min = DFA.UnpackEncodedStringToUnsignedChars(DFA47_minS);
    static readonly char[] DFA47_max = DFA.UnpackEncodedStringToUnsignedChars(DFA47_maxS);
    static readonly short[] DFA47_accept = DFA.UnpackEncodedString(DFA47_acceptS);
    static readonly short[] DFA47_special = DFA.UnpackEncodedString(DFA47_specialS);
    static readonly short[][] DFA47_transition = DFA.UnpackEncodedStringArray(DFA47_transitionS);

    protected class DFA47 : DFA
    {
        public DFA47(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 47;
            this.eot = DFA47_eot;
            this.eof = DFA47_eof;
            this.min = DFA47_min;
            this.max = DFA47_max;
            this.accept = DFA47_accept;
            this.special = DFA47_special;
            this.transition = DFA47_transition;

        }

        override public string Description
        {
            get { return "760:43: (=> LOWER )?"; }
        }

    }


    protected internal int DFA47_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA47_1 = input.LA(1);

                   	 
                   	int index47_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA47_1 == LESS) ) { s = 2; }

                   	else if ( (LA47_1 == ANY_KW) && (synpred18_Smi()) ) { s = 3; }

                   	else if ( (LA47_1 == BIT_KW) && (synpred18_Smi()) ) { s = 4; }

                   	else if ( (LA47_1 == BOOLEAN_KW) && (synpred18_Smi()) ) { s = 5; }

                   	else if ( (LA47_1 == CHARACTER_KW) && (synpred18_Smi()) ) { s = 6; }

                   	else if ( (LA47_1 == BMP_STR_KW || (LA47_1 >= GENERAL_STR_KW && LA47_1 <= GRAPHIC_STR_KW) || LA47_1 == IA5_STRING_KW || LA47_1 == ISO646_STR_KW || LA47_1 == NUMERIC_STR_KW || LA47_1 == PRINTABLE_STR_KW || LA47_1 == T61_STR_KW || LA47_1 == TELETEX_STR_KW || LA47_1 == UNIVERSAL_STR_KW || (LA47_1 >= UTC_TIME_KW && LA47_1 <= VISIBLE_STR_KW)) && (synpred18_Smi()) ) { s = 7; }

                   	else if ( (LA47_1 == CHOICE_KW) && (synpred18_Smi()) ) { s = 8; }

                   	else if ( (LA47_1 == EMBEDDED_KW) && (synpred18_Smi()) ) { s = 9; }

                   	else if ( (LA47_1 == ENUMERATED_KW) && (synpred18_Smi()) ) { s = 10; }

                   	else if ( (LA47_1 == EXTERNAL_KW) && (synpred18_Smi()) ) { s = 11; }

                   	else if ( (LA47_1 == INTEGER_KW) && (synpred18_Smi()) ) { s = 12; }

                   	else if ( (LA47_1 == NULL_KW) && (synpred18_Smi()) ) { s = 13; }

                   	else if ( (LA47_1 == OBJECT_KW) && (synpred18_Smi()) ) { s = 14; }

                   	else if ( (LA47_1 == OCTET_KW) && (synpred18_Smi()) ) { s = 15; }

                   	else if ( (LA47_1 == REAL_KW) && (synpred18_Smi()) ) { s = 16; }

                   	else if ( (LA47_1 == 179) && (synpred18_Smi()) ) { s = 17; }

                   	else if ( (LA47_1 == SEQUENCE_KW) && (synpred18_Smi()) ) { s = 18; }

                   	else if ( (LA47_1 == SET_KW) && (synpred18_Smi()) ) { s = 19; }

                   	else if ( (LA47_1 == L_BRACKET) && (synpred18_Smi()) ) { s = 20; }

                   	else if ( (LA47_1 == UPPER) && (synpred18_Smi()) ) { s = 21; }

                   	else if ( (LA47_1 == LOWER) && (synpred18_Smi()) ) { s = 22; }

                   	else if ( (LA47_1 == OPERATION_KW) && (synpred18_Smi()) ) { s = 23; }

                   	else if ( (LA47_1 == ERROR_KW) && (synpred18_Smi()) ) { s = 24; }

                   	else if ( (LA47_1 == 166) && (synpred18_Smi()) ) { s = 25; }

                   	else if ( (LA47_1 == 159) && (synpred18_Smi()) ) { s = 26; }

                   	else if ( (LA47_1 == 164) && (synpred18_Smi()) ) { s = 27; }

                   	else if ( (LA47_1 == 162) && (synpred18_Smi()) ) { s = 28; }

                   	else if ( (LA47_1 == 188) && (synpred18_Smi()) ) { s = 29; }

                   	else if ( (LA47_1 == 163) && (synpred18_Smi()) ) { s = 30; }

                   	else if ( (LA47_1 == 160) && (synpred18_Smi()) ) { s = 31; }

                   	else if ( (LA47_1 == 158) && (synpred18_Smi()) ) { s = 32; }

                   	else if ( (LA47_1 == 131) && (synpred18_Smi()) ) { s = 33; }

                   	else if ( (LA47_1 == 191) && (synpred18_Smi()) ) { s = 34; }

                   	else if ( (LA47_1 == 137) && (synpred18_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index47_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae47 =
            new NoViableAltException(dfa.Description, 47, _s, input);
        dfa.Error(nvae47);
        throw nvae47;
    }
    const string DFA50_eotS =
        "\x54\xFFFF";
    const string DFA50_eofS =
        "\x1\x22\x53\xFFFF";
    const string DFA50_minS =
        "\x1\x7\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA50_maxS =
        "\x1\xC5\x1\x0\xB\xFFFF\x1\x0\x6\xFFFF\xD\x0\x33\xFFFF";
    const string DFA50_acceptS =
        "\x2\xFFFF\xB\x1\x1\xFFFF\x6\x1\xD\xFFFF\x1\x1\x1\x2\x31\xFFFF";
    const string DFA50_specialS =
        "\x1\x0\x1\x1\xB\xFFFF\x1\x2\x6\xFFFF\x1\x3\x1\x4\x1\x5\x1\x6\x1"+
        "\x7\x1\x8\x1\x9\x1\xA\x1\xB\x1\xC\x1\xD\x1\xE\x1\xF\x33\xFFFF}>";
    static readonly string[] DFA50_transitionS = {
            "\x1\x2\x2\xFFFF\x1\x22\x3\xFFFF\x1\x22\x3\xFFFF\x1\x3\x1\x6"+
            "\x1\x4\x2\xFFFF\x1\x5\x2\xFFFF\x1\x7\x1\xFFFF\x2\x22\x4\xFFFF"+
            "\x1\x22\x5\xFFFF\x1\x8\x1\x22\x1\x9\x1\x16\x3\x22\x3\xFFFF\x1"+
            "\xA\x2\xFFFF\x3\x6\x2\xFFFF\x1\x6\x6\xFFFF\x1\xB\x2\x22\x1\x6"+
            "\x1\xFFFF\x1\x13\x2\xFFFF\x1\x22\x1\x1\x4\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xD\x1\xE\x2\xFFFF\x1\x15\x1\x22\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\xF\x1\xFFFF\x1\x22"+
            "\x1\xFFFF\x1\x11\x1\x12\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x6\x1\x14\x4\x6\x2\xFFFF\x5\x22\x1\x1F\x3"+
            "\x22\x1\xFFFF\x1\x22\x1\x21\x1\xFFFF\x3\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x3\x22\x6\xFFFF\x2\x22\x1\xFFFF\x1\x1E\x1\x18\x1\x1D"+
            "\x1\xFFFF\x1\x1A\x1\x1C\x1\x19\x1\xFFFF\x1\x17\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\x1\xFFFF\x1\x22\x1\xFFFF\x1\x22\x1\x10\x1\xFFFF"+
            "\x4\x22\x3\xFFFF\x1\x1B\x2\x22\x1\x20\x1\x22\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x1\x22",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA50_eot = DFA.UnpackEncodedString(DFA50_eotS);
    static readonly short[] DFA50_eof = DFA.UnpackEncodedString(DFA50_eofS);
    static readonly char[] DFA50_min = DFA.UnpackEncodedStringToUnsignedChars(DFA50_minS);
    static readonly char[] DFA50_max = DFA.UnpackEncodedStringToUnsignedChars(DFA50_maxS);
    static readonly short[] DFA50_accept = DFA.UnpackEncodedString(DFA50_acceptS);
    static readonly short[] DFA50_special = DFA.UnpackEncodedString(DFA50_specialS);
    static readonly short[][] DFA50_transition = DFA.UnpackEncodedStringArray(DFA50_transitionS);

    protected class DFA50 : DFA
    {
        public DFA50(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 50;
            this.eot = DFA50_eot;
            this.eof = DFA50_eof;
            this.min = DFA50_min;
            this.max = DFA50_max;
            this.accept = DFA50_accept;
            this.special = DFA50_special;
            this.transition = DFA50_transition;

        }

        override public string Description
        {
            get { return "762:25: (=> (=> LOWER )? type )?"; }
        }

    }


    protected internal int DFA50_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA50_0 = input.LA(1);

                   	 
                   	int index50_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA50_0 == LOWER) ) { s = 1; }

                   	else if ( (LA50_0 == ANY_KW) && (synpred20_Smi()) ) { s = 2; }

                   	else if ( (LA50_0 == BIT_KW) && (synpred20_Smi()) ) { s = 3; }

                   	else if ( (LA50_0 == BOOLEAN_KW) && (synpred20_Smi()) ) { s = 4; }

                   	else if ( (LA50_0 == CHARACTER_KW) && (synpred20_Smi()) ) { s = 5; }

                   	else if ( (LA50_0 == BMP_STR_KW || (LA50_0 >= GENERAL_STR_KW && LA50_0 <= GRAPHIC_STR_KW) || LA50_0 == IA5_STRING_KW || LA50_0 == ISO646_STR_KW || LA50_0 == NUMERIC_STR_KW || LA50_0 == PRINTABLE_STR_KW || LA50_0 == T61_STR_KW || LA50_0 == TELETEX_STR_KW || LA50_0 == UNIVERSAL_STR_KW || (LA50_0 >= UTC_TIME_KW && LA50_0 <= VISIBLE_STR_KW)) && (synpred20_Smi()) ) { s = 6; }

                   	else if ( (LA50_0 == CHOICE_KW) && (synpred20_Smi()) ) { s = 7; }

                   	else if ( (LA50_0 == EMBEDDED_KW) && (synpred20_Smi()) ) { s = 8; }

                   	else if ( (LA50_0 == ENUMERATED_KW) && (synpred20_Smi()) ) { s = 9; }

                   	else if ( (LA50_0 == EXTERNAL_KW) && (synpred20_Smi()) ) { s = 10; }

                   	else if ( (LA50_0 == INTEGER_KW) && (synpred20_Smi()) ) { s = 11; }

                   	else if ( (LA50_0 == NULL_KW) && (synpred20_Smi()) ) { s = 12; }

                   	else if ( (LA50_0 == OBJECT_KW) ) { s = 13; }

                   	else if ( (LA50_0 == OCTET_KW) && (synpred20_Smi()) ) { s = 14; }

                   	else if ( (LA50_0 == REAL_KW) && (synpred20_Smi()) ) { s = 15; }

                   	else if ( (LA50_0 == 179) && (synpred20_Smi()) ) { s = 16; }

                   	else if ( (LA50_0 == SEQUENCE_KW) && (synpred20_Smi()) ) { s = 17; }

                   	else if ( (LA50_0 == SET_KW) && (synpred20_Smi()) ) { s = 18; }

                   	else if ( (LA50_0 == L_BRACKET) && (synpred20_Smi()) ) { s = 19; }

                   	else if ( (LA50_0 == UPPER) ) { s = 20; }

                   	else if ( (LA50_0 == OPERATION_KW) ) { s = 21; }

                   	else if ( (LA50_0 == ERROR_KW) ) { s = 22; }

                   	else if ( (LA50_0 == 166) ) { s = 23; }

                   	else if ( (LA50_0 == 159) ) { s = 24; }

                   	else if ( (LA50_0 == 164) ) { s = 25; }

                   	else if ( (LA50_0 == 162) ) { s = 26; }

                   	else if ( (LA50_0 == 188) ) { s = 27; }

                   	else if ( (LA50_0 == 163) ) { s = 28; }

                   	else if ( (LA50_0 == 160) ) { s = 29; }

                   	else if ( (LA50_0 == 158) ) { s = 30; }

                   	else if ( (LA50_0 == 131) ) { s = 31; }

                   	else if ( (LA50_0 == 191) ) { s = 32; }

                   	else if ( (LA50_0 == 137) && (synpred20_Smi()) ) { s = 33; }

                   	else if ( (LA50_0 == EOF || LA50_0 == ASSIGN_OP || LA50_0 == BAR || (LA50_0 >= COLON && LA50_0 <= COMMA) || LA50_0 == DEFAULT_KW || LA50_0 == END_KW || (LA50_0 >= ERRORS_KW && LA50_0 <= EXCLAMATION) || (LA50_0 >= INTERSECTION && LA50_0 <= INTERSECTION_KW) || LA50_0 == LINKED_KW || LA50_0 == OPTIONAL_KW || LA50_0 == R_BRACE || LA50_0 == R_PAREN || LA50_0 == RESULT_KW || LA50_0 == UNION_KW || (LA50_0 >= 126 && LA50_0 <= 130) || (LA50_0 >= 132 && LA50_0 <= 134) || LA50_0 == 136 || (LA50_0 >= 139 && LA50_0 <= 141) || LA50_0 == 143 || (LA50_0 >= 146 && LA50_0 <= 148) || (LA50_0 >= 155 && LA50_0 <= 156) || LA50_0 == 168 || (LA50_0 >= 171 && LA50_0 <= 174) || LA50_0 == 176 || LA50_0 == 178 || (LA50_0 >= 181 && LA50_0 <= 184) || (LA50_0 >= 189 && LA50_0 <= 190) || LA50_0 == 192 || LA50_0 == 194 || LA50_0 == 197) ) { s = 34; }

                   	 
                   	input.Seek(index50_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA50_1 = input.LA(1);

                   	 
                   	int index50_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA50_13 = input.LA(1);

                   	 
                   	int index50_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_13);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA50_20 = input.LA(1);

                   	 
                   	int index50_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA50_21 = input.LA(1);

                   	 
                   	int index50_21 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_21);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA50_22 = input.LA(1);

                   	 
                   	int index50_22 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_22);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA50_23 = input.LA(1);

                   	 
                   	int index50_23 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_23);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA50_24 = input.LA(1);

                   	 
                   	int index50_24 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_24);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA50_25 = input.LA(1);

                   	 
                   	int index50_25 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_25);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA50_26 = input.LA(1);

                   	 
                   	int index50_26 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_26);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA50_27 = input.LA(1);

                   	 
                   	int index50_27 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_27);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA50_28 = input.LA(1);

                   	 
                   	int index50_28 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_28);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA50_29 = input.LA(1);

                   	 
                   	int index50_29 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_29);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA50_30 = input.LA(1);

                   	 
                   	int index50_30 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_30);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 14 : 
                   	int LA50_31 = input.LA(1);

                   	 
                   	int index50_31 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_31);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 15 : 
                   	int LA50_32 = input.LA(1);

                   	 
                   	int index50_32 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred20_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index50_32);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae50 =
            new NoViableAltException(dfa.Description, 50, _s, input);
        dfa.Error(nvae50);
        throw nvae50;
    }
    const string DFA49_eotS =
        "\x24\xFFFF";
    const string DFA49_eofS =
        "\x24\xFFFF";
    const string DFA49_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA49_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA49_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA49_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA49_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA49_eot = DFA.UnpackEncodedString(DFA49_eotS);
    static readonly short[] DFA49_eof = DFA.UnpackEncodedString(DFA49_eofS);
    static readonly char[] DFA49_min = DFA.UnpackEncodedStringToUnsignedChars(DFA49_minS);
    static readonly char[] DFA49_max = DFA.UnpackEncodedStringToUnsignedChars(DFA49_maxS);
    static readonly short[] DFA49_accept = DFA.UnpackEncodedString(DFA49_acceptS);
    static readonly short[] DFA49_special = DFA.UnpackEncodedString(DFA49_specialS);
    static readonly short[][] DFA49_transition = DFA.UnpackEncodedStringArray(DFA49_transitionS);

    protected class DFA49 : DFA
    {
        public DFA49(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 49;
            this.eot = DFA49_eot;
            this.eof = DFA49_eof;
            this.min = DFA49_min;
            this.max = DFA49_max;
            this.accept = DFA49_accept;
            this.special = DFA49_special;
            this.transition = DFA49_transition;

        }

        override public string Description
        {
            get { return "762:37: (=> LOWER )?"; }
        }

    }


    protected internal int DFA49_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA49_1 = input.LA(1);

                   	 
                   	int index49_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA49_1 == LESS) ) { s = 2; }

                   	else if ( (LA49_1 == ANY_KW) && (synpred21_Smi()) ) { s = 3; }

                   	else if ( (LA49_1 == BIT_KW) && (synpred21_Smi()) ) { s = 4; }

                   	else if ( (LA49_1 == BOOLEAN_KW) && (synpred21_Smi()) ) { s = 5; }

                   	else if ( (LA49_1 == CHARACTER_KW) && (synpred21_Smi()) ) { s = 6; }

                   	else if ( (LA49_1 == BMP_STR_KW || (LA49_1 >= GENERAL_STR_KW && LA49_1 <= GRAPHIC_STR_KW) || LA49_1 == IA5_STRING_KW || LA49_1 == ISO646_STR_KW || LA49_1 == NUMERIC_STR_KW || LA49_1 == PRINTABLE_STR_KW || LA49_1 == T61_STR_KW || LA49_1 == TELETEX_STR_KW || LA49_1 == UNIVERSAL_STR_KW || (LA49_1 >= UTC_TIME_KW && LA49_1 <= VISIBLE_STR_KW)) && (synpred21_Smi()) ) { s = 7; }

                   	else if ( (LA49_1 == CHOICE_KW) && (synpred21_Smi()) ) { s = 8; }

                   	else if ( (LA49_1 == EMBEDDED_KW) && (synpred21_Smi()) ) { s = 9; }

                   	else if ( (LA49_1 == ENUMERATED_KW) && (synpred21_Smi()) ) { s = 10; }

                   	else if ( (LA49_1 == EXTERNAL_KW) && (synpred21_Smi()) ) { s = 11; }

                   	else if ( (LA49_1 == INTEGER_KW) && (synpred21_Smi()) ) { s = 12; }

                   	else if ( (LA49_1 == NULL_KW) && (synpred21_Smi()) ) { s = 13; }

                   	else if ( (LA49_1 == OBJECT_KW) && (synpred21_Smi()) ) { s = 14; }

                   	else if ( (LA49_1 == OCTET_KW) && (synpred21_Smi()) ) { s = 15; }

                   	else if ( (LA49_1 == REAL_KW) && (synpred21_Smi()) ) { s = 16; }

                   	else if ( (LA49_1 == 179) && (synpred21_Smi()) ) { s = 17; }

                   	else if ( (LA49_1 == SEQUENCE_KW) && (synpred21_Smi()) ) { s = 18; }

                   	else if ( (LA49_1 == SET_KW) && (synpred21_Smi()) ) { s = 19; }

                   	else if ( (LA49_1 == L_BRACKET) && (synpred21_Smi()) ) { s = 20; }

                   	else if ( (LA49_1 == UPPER) && (synpred21_Smi()) ) { s = 21; }

                   	else if ( (LA49_1 == LOWER) && (synpred21_Smi()) ) { s = 22; }

                   	else if ( (LA49_1 == OPERATION_KW) && (synpred21_Smi()) ) { s = 23; }

                   	else if ( (LA49_1 == ERROR_KW) && (synpred21_Smi()) ) { s = 24; }

                   	else if ( (LA49_1 == 166) && (synpred21_Smi()) ) { s = 25; }

                   	else if ( (LA49_1 == 159) && (synpred21_Smi()) ) { s = 26; }

                   	else if ( (LA49_1 == 164) && (synpred21_Smi()) ) { s = 27; }

                   	else if ( (LA49_1 == 162) && (synpred21_Smi()) ) { s = 28; }

                   	else if ( (LA49_1 == 188) && (synpred21_Smi()) ) { s = 29; }

                   	else if ( (LA49_1 == 163) && (synpred21_Smi()) ) { s = 30; }

                   	else if ( (LA49_1 == 160) && (synpred21_Smi()) ) { s = 31; }

                   	else if ( (LA49_1 == 158) && (synpred21_Smi()) ) { s = 32; }

                   	else if ( (LA49_1 == 131) && (synpred21_Smi()) ) { s = 33; }

                   	else if ( (LA49_1 == 191) && (synpred21_Smi()) ) { s = 34; }

                   	else if ( (LA49_1 == 137) && (synpred21_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index49_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae49 =
            new NoViableAltException(dfa.Description, 49, _s, input);
        dfa.Error(nvae49);
        throw nvae49;
    }
    const string DFA56_eotS =
        "\x24\xFFFF";
    const string DFA56_eofS =
        "\x24\xFFFF";
    const string DFA56_minS =
        "\x2\x7\x22\xFFFF";
    const string DFA56_maxS =
        "\x2\xBF\x22\xFFFF";
    const string DFA56_acceptS =
        "\x2\xFFFF\x1\x2\x21\x1";
    const string DFA56_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA56_transitionS = {
            "\x1\x2\xA\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF\x1\x2\xD\xFFFF"+
            "\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF"+
            "\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x3\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF"+
            "\x1\x2\x7\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF"+
            "\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\xA\xFFFF\x1\x4\x1\x7\x1\x5\x2\xFFFF\x1\x6\x2\xFFFF\x1"+
            "\x8\xD\xFFFF\x1\x9\x1\xFFFF\x1\xA\x1\x18\x6\xFFFF\x1\xB\x2\xFFFF"+
            "\x3\x7\x2\xFFFF\x1\x7\x6\xFFFF\x1\xC\x2\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x14\x1\xFFFF\x1\x2\x1\xFFFF\x1\x16\x4\xFFFF\x1\xD\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\xE\x1\xF\x2\xFFFF\x1\x17\x7\xFFFF\x1\x7\x4"+
            "\xFFFF\x1\x10\x3\xFFFF\x1\x12\x1\x13\x4\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x7\x5\xFFFF\x1\x7\x1\x15\x4\x7\x7\xFFFF\x1\x21\x5\xFFFF"+
            "\x1\x23\x14\xFFFF\x1\x20\x1\x1A\x1\x1F\x1\xFFFF\x1\x1C\x1\x1E"+
            "\x1\x1B\x1\xFFFF\x1\x19\xC\xFFFF\x1\x11\x8\xFFFF\x1\x1D\x2\xFFFF"+
            "\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA56_eot = DFA.UnpackEncodedString(DFA56_eotS);
    static readonly short[] DFA56_eof = DFA.UnpackEncodedString(DFA56_eofS);
    static readonly char[] DFA56_min = DFA.UnpackEncodedStringToUnsignedChars(DFA56_minS);
    static readonly char[] DFA56_max = DFA.UnpackEncodedStringToUnsignedChars(DFA56_maxS);
    static readonly short[] DFA56_accept = DFA.UnpackEncodedString(DFA56_acceptS);
    static readonly short[] DFA56_special = DFA.UnpackEncodedString(DFA56_specialS);
    static readonly short[][] DFA56_transition = DFA.UnpackEncodedStringArray(DFA56_transitionS);

    protected class DFA56 : DFA
    {
        public DFA56(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 56;
            this.eot = DFA56_eot;
            this.eof = DFA56_eof;
            this.min = DFA56_min;
            this.max = DFA56_max;
            this.accept = DFA56_accept;
            this.special = DFA56_special;
            this.transition = DFA56_transition;

        }

        override public string Description
        {
            get { return "775:38: (=> LOWER )?"; }
        }

    }


    protected internal int DFA56_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA56_1 = input.LA(1);

                   	 
                   	int index56_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA56_1 == LESS) ) { s = 2; }

                   	else if ( (LA56_1 == ANY_KW) && (synpred24_Smi()) ) { s = 3; }

                   	else if ( (LA56_1 == BIT_KW) && (synpred24_Smi()) ) { s = 4; }

                   	else if ( (LA56_1 == BOOLEAN_KW) && (synpred24_Smi()) ) { s = 5; }

                   	else if ( (LA56_1 == CHARACTER_KW) && (synpred24_Smi()) ) { s = 6; }

                   	else if ( (LA56_1 == BMP_STR_KW || (LA56_1 >= GENERAL_STR_KW && LA56_1 <= GRAPHIC_STR_KW) || LA56_1 == IA5_STRING_KW || LA56_1 == ISO646_STR_KW || LA56_1 == NUMERIC_STR_KW || LA56_1 == PRINTABLE_STR_KW || LA56_1 == T61_STR_KW || LA56_1 == TELETEX_STR_KW || LA56_1 == UNIVERSAL_STR_KW || (LA56_1 >= UTC_TIME_KW && LA56_1 <= VISIBLE_STR_KW)) && (synpred24_Smi()) ) { s = 7; }

                   	else if ( (LA56_1 == CHOICE_KW) && (synpred24_Smi()) ) { s = 8; }

                   	else if ( (LA56_1 == EMBEDDED_KW) && (synpred24_Smi()) ) { s = 9; }

                   	else if ( (LA56_1 == ENUMERATED_KW) && (synpred24_Smi()) ) { s = 10; }

                   	else if ( (LA56_1 == EXTERNAL_KW) && (synpred24_Smi()) ) { s = 11; }

                   	else if ( (LA56_1 == INTEGER_KW) && (synpred24_Smi()) ) { s = 12; }

                   	else if ( (LA56_1 == NULL_KW) && (synpred24_Smi()) ) { s = 13; }

                   	else if ( (LA56_1 == OBJECT_KW) && (synpred24_Smi()) ) { s = 14; }

                   	else if ( (LA56_1 == OCTET_KW) && (synpred24_Smi()) ) { s = 15; }

                   	else if ( (LA56_1 == REAL_KW) && (synpred24_Smi()) ) { s = 16; }

                   	else if ( (LA56_1 == 179) && (synpred24_Smi()) ) { s = 17; }

                   	else if ( (LA56_1 == SEQUENCE_KW) && (synpred24_Smi()) ) { s = 18; }

                   	else if ( (LA56_1 == SET_KW) && (synpred24_Smi()) ) { s = 19; }

                   	else if ( (LA56_1 == L_BRACKET) && (synpred24_Smi()) ) { s = 20; }

                   	else if ( (LA56_1 == UPPER) && (synpred24_Smi()) ) { s = 21; }

                   	else if ( (LA56_1 == LOWER) && (synpred24_Smi()) ) { s = 22; }

                   	else if ( (LA56_1 == OPERATION_KW) && (synpred24_Smi()) ) { s = 23; }

                   	else if ( (LA56_1 == ERROR_KW) && (synpred24_Smi()) ) { s = 24; }

                   	else if ( (LA56_1 == 166) && (synpred24_Smi()) ) { s = 25; }

                   	else if ( (LA56_1 == 159) && (synpred24_Smi()) ) { s = 26; }

                   	else if ( (LA56_1 == 164) && (synpred24_Smi()) ) { s = 27; }

                   	else if ( (LA56_1 == 162) && (synpred24_Smi()) ) { s = 28; }

                   	else if ( (LA56_1 == 188) && (synpred24_Smi()) ) { s = 29; }

                   	else if ( (LA56_1 == 163) && (synpred24_Smi()) ) { s = 30; }

                   	else if ( (LA56_1 == 160) && (synpred24_Smi()) ) { s = 31; }

                   	else if ( (LA56_1 == 158) && (synpred24_Smi()) ) { s = 32; }

                   	else if ( (LA56_1 == 131) && (synpred24_Smi()) ) { s = 33; }

                   	else if ( (LA56_1 == 191) && (synpred24_Smi()) ) { s = 34; }

                   	else if ( (LA56_1 == 137) && (synpred24_Smi()) ) { s = 35; }

                   	 
                   	input.Seek(index56_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae56 =
            new NoViableAltException(dfa.Description, 56, _s, input);
        dfa.Error(nvae56);
        throw nvae56;
    }
    const string DFA67_eotS =
        "\xB\xFFFF";
    const string DFA67_eofS =
        "\xB\xFFFF";
    const string DFA67_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA67_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA67_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA67_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA67_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA67_eot = DFA.UnpackEncodedString(DFA67_eotS);
    static readonly short[] DFA67_eof = DFA.UnpackEncodedString(DFA67_eofS);
    static readonly char[] DFA67_min = DFA.UnpackEncodedStringToUnsignedChars(DFA67_minS);
    static readonly char[] DFA67_max = DFA.UnpackEncodedStringToUnsignedChars(DFA67_maxS);
    static readonly short[] DFA67_accept = DFA.UnpackEncodedString(DFA67_acceptS);
    static readonly short[] DFA67_special = DFA.UnpackEncodedString(DFA67_specialS);
    static readonly short[][] DFA67_transition = DFA.UnpackEncodedStringArray(DFA67_transitionS);

    protected class DFA67 : DFA
    {
        public DFA67(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 67;
            this.eot = DFA67_eot;
            this.eof = DFA67_eof;
            this.min = DFA67_min;
            this.max = DFA67_max;
            this.accept = DFA67_accept;
            this.special = DFA67_special;
            this.transition = DFA67_transition;

        }

        override public string Description
        {
            get { return "806:21: (=> smi_type objecttype_macro_namedbits |=> smi_type ( smi_subtyping )? | type )"; }
        }

    }


    protected internal int DFA67_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA67_1 = input.LA(1);

                   	 
                   	int index67_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA67_1 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index67_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA67_2 = input.LA(1);

                   	 
                   	int index67_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA67_2 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index67_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA67_5 = input.LA(1);

                   	 
                   	int index67_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA67_5 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index67_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA67_9 = input.LA(1);

                   	 
                   	int index67_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA67_9 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index67_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA67_10 = input.LA(1);

                   	 
                   	int index67_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA67_10 == L_BRACE) && (synpred25_Smi()) ) { s = 7; }

                   	else if ( (synpred26_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index67_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae67 =
            new NoViableAltException(dfa.Description, 67, _s, input);
        dfa.Error(nvae67);
        throw nvae67;
    }
    const string DFA76_eotS =
        "\x3F\xFFFF";
    const string DFA76_eofS =
        "\x1\x5\x3E\xFFFF";
    const string DFA76_minS =
        "\x1\xA\x1\x0\x3D\xFFFF";
    const string DFA76_maxS =
        "\x1\xC5\x1\x0\x3D\xFFFF";
    const string DFA76_acceptS =
        "\x2\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x38\xFFFF\x1\x1";
    const string DFA76_specialS =
        "\x1\xFFFF\x1\x0\x3D\xFFFF}>";
    static readonly string[] DFA76_transitionS = {
            "\x1\x5\x3\xFFFF\x1\x5\xD\xFFFF\x2\x5\x4\xFFFF\x1\x5\x6\xFFFF"+
            "\x1\x5\x1\xFFFF\x4\x5\x13\xFFFF\x2\x5\x5\xFFFF\x2\x5\x8\xFFFF"+
            "\x1\x5\x3\xFFFF\x2\x5\x8\xFFFF\x1\x5\x1\xFFFF\x1\x5\x2\xFFFF"+
            "\x1\x5\xC\xFFFF\x1\x5\x3\xFFFF\x1\x5\x6\xFFFF\x9\x5\x1\x2\x1"+
            "\x5\x2\xFFFF\x3\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x4\x3\x5\x1\xFFFF"+
            "\x1\x1\x4\xFFFF\x2\x5\x1\xFFFF\x3\x5\x1\xFFFF\x3\x5\x1\xFFFF"+
            "\x1\x5\x1\xFFFF\x1\x5\x1\xFFFF\x1\x3\x4\x5\x1\xFFFF\x1\x5\x1"+
            "\xFFFF\x1\x5\x2\xFFFF\x4\x5\x3\xFFFF\x7\x5\x2\xFFFF\x1\x5",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA76_eot = DFA.UnpackEncodedString(DFA76_eotS);
    static readonly short[] DFA76_eof = DFA.UnpackEncodedString(DFA76_eofS);
    static readonly char[] DFA76_min = DFA.UnpackEncodedStringToUnsignedChars(DFA76_minS);
    static readonly char[] DFA76_max = DFA.UnpackEncodedStringToUnsignedChars(DFA76_maxS);
    static readonly short[] DFA76_accept = DFA.UnpackEncodedString(DFA76_acceptS);
    static readonly short[] DFA76_special = DFA.UnpackEncodedString(DFA76_specialS);
    static readonly short[][] DFA76_transition = DFA.UnpackEncodedStringArray(DFA76_transitionS);

    protected class DFA76 : DFA
    {
        public DFA76(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 76;
            this.eot = DFA76_eot;
            this.eof = DFA76_eof;
            this.min = DFA76_min;
            this.max = DFA76_max;
            this.accept = DFA76_accept;
            this.special = DFA76_special;
            this.transition = DFA76_transition;

        }

        override public string Description
        {
            get { return "819:5: (=> 'INDEX' objecttype_macro_index | 'AUGMENTS' objecttype_macro_augments | 'PIB-INDEX' L_BRACE value R_BRACE | 'EXTENDS' L_BRACE value R_BRACE )?"; }
        }

    }


    protected internal int DFA76_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA76_1 = input.LA(1);

                   	 
                   	int index76_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred28_Smi()) ) { s = 62; }

                   	else if ( (true) ) { s = 5; }

                   	 
                   	input.Seek(index76_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae76 =
            new NoViableAltException(dfa.Description, 76, _s, input);
        dfa.Error(nvae76);
        throw nvae76;
    }
    const string DFA82_eotS =
        "\x3A\xFFFF";
    const string DFA82_eofS =
        "\x1\x2\x39\xFFFF";
    const string DFA82_minS =
        "\x1\xA\x1\x0\x38\xFFFF";
    const string DFA82_maxS =
        "\x1\xC5\x1\x0\x38\xFFFF";
    const string DFA82_acceptS =
        "\x2\xFFFF\x1\x2\x36\xFFFF\x1\x1";
    const string DFA82_specialS =
        "\x1\xFFFF\x1\x0\x38\xFFFF}>";
    static readonly string[] DFA82_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\x1\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3"+
            "\x2\x6\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1"+
            "\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1"+
            "\x2\x2\xFFFF\x4\x2\x3\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA82_eot = DFA.UnpackEncodedString(DFA82_eotS);
    static readonly short[] DFA82_eof = DFA.UnpackEncodedString(DFA82_eofS);
    static readonly char[] DFA82_min = DFA.UnpackEncodedStringToUnsignedChars(DFA82_minS);
    static readonly char[] DFA82_max = DFA.UnpackEncodedStringToUnsignedChars(DFA82_maxS);
    static readonly short[] DFA82_accept = DFA.UnpackEncodedString(DFA82_acceptS);
    static readonly short[] DFA82_special = DFA.UnpackEncodedString(DFA82_specialS);
    static readonly short[][] DFA82_transition = DFA.UnpackEncodedStringArray(DFA82_transitionS);

    protected class DFA82 : DFA
    {
        public DFA82(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 82;
            this.eot = DFA82_eot;
            this.eof = DFA82_eof;
            this.min = DFA82_min;
            this.max = DFA82_max;
            this.accept = DFA82_accept;
            this.special = DFA82_special;
            this.transition = DFA82_transition;

        }

        override public string Description
        {
            get { return "826:5: (=> 'DEFVAL' L_BRACE (=> objecttype_macro_bitsvalue | value ) R_BRACE )?"; }
        }

    }


    protected internal int DFA82_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA82_1 = input.LA(1);

                   	 
                   	int index82_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred29_Smi()) ) { s = 57; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index82_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae82 =
            new NoViableAltException(dfa.Description, 82, _s, input);
        dfa.Error(nvae82);
        throw nvae82;
    }
    const string DFA81_eotS =
        "\xA\xFFFF";
    const string DFA81_eofS =
        "\xA\xFFFF";
    const string DFA81_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\xFFFF\x1\x0\x1\xD";
    const string DFA81_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\xFFFF\x1\x0\x1\x77";
    const string DFA81_acceptS =
        "\x2\xFFFF\x1\x2\x4\xFFFF\x1\x1\x2\xFFFF";
    const string DFA81_specialS =
        "\x5\xFFFF\x1\x0\x2\xFFFF\x1\x1\x1\xFFFF}>";
    static readonly string[] DFA81_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x2\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x2\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x4\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x9\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\x8\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x6\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA81_eot = DFA.UnpackEncodedString(DFA81_eotS);
    static readonly short[] DFA81_eof = DFA.UnpackEncodedString(DFA81_eofS);
    static readonly char[] DFA81_min = DFA.UnpackEncodedStringToUnsignedChars(DFA81_minS);
    static readonly char[] DFA81_max = DFA.UnpackEncodedStringToUnsignedChars(DFA81_maxS);
    static readonly short[] DFA81_accept = DFA.UnpackEncodedString(DFA81_acceptS);
    static readonly short[] DFA81_special = DFA.UnpackEncodedString(DFA81_specialS);
    static readonly short[][] DFA81_transition = DFA.UnpackEncodedStringArray(DFA81_transitionS);

    protected class DFA81 : DFA
    {
        public DFA81(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 81;
            this.eot = DFA81_eot;
            this.eof = DFA81_eof;
            this.min = DFA81_min;
            this.max = DFA81_max;
            this.accept = DFA81_accept;
            this.special = DFA81_special;
            this.transition = DFA81_transition;

        }

        override public string Description
        {
            get { return "827:21: (=> objecttype_macro_bitsvalue | value )"; }
        }

    }


    protected internal int DFA81_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA81_5 = input.LA(1);

                   	 
                   	int index81_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index81_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA81_8 = input.LA(1);

                   	 
                   	int index81_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred30_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index81_8);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae81 =
            new NoViableAltException(dfa.Description, 81, _s, input);
        dfa.Error(nvae81);
        throw nvae81;
    }
    const string DFA98_eotS =
        "\x17\xFFFF";
    const string DFA98_eofS =
        "\x1\xFFFF\x2\x6\x2\xFFFF\x1\x6\x3\xFFFF\x2\x6\xC\xFFFF";
    const string DFA98_minS =
        "\x1\x7\x2\xA\x1\x6D\x1\x3B\x1\xA\x2\xFFFF\x1\x4A\x2\xA\x1\x47\x1"+
        "\x4A\x1\x50\x1\x63\x1\x1D\x1\x4A\x1\x0\x1\x47\x1\x4A\x1\x50\x1\x63"+
        "\x1\x1D";
    const string DFA98_maxS =
        "\x1\xBF\x2\xC5\x1\x6D\x1\x3B\x1\xC5\x2\xFFFF\x1\x4A\x2\xC5\x1\x47"+
        "\x1\x77\x1\x50\x1\x63\x1\x61\x1\x4A\x1\x0\x1\x47\x1\x77\x1\x50\x1"+
        "\x63\x1\x61";
    const string DFA98_acceptS =
        "\x6\xFFFF\x1\x2\x1\x1\xF\xFFFF";
    const string DFA98_specialS =
        "\x1\xFFFF\x1\x0\x3\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\x3\x6\xFFFF\x1"+
        "\x4\x5\xFFFF}>";
    static readonly string[] DFA98_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x8\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x9",
            "\x1\xA",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF"+
            "\x1\x7\x1\xFFFF\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF"+
            "\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF"+
            "\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "",
            "",
            "\x1\xB",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x6\xFFFF\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x3\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x6\x3\xFFFF\x1\x6\xD\xFFFF\x2\x6\x4\xFFFF\x1\x6\x6\xFFFF"+
            "\x1\x6\x1\xFFFF\x4\x6\x13\xFFFF\x2\x6\x1\xFFFF\x1\x7\x3\xFFFF"+
            "\x2\x6\x8\xFFFF\x1\x6\x3\xFFFF\x2\x6\x8\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x1\x6\xC\xFFFF\x1\x6\x3\xFFFF\x1\x6\x6\xFFFF"+
            "\x9\x6\x1\xFFFF\x1\x6\x2\xFFFF\x3\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x3\x6\x6\xFFFF\x2\x6\x1\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\x6\x2\xFFFF\x4\x6\x1\xFFFF\x1\x6\x1\xFFFF"+
            "\x1\x6\x2\xFFFF\x4\x6\x3\xFFFF\x5\x6\x1\xFFFF\x1\x6\x2\xFFFF"+
            "\x1\x6",
            "\x1\xC",
            "\x1\x6\x2\xFFFF\x1\xD\x2\xFFFF\x1\xE\x26\xFFFF\x1\x6",
            "\x1\xE",
            "\x1\xF",
            "\x1\x10\x43\xFFFF\x1\x11",
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\x13",
            "\x1\x6\x2\xFFFF\x1\x14\x2\xFFFF\x1\x15\x26\xFFFF\x1\x6",
            "\x1\x15",
            "\x1\x16",
            "\x1\x10\x43\xFFFF\x1\x11"
    };

    static readonly short[] DFA98_eot = DFA.UnpackEncodedString(DFA98_eotS);
    static readonly short[] DFA98_eof = DFA.UnpackEncodedString(DFA98_eofS);
    static readonly char[] DFA98_min = DFA.UnpackEncodedStringToUnsignedChars(DFA98_minS);
    static readonly char[] DFA98_max = DFA.UnpackEncodedStringToUnsignedChars(DFA98_maxS);
    static readonly short[] DFA98_accept = DFA.UnpackEncodedString(DFA98_acceptS);
    static readonly short[] DFA98_special = DFA.UnpackEncodedString(DFA98_specialS);
    static readonly short[][] DFA98_transition = DFA.UnpackEncodedStringArray(DFA98_transitionS);

    protected class DFA98 : DFA
    {
        public DFA98(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 98;
            this.eot = DFA98_eot;
            this.eof = DFA98_eof;
            this.min = DFA98_min;
            this.max = DFA98_max;
            this.accept = DFA98_accept;
            this.special = DFA98_special;
            this.transition = DFA98_transition;

        }

        override public string Description
        {
            get { return "891:38: (=> smi_type L_BRACE textualconvention_macro_namedbit ( COMMA textualconvention_macro_namedbit )* R_BRACE | type )"; }
        }

    }


    protected internal int DFA98_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA98_1 = input.LA(1);

                   	 
                   	int index98_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA98_1 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA98_1 == EOF || LA98_1 == ASSIGN_OP || LA98_1 == BAR || (LA98_1 >= COLON && LA98_1 <= COMMA) || LA98_1 == DEFAULT_KW || LA98_1 == END_KW || (LA98_1 >= ERROR_KW && LA98_1 <= EXCLAMATION) || (LA98_1 >= INTERSECTION && LA98_1 <= INTERSECTION_KW) || (LA98_1 >= LINKED_KW && LA98_1 <= LOWER) || LA98_1 == OBJECT_KW || (LA98_1 >= OPERATION_KW && LA98_1 <= OPTIONAL_KW) || LA98_1 == R_BRACE || LA98_1 == R_PAREN || LA98_1 == RESULT_KW || LA98_1 == UNION_KW || LA98_1 == UPPER || (LA98_1 >= 126 && LA98_1 <= 134) || LA98_1 == 136 || (LA98_1 >= 139 && LA98_1 <= 141) || LA98_1 == 143 || (LA98_1 >= 146 && LA98_1 <= 148) || (LA98_1 >= 155 && LA98_1 <= 156) || (LA98_1 >= 158 && LA98_1 <= 160) || (LA98_1 >= 162 && LA98_1 <= 164) || LA98_1 == 166 || LA98_1 == 168 || (LA98_1 >= 171 && LA98_1 <= 174) || LA98_1 == 176 || LA98_1 == 178 || (LA98_1 >= 181 && LA98_1 <= 184) || (LA98_1 >= 188 && LA98_1 <= 192) || LA98_1 == 194 || LA98_1 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index98_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA98_5 = input.LA(1);

                   	 
                   	int index98_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA98_5 == EOF || LA98_5 == ASSIGN_OP || LA98_5 == BAR || (LA98_5 >= COLON && LA98_5 <= COMMA) || LA98_5 == DEFAULT_KW || LA98_5 == DOT || LA98_5 == END_KW || (LA98_5 >= ERROR_KW && LA98_5 <= EXCLAMATION) || (LA98_5 >= INTERSECTION && LA98_5 <= INTERSECTION_KW) || LA98_5 == L_PAREN || (LA98_5 >= LINKED_KW && LA98_5 <= LOWER) || LA98_5 == OBJECT_KW || (LA98_5 >= OPERATION_KW && LA98_5 <= OPTIONAL_KW) || LA98_5 == R_BRACE || LA98_5 == R_PAREN || LA98_5 == RESULT_KW || LA98_5 == UNION_KW || LA98_5 == UPPER || (LA98_5 >= 126 && LA98_5 <= 134) || LA98_5 == 136 || (LA98_5 >= 139 && LA98_5 <= 141) || LA98_5 == 143 || (LA98_5 >= 146 && LA98_5 <= 148) || (LA98_5 >= 155 && LA98_5 <= 156) || (LA98_5 >= 158 && LA98_5 <= 160) || (LA98_5 >= 162 && LA98_5 <= 164) || LA98_5 == 166 || LA98_5 == 168 || (LA98_5 >= 171 && LA98_5 <= 174) || LA98_5 == 176 || LA98_5 == 178 || (LA98_5 >= 181 && LA98_5 <= 184) || (LA98_5 >= 188 && LA98_5 <= 192) || LA98_5 == 194 || LA98_5 == 197) ) { s = 6; }

                   	else if ( (LA98_5 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	 
                   	input.Seek(index98_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA98_9 = input.LA(1);

                   	 
                   	int index98_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA98_9 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA98_9 == EOF || LA98_9 == ASSIGN_OP || LA98_9 == BAR || (LA98_9 >= COLON && LA98_9 <= COMMA) || LA98_9 == DEFAULT_KW || LA98_9 == END_KW || (LA98_9 >= ERROR_KW && LA98_9 <= EXCLAMATION) || (LA98_9 >= INTERSECTION && LA98_9 <= INTERSECTION_KW) || LA98_9 == L_PAREN || (LA98_9 >= LINKED_KW && LA98_9 <= LOWER) || LA98_9 == OBJECT_KW || (LA98_9 >= OPERATION_KW && LA98_9 <= OPTIONAL_KW) || LA98_9 == R_BRACE || LA98_9 == R_PAREN || LA98_9 == RESULT_KW || LA98_9 == UNION_KW || LA98_9 == UPPER || (LA98_9 >= 126 && LA98_9 <= 134) || LA98_9 == 136 || (LA98_9 >= 139 && LA98_9 <= 141) || LA98_9 == 143 || (LA98_9 >= 146 && LA98_9 <= 148) || (LA98_9 >= 155 && LA98_9 <= 156) || (LA98_9 >= 158 && LA98_9 <= 160) || (LA98_9 >= 162 && LA98_9 <= 164) || LA98_9 == 166 || LA98_9 == 168 || (LA98_9 >= 171 && LA98_9 <= 174) || LA98_9 == 176 || LA98_9 == 178 || (LA98_9 >= 181 && LA98_9 <= 184) || (LA98_9 >= 188 && LA98_9 <= 192) || LA98_9 == 194 || LA98_9 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index98_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA98_10 = input.LA(1);

                   	 
                   	int index98_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA98_10 == L_BRACE) && (synpred31_Smi()) ) { s = 7; }

                   	else if ( (LA98_10 == EOF || LA98_10 == ASSIGN_OP || LA98_10 == BAR || (LA98_10 >= COLON && LA98_10 <= COMMA) || LA98_10 == DEFAULT_KW || LA98_10 == END_KW || (LA98_10 >= ERROR_KW && LA98_10 <= EXCLAMATION) || (LA98_10 >= INTERSECTION && LA98_10 <= INTERSECTION_KW) || (LA98_10 >= LINKED_KW && LA98_10 <= LOWER) || LA98_10 == OBJECT_KW || (LA98_10 >= OPERATION_KW && LA98_10 <= OPTIONAL_KW) || LA98_10 == R_BRACE || LA98_10 == R_PAREN || LA98_10 == RESULT_KW || LA98_10 == UNION_KW || LA98_10 == UPPER || (LA98_10 >= 126 && LA98_10 <= 134) || LA98_10 == 136 || (LA98_10 >= 139 && LA98_10 <= 141) || LA98_10 == 143 || (LA98_10 >= 146 && LA98_10 <= 148) || (LA98_10 >= 155 && LA98_10 <= 156) || (LA98_10 >= 158 && LA98_10 <= 160) || (LA98_10 >= 162 && LA98_10 <= 164) || LA98_10 == 166 || LA98_10 == 168 || (LA98_10 >= 171 && LA98_10 <= 174) || LA98_10 == 176 || LA98_10 == 178 || (LA98_10 >= 181 && LA98_10 <= 184) || (LA98_10 >= 188 && LA98_10 <= 192) || LA98_10 == 194 || LA98_10 == 197) ) { s = 6; }

                   	 
                   	input.Seek(index98_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA98_17 = input.LA(1);

                   	 
                   	int index98_17 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred31_Smi()) ) { s = 7; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index98_17);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae98 =
            new NoViableAltException(dfa.Description, 98, _s, input);
        dfa.Error(nvae98);
        throw nvae98;
    }
    const string DFA107_eotS =
        "\x67\xFFFF";
    const string DFA107_eofS =
        "\x1\x2\x1\x3F\x65\xFFFF";
    const string DFA107_minS =
        "\x2\xA\x1\xFFFF\x1\x7\x45\xFFFF\x1\x0\x1\x25\x1\xD\xA\xFFFF\x1\x4A"+
        "\x10\xFFFF";
    const string DFA107_maxS =
        "\x2\xC5\x1\xFFFF\x1\xBF\x45\xFFFF\x1\x0\x2\xC0\xA\xFFFF\x1\x77\x10"+
        "\xFFFF";
    const string DFA107_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\x45\x1\x3\xFFFF\xA\x1\x1\xFFFF\x10\x1";
    const string DFA107_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\x45\xFFFF\x1\x2\x1\xFFFF\x1\x3\xA"+
        "\xFFFF\x1\x4\x10\xFFFF}>";
    static readonly string[] DFA107_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x1\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x4\xFFFF"+
            "\x7\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x4\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x4\x2\x3\xFFFF"+
            "\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\x3\x2\xFFFF\x1\xE\x1\x47\x7\xFFFF\x1\x7\x5\xFFFF\x1\x42"+
            "\x1\x3D\x4\xFFFF\x1\x41\x6\xFFFF\x1\x14\x1\xFFFF\x1\x16\x1\x2E"+
            "\x1\x45\x1\x43\x4\xFFFF\x1\x5\x4\xFFFF\x1\xD\x9\xFFFF\x2\x46"+
            "\x1\xFFFF\x1\xC\x3\xFFFF\x1\x2F\x1\x9\x2\xFFFF\x1\xA\x1\x10"+
            "\x1\x6\x1\xB\x2\xFFFF\x1\x13\x3\xFFFF\x1\x15\x1\x40\x4\xFFFF"+
            "\x1\xF\x3\xFFFF\x1\x3E\x1\xFFFF\x1\x44\x2\xFFFF\x1\x2D\xA\xFFFF"+
            "\x1\x4\x1\xFFFF\x1\x47\x3\xFFFF\x1\x8\x6\xFFFF\x1\x23\x1\x26"+
            "\x1\x25\x1\x24\x1\x31\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1"+
            "\x17\x2\xFFFF\x1\x3B\x1\x3C\x1\x39\x1\xFFFF\x1\x28\x2\xFFFF"+
            "\x1\x1B\x1\x1D\x1\x1C\x1\x12\x3\xFFFF\x1\x2\x1\x11\x1\x3A\x1"+
            "\x37\x1\x48\x3\x2C\x1\xFFFF\x3\x2C\x1\xFFFF\x1\x2C\x1\xFFFF"+
            "\x1\x32\x2\xFFFF\x1\x38\x1\x33\x1\x34\x1\x21\x1\xFFFF\x1\x2B"+
            "\x1\xFFFF\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x1\x35\x3\xFFFF"+
            "\x1\x2C\x1\x1E\x1\x1F\x1\x2C\x1\x18\x1\xFFFF\x1\x30\x2\xFFFF"+
            "\x1\x36",
            "",
            "\x1\x2\x5\xFFFF\x1\x53\x4\xFFFF\x3\x2\x1\xFFFF\x1\x4E\x1\x2"+
            "\x2\xFFFF\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x6\xFFFF\x1\x2"+
            "\x1\x4D\x1\xFFFF\x3\x2\x1\x52\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2"+
            "\x2\xFFFF\x1\x2\x1\x51\x1\x2\x3\xFFFF\x1\x4B\x2\xFFFF\x1\x4F"+
            "\x1\x55\x1\x49\x1\x50\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x54\x1\xFFFF\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4"+
            "\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1\x4C\x4\xFFFF\x1\x2\x1\x4A\x4"+
            "\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF\x3\x2\x1\xFFFF\x3"+
            "\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF\x1\x2\x2\xFFFF\x1"+
            "\x2",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\x56\x3\xFFFF\x1\x2\x1\xFFFF\x1\x2\x1B\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x8\xFFFF\x1\x2\x3\xFFFF\x1\x2\x1F\xFFFF\x1\x2\x6\xFFFF"+
            "\x4\x2\x1\xFFFF\x4\x2\x1\xFFFF\x1\x2\x6\xFFFF\x1\x2\x2\xFFFF"+
            "\x3\x2\x9\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x4\xFFFF"+
            "\x5\x2",
            "\x1\x63\x8\xFFFF\x1\x5E\x5\xFFFF\x1\x5A\xC\xFFFF\x1\x14\x1\xFFFF"+
            "\x1\x16\x7\xFFFF\x1\x5C\x4\xFFFF\x1\x62\xC\xFFFF\x1\x61\x2\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x58\x2\xFFFF\x1\x5F\x1\x65\x1\x5D\x1\x60"+
            "\x2\xFFFF\x1\x59\x3\xFFFF\x1\x15\x5\xFFFF\x1\x64\x13\xFFFF\x1"+
            "\x5B\x5\xFFFF\x1\x57\x6\xFFFF\x1\x23\x1\x26\x1\x25\x1\x24\x1"+
            "\xFFFF\x1\x2C\x1\x27\x1\x1A\x1\x19\x1\xFFFF\x1\x17\x6\xFFFF"+
            "\x1\x28\x2\xFFFF\x1\x1B\x1\x1D\x1\x1C\x9\xFFFF\x3\x2C\x1\xFFFF"+
            "\x3\x2C\x1\xFFFF\x1\x2C\x7\xFFFF\x1\x21\x1\xFFFF\x1\x2B\x1\xFFFF"+
            "\x1\x22\x2\xFFFF\x1\x20\x1\x2A\x1\x29\x4\xFFFF\x1\x2C\x1\x1E"+
            "\x1\x1F\x1\x2C\x1\x18",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x66\x2C\xFFFF\x1\x2",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA107_eot = DFA.UnpackEncodedString(DFA107_eotS);
    static readonly short[] DFA107_eof = DFA.UnpackEncodedString(DFA107_eofS);
    static readonly char[] DFA107_min = DFA.UnpackEncodedStringToUnsignedChars(DFA107_minS);
    static readonly char[] DFA107_max = DFA.UnpackEncodedStringToUnsignedChars(DFA107_maxS);
    static readonly short[] DFA107_accept = DFA.UnpackEncodedString(DFA107_acceptS);
    static readonly short[] DFA107_special = DFA.UnpackEncodedString(DFA107_specialS);
    static readonly short[][] DFA107_transition = DFA.UnpackEncodedStringArray(DFA107_transitionS);

    protected class DFA107 : DFA
    {
        public DFA107(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 107;
            this.eot = DFA107_eot;
            this.eof = DFA107_eof;
            this.min = DFA107_min;
            this.max = DFA107_max;
            this.accept = DFA107_accept;
            this.special = DFA107_special;
            this.transition = DFA107_transition;

        }

        override public string Description
        {
            get { return "926:41: (=> UPPER (=> value )? )?"; }
        }

    }


    protected internal int DFA107_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA107_1 = input.LA(1);

                   	 
                   	int index107_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA107_1 == ASSIGN_OP) ) { s = 3; }

                   	else if ( (LA107_1 == TRUE_KW) && (synpred32_Smi()) ) { s = 4; }

                   	else if ( (LA107_1 == FALSE_KW) && (synpred32_Smi()) ) { s = 5; }

                   	else if ( (LA107_1 == NULL_KW) && (synpred32_Smi()) ) { s = 6; }

                   	else if ( (LA107_1 == C_STRING) && (synpred32_Smi()) ) { s = 7; }

                   	else if ( (LA107_1 == UPPER) && (synpred32_Smi()) ) { s = 8; }

                   	else if ( (LA107_1 == LOWER) && (synpred32_Smi()) ) { s = 9; }

                   	else if ( (LA107_1 == MINUS) && (synpred32_Smi()) ) { s = 10; }

                   	else if ( (LA107_1 == NUMBER) && (synpred32_Smi()) ) { s = 11; }

                   	else if ( (LA107_1 == L_BRACE) && (synpred32_Smi()) ) { s = 12; }

                   	else if ( (LA107_1 == H_STRING) && (synpred32_Smi()) ) { s = 13; }

                   	else if ( (LA107_1 == B_STRING) && (synpred32_Smi()) ) { s = 14; }

                   	else if ( (LA107_1 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 15; }

                   	else if ( (LA107_1 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 16; }

                   	else if ( (LA107_1 == 154) && (synpred32_Smi()) ) { s = 17; }

                   	else if ( (LA107_1 == 149) && (synpred32_Smi()) ) { s = 18; }

                   	else if ( (LA107_1 == OBJECT_KW) && (synpred32_Smi()) ) { s = 19; }

                   	else if ( (LA107_1 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA107_1 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA107_1 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA107_1 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA107_1 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA107_1 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA107_1 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA107_1 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA107_1 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA107_1 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA107_1 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA107_1 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA107_1 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA107_1 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA107_1 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA107_1 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA107_1 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA107_1 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA107_1 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA107_1 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA107_1 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA107_1 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA107_1 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA107_1 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA107_1 == 131 || (LA107_1 >= 158 && LA107_1 <= 160) || (LA107_1 >= 162 && LA107_1 <= 164) || LA107_1 == 166 || LA107_1 == 188 || LA107_1 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA107_1 == RESULT_KW) && (synpred32_Smi()) ) { s = 45; }

                   	else if ( (LA107_1 == ERRORS_KW) && (synpred32_Smi()) ) { s = 46; }

                   	else if ( (LA107_1 == LINKED_KW) && (synpred32_Smi()) ) { s = 47; }

                   	else if ( (LA107_1 == 194) && (synpred32_Smi()) ) { s = 48; }

                   	else if ( (LA107_1 == 130) && (synpred32_Smi()) ) { s = 49; }

                   	else if ( (LA107_1 == 168) && (synpred32_Smi()) ) { s = 50; }

                   	else if ( (LA107_1 == 172) && (synpred32_Smi()) ) { s = 51; }

                   	else if ( (LA107_1 == 173) && (synpred32_Smi()) ) { s = 52; }

                   	else if ( (LA107_1 == 184) && (synpred32_Smi()) ) { s = 53; }

                   	else if ( (LA107_1 == 197) && (synpred32_Smi()) ) { s = 54; }

                   	else if ( (LA107_1 == 156) && (synpred32_Smi()) ) { s = 55; }

                   	else if ( (LA107_1 == 171) && (synpred32_Smi()) ) { s = 56; }

                   	else if ( (LA107_1 == 141) && (synpred32_Smi()) ) { s = 57; }

                   	else if ( (LA107_1 == 155) && (synpred32_Smi()) ) { s = 58; }

                   	else if ( (LA107_1 == 139) && (synpred32_Smi()) ) { s = 59; }

                   	else if ( (LA107_1 == 140) && (synpred32_Smi()) ) { s = 60; }

                   	else if ( (LA107_1 == COMMA) && (synpred32_Smi()) ) { s = 61; }

                   	else if ( (LA107_1 == R_BRACE) && (synpred32_Smi()) ) { s = 62; }

                   	else if ( (LA107_1 == EOF) && (synpred32_Smi()) ) { s = 63; }

                   	else if ( (LA107_1 == OPTIONAL_KW) && (synpred32_Smi()) ) { s = 64; }

                   	else if ( (LA107_1 == DEFAULT_KW) && (synpred32_Smi()) ) { s = 65; }

                   	else if ( (LA107_1 == COLON) && (synpred32_Smi()) ) { s = 66; }

                   	else if ( (LA107_1 == EXCLAMATION) && (synpred32_Smi()) ) { s = 67; }

                   	else if ( (LA107_1 == R_PAREN) && (synpred32_Smi()) ) { s = 68; }

                   	else if ( (LA107_1 == EXCEPT_KW) && (synpred32_Smi()) ) { s = 69; }

                   	else if ( ((LA107_1 >= INTERSECTION && LA107_1 <= INTERSECTION_KW)) && (synpred32_Smi()) ) { s = 70; }

                   	else if ( (LA107_1 == BAR || LA107_1 == UNION_KW) && (synpred32_Smi()) ) { s = 71; }

                   	else if ( (LA107_1 == 157) && (synpred32_Smi()) ) { s = 72; }

                   	else if ( (LA107_1 == 153) ) { s = 2; }

                   	 
                   	input.Seek(index107_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA107_3 = input.LA(1);

                   	 
                   	int index107_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA107_3 == ANY_KW || (LA107_3 >= BIT_KW && LA107_3 <= BOOLEAN_KW) || LA107_3 == CHARACTER_KW || LA107_3 == CHOICE_KW || LA107_3 == EMBEDDED_KW || (LA107_3 >= ENUMERATED_KW && LA107_3 <= ERROR_KW) || LA107_3 == EXTERNAL_KW || (LA107_3 >= GENERAL_STR_KW && LA107_3 <= GRAPHIC_STR_KW) || LA107_3 == IA5_STRING_KW || LA107_3 == INTEGER_KW || LA107_3 == ISO646_STR_KW || LA107_3 == L_BRACKET || LA107_3 == NUMERIC_STR_KW || (LA107_3 >= OBJECT_KW && LA107_3 <= OCTET_KW) || LA107_3 == OPERATION_KW || LA107_3 == PRINTABLE_STR_KW || LA107_3 == REAL_KW || (LA107_3 >= SEQUENCE_KW && LA107_3 <= SET_KW) || LA107_3 == T61_STR_KW || LA107_3 == TELETEX_STR_KW || LA107_3 == UNIVERSAL_STR_KW || (LA107_3 >= UTC_TIME_KW && LA107_3 <= VISIBLE_STR_KW) || LA107_3 == 131 || LA107_3 == 137 || (LA107_3 >= 158 && LA107_3 <= 160) || (LA107_3 >= 162 && LA107_3 <= 164) || LA107_3 == 166 || LA107_3 == 179 || LA107_3 == 188 || LA107_3 == 191) ) { s = 2; }

                   	else if ( (LA107_3 == NULL_KW) ) { s = 73; }

                   	else if ( (LA107_3 == UPPER) ) { s = 74; }

                   	else if ( (LA107_3 == LOWER) ) { s = 75; }

                   	else if ( (LA107_3 == TRUE_KW) && (synpred32_Smi()) ) { s = 76; }

                   	else if ( (LA107_3 == FALSE_KW) && (synpred32_Smi()) ) { s = 77; }

                   	else if ( (LA107_3 == C_STRING) && (synpred32_Smi()) ) { s = 78; }

                   	else if ( (LA107_3 == MINUS) && (synpred32_Smi()) ) { s = 79; }

                   	else if ( (LA107_3 == NUMBER) && (synpred32_Smi()) ) { s = 80; }

                   	else if ( (LA107_3 == L_BRACE) && (synpred32_Smi()) ) { s = 81; }

                   	else if ( (LA107_3 == H_STRING) && (synpred32_Smi()) ) { s = 82; }

                   	else if ( (LA107_3 == B_STRING) && (synpred32_Smi()) ) { s = 83; }

                   	else if ( (LA107_3 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 84; }

                   	else if ( (LA107_3 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 85; }

                   	 
                   	input.Seek(index107_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA107_73 = input.LA(1);

                   	 
                   	int index107_73 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred32_Smi()) ) { s = 85; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index107_73);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA107_75 = input.LA(1);

                   	 
                   	int index107_75 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA107_75 == LESS) ) { s = 2; }

                   	else if ( (LA107_75 == END_KW) && (synpred32_Smi()) ) { s = 20; }

                   	else if ( (LA107_75 == UPPER) && (synpred32_Smi()) ) { s = 87; }

                   	else if ( (LA107_75 == LOWER) && (synpred32_Smi()) ) { s = 88; }

                   	else if ( (LA107_75 == OPERATION_KW) && (synpred32_Smi()) ) { s = 21; }

                   	else if ( (LA107_75 == ERROR_KW) && (synpred32_Smi()) ) { s = 22; }

                   	else if ( (LA107_75 == 136) && (synpred32_Smi()) ) { s = 23; }

                   	else if ( (LA107_75 == 192) && (synpred32_Smi()) ) { s = 24; }

                   	else if ( (LA107_75 == 134) && (synpred32_Smi()) ) { s = 25; }

                   	else if ( (LA107_75 == 133) && (synpred32_Smi()) ) { s = 26; }

                   	else if ( (LA107_75 == 146) && (synpred32_Smi()) ) { s = 27; }

                   	else if ( (LA107_75 == 148) && (synpred32_Smi()) ) { s = 28; }

                   	else if ( (LA107_75 == 147) && (synpred32_Smi()) ) { s = 29; }

                   	else if ( (LA107_75 == 189) && (synpred32_Smi()) ) { s = 30; }

                   	else if ( (LA107_75 == 190) && (synpred32_Smi()) ) { s = 31; }

                   	else if ( (LA107_75 == 181) && (synpred32_Smi()) ) { s = 32; }

                   	else if ( (LA107_75 == OBJECT_KW) && (synpred32_Smi()) ) { s = 89; }

                   	else if ( (LA107_75 == 174) && (synpred32_Smi()) ) { s = 33; }

                   	else if ( (LA107_75 == 178) && (synpred32_Smi()) ) { s = 34; }

                   	else if ( (LA107_75 == 126) && (synpred32_Smi()) ) { s = 35; }

                   	else if ( (LA107_75 == 129) && (synpred32_Smi()) ) { s = 36; }

                   	else if ( (LA107_75 == 128) && (synpred32_Smi()) ) { s = 37; }

                   	else if ( (LA107_75 == 127) && (synpred32_Smi()) ) { s = 38; }

                   	else if ( (LA107_75 == 132) && (synpred32_Smi()) ) { s = 39; }

                   	else if ( (LA107_75 == 143) && (synpred32_Smi()) ) { s = 40; }

                   	else if ( (LA107_75 == 183) && (synpred32_Smi()) ) { s = 41; }

                   	else if ( (LA107_75 == 182) && (synpred32_Smi()) ) { s = 42; }

                   	else if ( (LA107_75 == 176) && (synpred32_Smi()) ) { s = 43; }

                   	else if ( (LA107_75 == 131 || (LA107_75 >= 158 && LA107_75 <= 160) || (LA107_75 >= 162 && LA107_75 <= 164) || LA107_75 == 166 || LA107_75 == 188 || LA107_75 == 191) && (synpred32_Smi()) ) { s = 44; }

                   	else if ( (LA107_75 == COLON) && (synpred32_Smi()) ) { s = 90; }

                   	else if ( (LA107_75 == TRUE_KW) && (synpred32_Smi()) ) { s = 91; }

                   	else if ( (LA107_75 == FALSE_KW) && (synpred32_Smi()) ) { s = 92; }

                   	else if ( (LA107_75 == NULL_KW) && (synpred32_Smi()) ) { s = 93; }

                   	else if ( (LA107_75 == C_STRING) && (synpred32_Smi()) ) { s = 94; }

                   	else if ( (LA107_75 == MINUS) && (synpred32_Smi()) ) { s = 95; }

                   	else if ( (LA107_75 == NUMBER) && (synpred32_Smi()) ) { s = 96; }

                   	else if ( (LA107_75 == L_BRACE) && (synpred32_Smi()) ) { s = 97; }

                   	else if ( (LA107_75 == H_STRING) && (synpred32_Smi()) ) { s = 98; }

                   	else if ( (LA107_75 == B_STRING) && (synpred32_Smi()) ) { s = 99; }

                   	else if ( (LA107_75 == PLUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 100; }

                   	else if ( (LA107_75 == MINUS_INFINITY_KW) && (synpred32_Smi()) ) { s = 101; }

                   	 
                   	input.Seek(index107_75);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA107_86 = input.LA(1);

                   	 
                   	int index107_86 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA107_86 == UPPER) ) { s = 2; }

                   	else if ( (LA107_86 == LOWER) && (synpred32_Smi()) ) { s = 102; }

                   	 
                   	input.Seek(index107_86);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae107 =
            new NoViableAltException(dfa.Description, 107, _s, input);
        dfa.Error(nvae107);
        throw nvae107;
    }
    const string DFA106_eotS =
        "\x47\xFFFF";
    const string DFA106_eofS =
        "\x1\xE\x46\xFFFF";
    const string DFA106_minS =
        "\x1\xA\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA106_maxS =
        "\x1\xC5\x4\xFFFF\x2\x0\x40\xFFFF";
    const string DFA106_acceptS =
        "\x1\xFFFF\x4\x1\x2\xFFFF\x7\x1\x1\x2\x38\xFFFF";
    const string DFA106_specialS =
        "\x1\x0\x4\xFFFF\x1\x1\x1\x2\x40\xFFFF}>";
    static readonly string[] DFA106_transitionS = {
            "\x1\xE\x2\xFFFF\x1\xB\x1\xE\x7\xFFFF\x1\x4\x5\xFFFF\x2\xE\x4"+
            "\xFFFF\x1\xE\x6\xFFFF\x1\xE\x1\xFFFF\x4\xE\x4\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\xA\x9\xFFFF\x2\xE\x1\xFFFF\x1\x9\x3\xFFFF\x1\xE\x1"+
            "\x6\x2\xFFFF\x1\x7\x1\xD\x1\x3\x1\x8\x2\xFFFF\x1\xE\x3\xFFFF"+
            "\x2\xE\x4\xFFFF\x1\xC\x3\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x1\xE\xA\xFFFF\x1\x1\x1\xFFFF\x1\xE\x3\xFFFF\x1\x5\x6\xFFFF"+
            "\x9\xE\x1\xFFFF\x1\xE\x2\xFFFF\x3\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x4\xFFFF\x7\xE\x1\xFFFF\x3\xE\x1\xFFFF\x1\xE\x1\xFFFF"+
            "\x1\xE\x2\xFFFF\x4\xE\x1\xFFFF\x1\xE\x1\xFFFF\x1\xE\x2\xFFFF"+
            "\x4\xE\x3\xFFFF\x5\xE\x1\xFFFF\x1\xE\x2\xFFFF\x1\xE",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA106_eot = DFA.UnpackEncodedString(DFA106_eotS);
    static readonly short[] DFA106_eof = DFA.UnpackEncodedString(DFA106_eofS);
    static readonly char[] DFA106_min = DFA.UnpackEncodedStringToUnsignedChars(DFA106_minS);
    static readonly char[] DFA106_max = DFA.UnpackEncodedStringToUnsignedChars(DFA106_maxS);
    static readonly short[] DFA106_accept = DFA.UnpackEncodedString(DFA106_acceptS);
    static readonly short[] DFA106_special = DFA.UnpackEncodedString(DFA106_specialS);
    static readonly short[][] DFA106_transition = DFA.UnpackEncodedStringArray(DFA106_transitionS);

    protected class DFA106 : DFA
    {
        public DFA106(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 106;
            this.eot = DFA106_eot;
            this.eof = DFA106_eof;
            this.min = DFA106_min;
            this.max = DFA106_max;
            this.accept = DFA106_accept;
            this.special = DFA106_special;
            this.transition = DFA106_transition;

        }

        override public string Description
        {
            get { return "926:59: (=> value )?"; }
        }

    }


    protected internal int DFA106_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA106_0 = input.LA(1);

                   	 
                   	int index106_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA106_0 == TRUE_KW) && (synpred33_Smi()) ) { s = 1; }

                   	else if ( (LA106_0 == FALSE_KW) && (synpred33_Smi()) ) { s = 2; }

                   	else if ( (LA106_0 == NULL_KW) && (synpred33_Smi()) ) { s = 3; }

                   	else if ( (LA106_0 == C_STRING) && (synpred33_Smi()) ) { s = 4; }

                   	else if ( (LA106_0 == UPPER) ) { s = 5; }

                   	else if ( (LA106_0 == LOWER) ) { s = 6; }

                   	else if ( (LA106_0 == MINUS) && (synpred33_Smi()) ) { s = 7; }

                   	else if ( (LA106_0 == NUMBER) && (synpred33_Smi()) ) { s = 8; }

                   	else if ( (LA106_0 == L_BRACE) && (synpred33_Smi()) ) { s = 9; }

                   	else if ( (LA106_0 == H_STRING) && (synpred33_Smi()) ) { s = 10; }

                   	else if ( (LA106_0 == B_STRING) && (synpred33_Smi()) ) { s = 11; }

                   	else if ( (LA106_0 == PLUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 12; }

                   	else if ( (LA106_0 == MINUS_INFINITY_KW) && (synpred33_Smi()) ) { s = 13; }

                   	else if ( (LA106_0 == EOF || LA106_0 == ASSIGN_OP || LA106_0 == BAR || (LA106_0 >= COLON && LA106_0 <= COMMA) || LA106_0 == DEFAULT_KW || LA106_0 == END_KW || (LA106_0 >= ERROR_KW && LA106_0 <= EXCLAMATION) || (LA106_0 >= INTERSECTION && LA106_0 <= INTERSECTION_KW) || LA106_0 == LINKED_KW || LA106_0 == OBJECT_KW || (LA106_0 >= OPERATION_KW && LA106_0 <= OPTIONAL_KW) || LA106_0 == R_BRACE || LA106_0 == R_PAREN || LA106_0 == RESULT_KW || LA106_0 == UNION_KW || (LA106_0 >= 126 && LA106_0 <= 134) || LA106_0 == 136 || (LA106_0 >= 139 && LA106_0 <= 141) || LA106_0 == 143 || (LA106_0 >= 146 && LA106_0 <= 149) || (LA106_0 >= 154 && LA106_0 <= 160) || (LA106_0 >= 162 && LA106_0 <= 164) || LA106_0 == 166 || LA106_0 == 168 || (LA106_0 >= 171 && LA106_0 <= 174) || LA106_0 == 176 || LA106_0 == 178 || (LA106_0 >= 181 && LA106_0 <= 184) || (LA106_0 >= 188 && LA106_0 <= 192) || LA106_0 == 194 || LA106_0 == 197) ) { s = 14; }

                   	 
                   	input.Seek(index106_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA106_5 = input.LA(1);

                   	 
                   	int index106_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index106_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA106_6 = input.LA(1);

                   	 
                   	int index106_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred33_Smi()) ) { s = 13; }

                   	else if ( (true) ) { s = 14; }

                   	 
                   	input.Seek(index106_6);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae106 =
            new NoViableAltException(dfa.Description, 106, _s, input);
        dfa.Error(nvae106);
        throw nvae106;
    }
    const string DFA118_eotS =
        "\xB\xFFFF";
    const string DFA118_eofS =
        "\xB\xFFFF";
    const string DFA118_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA118_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA118_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA118_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA118_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA118_eot = DFA.UnpackEncodedString(DFA118_eotS);
    static readonly short[] DFA118_eof = DFA.UnpackEncodedString(DFA118_eofS);
    static readonly char[] DFA118_min = DFA.UnpackEncodedStringToUnsignedChars(DFA118_minS);
    static readonly char[] DFA118_max = DFA.UnpackEncodedStringToUnsignedChars(DFA118_maxS);
    static readonly short[] DFA118_accept = DFA.UnpackEncodedString(DFA118_acceptS);
    static readonly short[] DFA118_special = DFA.UnpackEncodedString(DFA118_specialS);
    static readonly short[][] DFA118_transition = DFA.UnpackEncodedStringArray(DFA118_transitionS);

    protected class DFA118 : DFA
    {
        public DFA118(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 118;
            this.eot = DFA118_eot;
            this.eof = DFA118_eof;
            this.min = DFA118_min;
            this.max = DFA118_max;
            this.accept = DFA118_accept;
            this.special = DFA118_special;
            this.transition = DFA118_transition;

        }

        override public string Description
        {
            get { return "936:0: modulecompliance_macro_syntax : (=> smi_type L_BRACE modulecompliance_macro_namedbit ( COMMA modulecompliance_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA118_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA118_1 = input.LA(1);

                   	 
                   	int index118_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA118_1 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index118_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA118_2 = input.LA(1);

                   	 
                   	int index118_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA118_2 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index118_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA118_5 = input.LA(1);

                   	 
                   	int index118_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA118_5 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index118_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA118_9 = input.LA(1);

                   	 
                   	int index118_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA118_9 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index118_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA118_10 = input.LA(1);

                   	 
                   	int index118_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA118_10 == L_BRACE) && (synpred34_Smi()) ) { s = 7; }

                   	else if ( (synpred35_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index118_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae118 =
            new NoViableAltException(dfa.Description, 118, _s, input);
        dfa.Error(nvae118);
        throw nvae118;
    }
    const string DFA131_eotS =
        "\x10\xFFFF";
    const string DFA131_eofS =
        "\x10\xFFFF";
    const string DFA131_minS =
        "\x2\xD\x1\xFFFF\x2\xD\x1\x0\x1\xD\x1\x0\x1\xD\x1\xFFFF\x1\xD\x1"+
        "\x0\x1\xD\x1\x0\x2\xD";
    const string DFA131_maxS =
        "\x2\x77\x1\xFFFF\x2\x77\x1\x0\x1\x77\x1\x0\x1\x77\x1\xFFFF\x1\x77"+
        "\x1\x0\x1\x77\x1\x0\x2\x77";
    const string DFA131_acceptS =
        "\x2\xFFFF\x1\x2\x6\xFFFF\x1\x1\x6\xFFFF";
    const string DFA131_specialS =
        "\x5\xFFFF\x1\x0\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x1\xFFFF\x1\x3\x2"+
        "\xFFFF}>";
    static readonly string[] DFA131_transitionS = {
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x1\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x6\xFFFF\x1\x4\x15\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x3\x2\xFFFF\x4\x2\xC\xFFFF"+
            "\x1\x2\x3\xFFFF\x1\x5\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\x6\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2\x2"+
            "\xFFFF\x4\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x7\xF\xFFFF\x1\x2\x5"+
            "\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x8\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xE\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xD\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xF\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\xFFFF",
            "\x1\x2\x8\xFFFF\x1\x2\x1C\xFFFF\x1\x2\x4\xFFFF\x1\x2\xC\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\xA\x2\xFFFF\x4\x2\xC\xFFFF\x1\x2\x13\xFFFF"+
            "\x1\x2\x5\xFFFF\x1\x2",
            "\x1\x2\x8\xFFFF\x1\x2\x5\xFFFF\x1\x2\x1\xC\x15\xFFFF\x1\x2\x4"+
            "\xFFFF\x1\x2\xC\xFFFF\x1\x2\x4\xFFFF\x1\x2\x2\xFFFF\x4\x2\xC"+
            "\xFFFF\x1\x2\x3\xFFFF\x1\xB\xF\xFFFF\x1\x2\x5\xFFFF\x1\x2"
    };

    static readonly short[] DFA131_eot = DFA.UnpackEncodedString(DFA131_eotS);
    static readonly short[] DFA131_eof = DFA.UnpackEncodedString(DFA131_eofS);
    static readonly char[] DFA131_min = DFA.UnpackEncodedStringToUnsignedChars(DFA131_minS);
    static readonly char[] DFA131_max = DFA.UnpackEncodedStringToUnsignedChars(DFA131_maxS);
    static readonly short[] DFA131_accept = DFA.UnpackEncodedString(DFA131_acceptS);
    static readonly short[] DFA131_special = DFA.UnpackEncodedString(DFA131_specialS);
    static readonly short[][] DFA131_transition = DFA.UnpackEncodedStringArray(DFA131_transitionS);

    protected class DFA131 : DFA
    {
        public DFA131(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 131;
            this.eot = DFA131_eot;
            this.eof = DFA131_eof;
            this.min = DFA131_min;
            this.max = DFA131_max;
            this.accept = DFA131_accept;
            this.special = DFA131_special;
            this.transition = DFA131_transition;

        }

        override public string Description
        {
            get { return "967:55: (=> L_BRACE ( LOWER )? ( COMMA LOWER )* R_BRACE | value )"; }
        }

    }


    protected internal int DFA131_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA131_5 = input.LA(1);

                   	 
                   	int index131_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index131_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA131_7 = input.LA(1);

                   	 
                   	int index131_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index131_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA131_11 = input.LA(1);

                   	 
                   	int index131_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index131_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA131_13 = input.LA(1);

                   	 
                   	int index131_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred36_Smi()) ) { s = 9; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index131_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae131 =
            new NoViableAltException(dfa.Description, 131, _s, input);
        dfa.Error(nvae131);
        throw nvae131;
    }
    const string DFA135_eotS =
        "\xB\xFFFF";
    const string DFA135_eofS =
        "\xB\xFFFF";
    const string DFA135_minS =
        "\x1\x7\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA135_maxS =
        "\x1\xBF\x2\x45\x1\x6D\x1\x3B\x1\x45\x3\xFFFF\x2\x45";
    const string DFA135_acceptS =
        "\x6\xFFFF\x1\x3\x1\x1\x1\x2\x2\xFFFF";
    const string DFA135_specialS =
        "\x1\xFFFF\x1\x0\x1\x1\x2\xFFFF\x1\x2\x3\xFFFF\x1\x3\x1\x4}>";
    static readonly string[] DFA135_transitionS = {
            "\x1\x6\xA\xFFFF\x3\x6\x2\xFFFF\x1\x6\x2\xFFFF\x1\x6\xD\xFFFF"+
            "\x1\x6\x1\xFFFF\x2\x6\x6\xFFFF\x1\x6\x2\xFFFF\x3\x6\x2\xFFFF"+
            "\x1\x6\x6\xFFFF\x1\x2\x2\xFFFF\x1\x6\x1\xFFFF\x1\x6\x3\xFFFF"+
            "\x1\x6\x4\xFFFF\x1\x6\x1\xFFFF\x1\x6\x1\xFFFF\x1\x4\x1\x3\x2"+
            "\xFFFF\x1\x6\x7\xFFFF\x1\x6\x4\xFFFF\x1\x6\x3\xFFFF\x2\x6\x4"+
            "\xFFFF\x1\x6\x1\xFFFF\x1\x6\x5\xFFFF\x1\x6\x1\x5\x4\x6\x7\xFFFF"+
            "\x1\x6\x5\xFFFF\x1\x1\x14\xFFFF\x3\x6\x1\xFFFF\x3\x6\x1\xFFFF"+
            "\x1\x6\xC\xFFFF\x1\x6\x8\xFFFF\x1\x6\x2\xFFFF\x1\x6",
            "\x1\x7",
            "\x1\x7",
            "\x1\x9",
            "\x1\xA",
            "\x1\x7",
            "",
            "",
            "",
            "\x1\x7",
            "\x1\x7"
    };

    static readonly short[] DFA135_eot = DFA.UnpackEncodedString(DFA135_eotS);
    static readonly short[] DFA135_eof = DFA.UnpackEncodedString(DFA135_eofS);
    static readonly char[] DFA135_min = DFA.UnpackEncodedStringToUnsignedChars(DFA135_minS);
    static readonly char[] DFA135_max = DFA.UnpackEncodedStringToUnsignedChars(DFA135_maxS);
    static readonly short[] DFA135_accept = DFA.UnpackEncodedString(DFA135_acceptS);
    static readonly short[] DFA135_special = DFA.UnpackEncodedString(DFA135_specialS);
    static readonly short[][] DFA135_transition = DFA.UnpackEncodedStringArray(DFA135_transitionS);

    protected class DFA135 : DFA
    {
        public DFA135(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 135;
            this.eot = DFA135_eot;
            this.eof = DFA135_eof;
            this.min = DFA135_min;
            this.max = DFA135_max;
            this.accept = DFA135_accept;
            this.special = DFA135_special;
            this.transition = DFA135_transition;

        }

        override public string Description
        {
            get { return "969:0: agentcapabilities_macro_syntax : (=> smi_type L_BRACE agentcapabilities_macro_namedbit ( COMMA agentcapabilities_macro_namedbit )* R_BRACE |=> smi_type ( smi_subtyping )? | type );"; }
        }

    }


    protected internal int DFA135_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA135_1 = input.LA(1);

                   	 
                   	int index135_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA135_1 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index135_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA135_2 = input.LA(1);

                   	 
                   	int index135_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA135_2 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index135_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA135_5 = input.LA(1);

                   	 
                   	int index135_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA135_5 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index135_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA135_9 = input.LA(1);

                   	 
                   	int index135_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA135_9 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index135_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA135_10 = input.LA(1);

                   	 
                   	int index135_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA135_10 == L_BRACE) && (synpred37_Smi()) ) { s = 7; }

                   	else if ( (synpred38_Smi()) ) { s = 8; }

                   	else if ( (true) ) { s = 6; }

                   	 
                   	input.Seek(index135_10);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae135 =
            new NoViableAltException(dfa.Description, 135, _s, input);
        dfa.Error(nvae135);
        throw nvae135;
    }
    const string DFA138_eotS =
        "\x10\xFFFF";
    const string DFA138_eofS =
        "\x1\x2\xF\xFFFF";
    const string DFA138_minS =
        "\x1\xA\x1\xD\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA138_maxS =
        "\x1\xC5\x1\x77\x1\xFFFF\x1\x0\xC\xFFFF";
    const string DFA138_acceptS =
        "\x2\xFFFF\x1\x2\x1\xFFFF\xC\x1";
    const string DFA138_specialS =
        "\x1\xFFFF\x1\x0\x1\xFFFF\x1\x1\xC\xFFFF}>";
    static readonly string[] DFA138_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\xD\xFFFF\x2\x2\x4\xFFFF\x1\x2\x6\xFFFF"+
            "\x1\x2\x1\xFFFF\x4\x2\x13\xFFFF\x2\x2\x5\xFFFF\x2\x2\x8\xFFFF"+
            "\x1\x2\x3\xFFFF\x2\x2\x8\xFFFF\x1\x2\x1\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xC\xFFFF\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x9\x2\x1\xFFFF"+
            "\x1\x2\x2\xFFFF\x2\x2\x1\x1\x1\xFFFF\x1\x2\x2\xFFFF\x3\x2\x6"+
            "\xFFFF\x2\x2\x1\xFFFF\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\x1"+
            "\xFFFF\x1\x2\x2\xFFFF\x4\x2\x1\xFFFF\x3\x2\x2\xFFFF\x4\x2\x3"+
            "\xFFFF\x5\x2\x1\xFFFF\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xD\x8\xFFFF\x1\x3\x1C\xFFFF\x1\x5\x4\xFFFF\x1\xC\xC\xFFFF"+
            "\x1\xB\x4\xFFFF\x1\x8\x2\xFFFF\x1\x9\x1\xF\x1\x6\x1\xA\xC\xFFFF"+
            "\x1\xE\x13\xFFFF\x1\x4\x5\xFFFF\x1\x7",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA138_eot = DFA.UnpackEncodedString(DFA138_eotS);
    static readonly short[] DFA138_eof = DFA.UnpackEncodedString(DFA138_eofS);
    static readonly char[] DFA138_min = DFA.UnpackEncodedStringToUnsignedChars(DFA138_minS);
    static readonly char[] DFA138_max = DFA.UnpackEncodedStringToUnsignedChars(DFA138_maxS);
    static readonly short[] DFA138_accept = DFA.UnpackEncodedString(DFA138_acceptS);
    static readonly short[] DFA138_special = DFA.UnpackEncodedString(DFA138_specialS);
    static readonly short[][] DFA138_transition = DFA.UnpackEncodedStringArray(DFA138_transitionS);

    protected class DFA138 : DFA
    {
        public DFA138(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 138;
            this.eot = DFA138_eot;
            this.eof = DFA138_eof;
            this.min = DFA138_min;
            this.max = DFA138_max;
            this.accept = DFA138_accept;
            this.special = DFA138_special;
            this.transition = DFA138_transition;

        }

        override public string Description
        {
            get { return "986:21: (=> 'DESCRIPTION' value )?"; }
        }

    }


    protected internal int DFA138_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA138_1 = input.LA(1);

                   	 
                   	int index138_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA138_1 == C_STRING) ) { s = 3; }

                   	else if ( (LA138_1 == TRUE_KW) && (synpred39_Smi()) ) { s = 4; }

                   	else if ( (LA138_1 == FALSE_KW) && (synpred39_Smi()) ) { s = 5; }

                   	else if ( (LA138_1 == NULL_KW) && (synpred39_Smi()) ) { s = 6; }

                   	else if ( (LA138_1 == UPPER) && (synpred39_Smi()) ) { s = 7; }

                   	else if ( (LA138_1 == LOWER) && (synpred39_Smi()) ) { s = 8; }

                   	else if ( (LA138_1 == MINUS) && (synpred39_Smi()) ) { s = 9; }

                   	else if ( (LA138_1 == NUMBER) && (synpred39_Smi()) ) { s = 10; }

                   	else if ( (LA138_1 == L_BRACE) && (synpred39_Smi()) ) { s = 11; }

                   	else if ( (LA138_1 == H_STRING) && (synpred39_Smi()) ) { s = 12; }

                   	else if ( (LA138_1 == B_STRING) && (synpred39_Smi()) ) { s = 13; }

                   	else if ( (LA138_1 == PLUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 14; }

                   	else if ( (LA138_1 == MINUS_INFINITY_KW) && (synpred39_Smi()) ) { s = 15; }

                   	 
                   	input.Seek(index138_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA138_3 = input.LA(1);

                   	 
                   	int index138_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred39_Smi()) ) { s = 15; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index138_3);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae138 =
            new NoViableAltException(dfa.Description, 138, _s, input);
        dfa.Error(nvae138);
        throw nvae138;
    }
    const string DFA142_eotS =
        "\x2A\xFFFF";
    const string DFA142_eofS =
        "\x13\xFFFF\x1\x27\x1\x22\x15\xFFFF";
    const string DFA142_minS =
        "\x1\x7\xA\xFFFF\x1\x0\x7\xFFFF\x1\x1D\x1\xD\xE\xFFFF\x1\x4A\x6\xFFFF";
    const string DFA142_maxS =
        "\x1\xBF\xA\xFFFF\x1\x0\x7\xFFFF\x1\x61\x1\x77\xE\xFFFF\x1\x77\x6"+
        "\xFFFF";
    const string DFA142_acceptS =
        "\x1\xFFFF\xA\x1\x1\xFFFF\x7\x1\x2\xFFFF\xD\x1\x1\x2\x1\xFFFF\x6"+
        "\x1";
    const string DFA142_specialS =
        "\x1\x0\xA\xFFFF\x1\x1\x7\xFFFF\x1\x2\x1\x3\xE\xFFFF\x1\x4\x6\xFFFF}>";
    static readonly string[] DFA142_transitionS = {
            "\x1\x1\x5\xFFFF\x1\x22\x4\xFFFF\x1\x2\x1\x5\x1\x3\x1\xFFFF\x1"+
            "\x22\x1\x4\x2\xFFFF\x1\x6\xD\xFFFF\x1\x7\x1\xFFFF\x1\x8\x1\x16"+
            "\x6\xFFFF\x1\x9\x1\x22\x1\xFFFF\x3\x5\x1\x22\x1\xFFFF\x1\x5"+
            "\x6\xFFFF\x1\xA\x2\xFFFF\x1\x5\x1\x22\x1\x12\x3\xFFFF\x1\x14"+
            "\x2\xFFFF\x2\x22\x1\xB\x1\x22\x1\x5\x1\xFFFF\x1\xC\x1\xD\x2"+
            "\xFFFF\x1\x15\x5\xFFFF\x1\x22\x1\xFFFF\x1\x5\x4\xFFFF\x1\xE"+
            "\x3\xFFFF\x1\x10\x1\x11\x4\xFFFF\x1\x5\x1\xFFFF\x1\x5\x1\x22"+
            "\x4\xFFFF\x1\x5\x1\x13\x4\x5\x7\xFFFF\x1\x1F\x5\xFFFF\x1\x21"+
            "\x14\xFFFF\x1\x1E\x1\x18\x1\x1D\x1\xFFFF\x1\x1A\x1\x1C\x1\x19"+
            "\x1\xFFFF\x1\x17\xC\xFFFF\x1\xF\x8\xFFFF\x1\x1B\x2\xFFFF\x1"+
            "\x20",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x25\x7\xFFFF\x1\x23\x21\xFFFF\x1\x24\x19\xFFFF\x1\x26",
            "\x1\x22\x8\xFFFF\x1\x22\x5\xFFFF\x2\x22\x15\xFFFF\x1\x22\x4"+
            "\xFFFF\x1\x22\xC\xFFFF\x1\x22\x2\xFFFF\x1\x28\x1\xFFFF\x1\x22"+
            "\x2\xFFFF\x4\x22\xC\xFFFF\x1\x22\x3\xFFFF\x1\x22\xF\xFFFF\x1"+
            "\x22\x5\xFFFF\x1\x22",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "\x1\x22\x2C\xFFFF\x1\x29",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA142_eot = DFA.UnpackEncodedString(DFA142_eotS);
    static readonly short[] DFA142_eof = DFA.UnpackEncodedString(DFA142_eofS);
    static readonly char[] DFA142_min = DFA.UnpackEncodedStringToUnsignedChars(DFA142_minS);
    static readonly char[] DFA142_max = DFA.UnpackEncodedStringToUnsignedChars(DFA142_maxS);
    static readonly short[] DFA142_accept = DFA.UnpackEncodedString(DFA142_acceptS);
    static readonly short[] DFA142_special = DFA.UnpackEncodedString(DFA142_specialS);
    static readonly short[][] DFA142_transition = DFA.UnpackEncodedStringArray(DFA142_transitionS);

    protected class DFA142 : DFA
    {
        public DFA142(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 142;
            this.eot = DFA142_eot;
            this.eof = DFA142_eof;
            this.min = DFA142_min;
            this.max = DFA142_max;
            this.accept = DFA142_accept;
            this.special = DFA142_special;
            this.transition = DFA142_transition;

        }

        override public string Description
        {
            get { return "992:0: typeorvalue : (=> type | value );"; }
        }

    }


    protected internal int DFA142_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA142_0 = input.LA(1);

                   	 
                   	int index142_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA142_0 == ANY_KW) && (synpred40_Smi()) ) { s = 1; }

                   	else if ( (LA142_0 == BIT_KW) && (synpred40_Smi()) ) { s = 2; }

                   	else if ( (LA142_0 == BOOLEAN_KW) && (synpred40_Smi()) ) { s = 3; }

                   	else if ( (LA142_0 == CHARACTER_KW) && (synpred40_Smi()) ) { s = 4; }

                   	else if ( (LA142_0 == BMP_STR_KW || (LA142_0 >= GENERAL_STR_KW && LA142_0 <= GRAPHIC_STR_KW) || LA142_0 == IA5_STRING_KW || LA142_0 == ISO646_STR_KW || LA142_0 == NUMERIC_STR_KW || LA142_0 == PRINTABLE_STR_KW || LA142_0 == T61_STR_KW || LA142_0 == TELETEX_STR_KW || LA142_0 == UNIVERSAL_STR_KW || (LA142_0 >= UTC_TIME_KW && LA142_0 <= VISIBLE_STR_KW)) && (synpred40_Smi()) ) { s = 5; }

                   	else if ( (LA142_0 == CHOICE_KW) && (synpred40_Smi()) ) { s = 6; }

                   	else if ( (LA142_0 == EMBEDDED_KW) && (synpred40_Smi()) ) { s = 7; }

                   	else if ( (LA142_0 == ENUMERATED_KW) && (synpred40_Smi()) ) { s = 8; }

                   	else if ( (LA142_0 == EXTERNAL_KW) && (synpred40_Smi()) ) { s = 9; }

                   	else if ( (LA142_0 == INTEGER_KW) && (synpred40_Smi()) ) { s = 10; }

                   	else if ( (LA142_0 == NULL_KW) ) { s = 11; }

                   	else if ( (LA142_0 == OBJECT_KW) && (synpred40_Smi()) ) { s = 12; }

                   	else if ( (LA142_0 == OCTET_KW) && (synpred40_Smi()) ) { s = 13; }

                   	else if ( (LA142_0 == REAL_KW) && (synpred40_Smi()) ) { s = 14; }

                   	else if ( (LA142_0 == 179) && (synpred40_Smi()) ) { s = 15; }

                   	else if ( (LA142_0 == SEQUENCE_KW) && (synpred40_Smi()) ) { s = 16; }

                   	else if ( (LA142_0 == SET_KW) && (synpred40_Smi()) ) { s = 17; }

                   	else if ( (LA142_0 == L_BRACKET) && (synpred40_Smi()) ) { s = 18; }

                   	else if ( (LA142_0 == UPPER) ) { s = 19; }

                   	else if ( (LA142_0 == LOWER) ) { s = 20; }

                   	else if ( (LA142_0 == OPERATION_KW) && (synpred40_Smi()) ) { s = 21; }

                   	else if ( (LA142_0 == ERROR_KW) && (synpred40_Smi()) ) { s = 22; }

                   	else if ( (LA142_0 == 166) && (synpred40_Smi()) ) { s = 23; }

                   	else if ( (LA142_0 == 159) && (synpred40_Smi()) ) { s = 24; }

                   	else if ( (LA142_0 == 164) && (synpred40_Smi()) ) { s = 25; }

                   	else if ( (LA142_0 == 162) && (synpred40_Smi()) ) { s = 26; }

                   	else if ( (LA142_0 == 188) && (synpred40_Smi()) ) { s = 27; }

                   	else if ( (LA142_0 == 163) && (synpred40_Smi()) ) { s = 28; }

                   	else if ( (LA142_0 == 160) && (synpred40_Smi()) ) { s = 29; }

                   	else if ( (LA142_0 == 158) && (synpred40_Smi()) ) { s = 30; }

                   	else if ( (LA142_0 == 131) && (synpred40_Smi()) ) { s = 31; }

                   	else if ( (LA142_0 == 191) && (synpred40_Smi()) ) { s = 32; }

                   	else if ( (LA142_0 == 137) && (synpred40_Smi()) ) { s = 33; }

                   	else if ( (LA142_0 == B_STRING || LA142_0 == C_STRING || LA142_0 == FALSE_KW || LA142_0 == H_STRING || LA142_0 == L_BRACE || (LA142_0 >= MINUS && LA142_0 <= MINUS_INFINITY_KW) || LA142_0 == NUMBER || LA142_0 == PLUS_INFINITY_KW || LA142_0 == TRUE_KW) ) { s = 34; }

                   	 
                   	input.Seek(index142_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA142_11 = input.LA(1);

                   	 
                   	int index142_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred40_Smi()) ) { s = 33; }

                   	else if ( (true) ) { s = 34; }

                   	 
                   	input.Seek(index142_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA142_19 = input.LA(1);

                   	 
                   	int index142_19 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA142_19 == DOT) ) { s = 35; }

                   	else if ( (LA142_19 == L_PAREN) && (synpred40_Smi()) ) { s = 36; }

                   	else if ( (LA142_19 == COMMA) && (synpred40_Smi()) ) { s = 37; }

                   	else if ( (LA142_19 == R_BRACE) && (synpred40_Smi()) ) { s = 38; }

                   	else if ( (LA142_19 == EOF) && (synpred40_Smi()) ) { s = 39; }

                   	 
                   	input.Seek(index142_19);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA142_20 = input.LA(1);

                   	 
                   	int index142_20 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA142_20 == LESS) && (synpred40_Smi()) ) { s = 40; }

                   	else if ( (LA142_20 == EOF || LA142_20 == B_STRING || LA142_20 == C_STRING || (LA142_20 >= COLON && LA142_20 <= COMMA) || LA142_20 == FALSE_KW || LA142_20 == H_STRING || LA142_20 == L_BRACE || LA142_20 == LOWER || (LA142_20 >= MINUS && LA142_20 <= NUMBER) || LA142_20 == PLUS_INFINITY_KW || LA142_20 == R_BRACE || LA142_20 == TRUE_KW || LA142_20 == UPPER) ) { s = 34; }

                   	 
                   	input.Seek(index142_20);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA142_35 = input.LA(1);

                   	 
                   	int index142_35 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA142_35 == UPPER) && (synpred40_Smi()) ) { s = 41; }

                   	else if ( (LA142_35 == LOWER) ) { s = 34; }

                   	 
                   	input.Seek(index142_35);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae142 =
            new NoViableAltException(dfa.Description, 142, _s, input);
        dfa.Error(nvae142);
        throw nvae142;
    }
    const string DFA144_eotS =
        "\x24\xFFFF";
    const string DFA144_eofS =
        "\x24\xFFFF";
    const string DFA144_minS =
        "\x1\x7\x1\x0\x22\xFFFF";
    const string DFA144_maxS =
        "\x1\xBF\x1\x0\x22\xFFFF";
    const string DFA144_acceptS =
        "\x2\xFFFF\x1\x2\x20\xFFFF\x1\x1";
    const string DFA144_specialS =
        "\x1\xFFFF\x1\x0\x22\xFFFF}>";
    static readonly string[] DFA144_transitionS = {
            "\x1\x2\x3\xFFFF\x1\x2\x6\xFFFF\x3\x2\x2\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\xD\xFFFF\x1\x2\x1\xFFFF\x2\x2\x3\xFFFF\x1\x2\x2\xFFFF"+
            "\x1\x2\x2\xFFFF\x3\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2\x1\xFFFF\x1\x1\x3\xFFFF\x1\x2\x4\xFFFF"+
            "\x1\x2\x1\xFFFF\x1\x2\x1\xFFFF\x2\x2\x2\xFFFF\x1\x2\x7\xFFFF"+
            "\x1\x2\x4\xFFFF\x1\x2\x3\xFFFF\x2\x2\x4\xFFFF\x1\x2\x1\xFFFF"+
            "\x1\x2\x5\xFFFF\x6\x2\x7\xFFFF\x1\x2\x5\xFFFF\x1\x2\x14\xFFFF"+
            "\x3\x2\x1\xFFFF\x3\x2\x1\xFFFF\x1\x2\xC\xFFFF\x1\x2\x8\xFFFF"+
            "\x1\x2\x2\xFFFF\x1\x2",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA144_eot = DFA.UnpackEncodedString(DFA144_eotS);
    static readonly short[] DFA144_eof = DFA.UnpackEncodedString(DFA144_eofS);
    static readonly char[] DFA144_min = DFA.UnpackEncodedStringToUnsignedChars(DFA144_minS);
    static readonly char[] DFA144_max = DFA.UnpackEncodedStringToUnsignedChars(DFA144_maxS);
    static readonly short[] DFA144_accept = DFA.UnpackEncodedString(DFA144_acceptS);
    static readonly short[] DFA144_special = DFA.UnpackEncodedString(DFA144_specialS);
    static readonly short[][] DFA144_transition = DFA.UnpackEncodedStringArray(DFA144_transitionS);

    protected class DFA144 : DFA
    {
        public DFA144(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 144;
            this.eot = DFA144_eot;
            this.eof = DFA144_eof;
            this.min = DFA144_min;
            this.max = DFA144_max;
            this.accept = DFA144_accept;
            this.special = DFA144_special;
            this.transition = DFA144_transition;

        }

        override public string Description
        {
            get { return "998:21: (=> tag )?"; }
        }

    }


    protected internal int DFA144_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA144_1 = input.LA(1);

                   	 
                   	int index144_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred41_Smi()) ) { s = 35; }

                   	else if ( (true) ) { s = 2; }

                   	 
                   	input.Seek(index144_1);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae144 =
            new NoViableAltException(dfa.Description, 144, _s, input);
        dfa.Error(nvae144);
        throw nvae144;
    }
    const string DFA161_eotS =
        "\x34\xFFFF";
    const string DFA161_eofS =
        "\x34\xFFFF";
    const string DFA161_minS =
        "\x1\x7\xD\x0\x26\xFFFF";
    const string DFA161_maxS =
        "\x1\xBF\xD\x0\x26\xFFFF";
    const string DFA161_acceptS =
        "\xE\xFFFF\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1E\xFFFF\x1\x7\x1\x8\x1"+
        "\x1";
    const string DFA161_specialS =
        "\x1\x0\x1\x1\x1\x2\x1\x3\x1\x4\x1\x5\x1\x6\x1\x7\x1\x8\x1\x9\x1"+
        "\xA\x1\xB\x1\xC\x1\xD\x26\xFFFF}>";
    static readonly string[] DFA161_transitionS = {
            "\x1\x12\x5\xFFFF\x1\xB\x4\xFFFF\x3\x12\x1\xFFFF\x1\x4\x1\x12"+
            "\x2\xFFFF\x1\x12\xD\xFFFF\x1\x12\x1\xFFFF\x2\x12\x6\xFFFF\x1"+
            "\x12\x1\x2\x1\x10\x3\x12\x1\xA\x1\xFFFF\x1\x12\x4\xFFFF\x1\x12"+
            "\x1\xFFFF\x1\x12\x2\xFFFF\x1\x12\x1\x9\x1\x12\x1\x11\x2\xFFFF"+
            "\x1\x6\x1\xFFFF\x1\xE\x1\x7\x1\xD\x1\x3\x1\x8\x1\x12\x1\xFFFF"+
            "\x2\x12\x2\xFFFF\x1\x12\x2\xFFFF\x1\x31\x2\xFFFF\x1\xC\x1\xFFFF"+
            "\x1\x12\x4\xFFFF\x1\x12\x3\xFFFF\x2\x12\x1\xFFFF\x1\xF\x2\xFFFF"+
            "\x1\x12\x1\xFFFF\x1\x12\x1\x1\x4\xFFFF\x1\x12\x1\x5\x4\x12\x1"+
            "\x32\x6\xFFFF\x1\x12\x5\xFFFF\x1\x12\x14\xFFFF\x3\x12\x1\xFFFF"+
            "\x3\x12\x1\xFFFF\x1\x12\xC\xFFFF\x1\x12\x8\xFFFF\x1\x12\x2\xFFFF"+
            "\x1\x12",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "\x1\xFFFF",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            ""
    };

    static readonly short[] DFA161_eot = DFA.UnpackEncodedString(DFA161_eotS);
    static readonly short[] DFA161_eof = DFA.UnpackEncodedString(DFA161_eofS);
    static readonly char[] DFA161_min = DFA.UnpackEncodedStringToUnsignedChars(DFA161_minS);
    static readonly char[] DFA161_max = DFA.UnpackEncodedStringToUnsignedChars(DFA161_maxS);
    static readonly short[] DFA161_accept = DFA.UnpackEncodedString(DFA161_acceptS);
    static readonly short[] DFA161_special = DFA.UnpackEncodedString(DFA161_specialS);
    static readonly short[][] DFA161_transition = DFA.UnpackEncodedStringArray(DFA161_transitionS);

    protected class DFA161 : DFA
    {
        public DFA161(BaseRecognizer recognizer)
        {
            this.recognizer = recognizer;
            this.decisionNumber = 161;
            this.eot = DFA161_eot;
            this.eof = DFA161_eof;
            this.min = DFA161_min;
            this.max = DFA161_max;
            this.accept = DFA161_accept;
            this.special = DFA161_special;
            this.transition = DFA161_transition;

        }

        override public string Description
        {
            get { return "1022:0: constraint_elements : (=> value |=> value_range | SIZE_KW constraint | FROM_KW constraint | L_PAREN element_set_spec R_PAREN | ( INCLUDES_KW )? type | PATTERN_KW value | WITH_KW ( COMPONENT_KW constraint | COMPONENTS_KW L_BRACE ( DOTDOTDOT COMMA )? type_constraint_list R_BRACE ) );"; }
        }

    }


    protected internal int DFA161_SpecialStateTransition(DFA dfa, int s, IIntStream _input) //throws NoViableAltException
    {
            ITokenStream input = (ITokenStream)_input;
    	int _s = s;
        switch ( s )
        {
               	case 0 : 
                   	int LA161_0 = input.LA(1);

                   	 
                   	int index161_0 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (LA161_0 == TRUE_KW) ) { s = 1; }

                   	else if ( (LA161_0 == FALSE_KW) ) { s = 2; }

                   	else if ( (LA161_0 == NULL_KW) ) { s = 3; }

                   	else if ( (LA161_0 == C_STRING) ) { s = 4; }

                   	else if ( (LA161_0 == UPPER) ) { s = 5; }

                   	else if ( (LA161_0 == LOWER) ) { s = 6; }

                   	else if ( (LA161_0 == MINUS) ) { s = 7; }

                   	else if ( (LA161_0 == NUMBER) ) { s = 8; }

                   	else if ( (LA161_0 == L_BRACE) ) { s = 9; }

                   	else if ( (LA161_0 == H_STRING) ) { s = 10; }

                   	else if ( (LA161_0 == B_STRING) ) { s = 11; }

                   	else if ( (LA161_0 == PLUS_INFINITY_KW) ) { s = 12; }

                   	else if ( (LA161_0 == MINUS_INFINITY_KW) ) { s = 13; }

                   	else if ( (LA161_0 == MIN_KW) && (synpred45_Smi()) ) { s = 14; }

                   	else if ( (LA161_0 == SIZE_KW) ) { s = 15; }

                   	else if ( (LA161_0 == FROM_KW) ) { s = 16; }

                   	else if ( (LA161_0 == L_PAREN) ) { s = 17; }

                   	else if ( (LA161_0 == ANY_KW || (LA161_0 >= BIT_KW && LA161_0 <= BOOLEAN_KW) || LA161_0 == CHARACTER_KW || LA161_0 == CHOICE_KW || LA161_0 == EMBEDDED_KW || (LA161_0 >= ENUMERATED_KW && LA161_0 <= ERROR_KW) || LA161_0 == EXTERNAL_KW || (LA161_0 >= GENERAL_STR_KW && LA161_0 <= GRAPHIC_STR_KW) || LA161_0 == IA5_STRING_KW || LA161_0 == INCLUDES_KW || LA161_0 == INTEGER_KW || LA161_0 == ISO646_STR_KW || LA161_0 == L_BRACKET || LA161_0 == NUMERIC_STR_KW || (LA161_0 >= OBJECT_KW && LA161_0 <= OCTET_KW) || LA161_0 == OPERATION_KW || LA161_0 == PRINTABLE_STR_KW || LA161_0 == REAL_KW || (LA161_0 >= SEQUENCE_KW && LA161_0 <= SET_KW) || LA161_0 == T61_STR_KW || LA161_0 == TELETEX_STR_KW || LA161_0 == UNIVERSAL_STR_KW || (LA161_0 >= UTC_TIME_KW && LA161_0 <= VISIBLE_STR_KW) || LA161_0 == 131 || LA161_0 == 137 || (LA161_0 >= 158 && LA161_0 <= 160) || (LA161_0 >= 162 && LA161_0 <= 164) || LA161_0 == 166 || LA161_0 == 179 || LA161_0 == 188 || LA161_0 == 191) ) { s = 18; }

                   	else if ( (LA161_0 == PATTERN_KW) ) { s = 49; }

                   	else if ( (LA161_0 == WITH_KW) ) { s = 50; }

                   	 
                   	input.Seek(index161_0);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 1 : 
                   	int LA161_1 = input.LA(1);

                   	 
                   	int index161_1 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_1);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 2 : 
                   	int LA161_2 = input.LA(1);

                   	 
                   	int index161_2 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_2);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 3 : 
                   	int LA161_3 = input.LA(1);

                   	 
                   	int index161_3 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index161_3);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 4 : 
                   	int LA161_4 = input.LA(1);

                   	 
                   	int index161_4 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_4);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 5 : 
                   	int LA161_5 = input.LA(1);

                   	 
                   	int index161_5 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index161_5);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 6 : 
                   	int LA161_6 = input.LA(1);

                   	 
                   	int index161_6 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	else if ( (true) ) { s = 18; }

                   	 
                   	input.Seek(index161_6);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 7 : 
                   	int LA161_7 = input.LA(1);

                   	 
                   	int index161_7 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_7);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 8 : 
                   	int LA161_8 = input.LA(1);

                   	 
                   	int index161_8 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_8);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 9 : 
                   	int LA161_9 = input.LA(1);

                   	 
                   	int index161_9 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_9);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 10 : 
                   	int LA161_10 = input.LA(1);

                   	 
                   	int index161_10 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_10);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 11 : 
                   	int LA161_11 = input.LA(1);

                   	 
                   	int index161_11 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_11);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 12 : 
                   	int LA161_12 = input.LA(1);

                   	 
                   	int index161_12 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_12);
                   	if ( s >= 0 ) return s;
                   	break;
               	case 13 : 
                   	int LA161_13 = input.LA(1);

                   	 
                   	int index161_13 = input.Index();
                   	input.Rewind();
                   	s = -1;
                   	if ( (synpred44_Smi()) ) { s = 51; }

                   	else if ( (synpred45_Smi()) ) { s = 14; }

                   	 
                   	input.Seek(index161_13);
                   	if ( s >= 0 ) return s;
                   	break;
        }
        if (state.backtracking > 0) {state.failed = true; return -1;}
        NoViableAltException nvae161 =
            new NoViableAltException(dfa.Description, 161, _s, input);
        dfa.Error(nvae161);
        throw nvae161;
    }
 

    public static readonly BitSet FOLLOW_SL_COMMENT_in_statement1862 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080100000000000UL});
    public static readonly BitSet FOLLOW_module_definition_in_statement1867 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_module_identifier_in_module_definition1884 = new BitSet(new ulong[]{0x0000001000000000UL,0x0000000000000000UL,0x0000020000000000UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1886 = new BitSet(new ulong[]{0x1002800000000C00UL});
    public static readonly BitSet FOLLOW_set_in_module_definition1899 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_TAGS_KW_in_module_definition1911 = new BitSet(new ulong[]{0x0002000000000400UL});
    public static readonly BitSet FOLLOW_EXTENSIBILITY_KW_in_module_definition1920 = new BitSet(new ulong[]{0x2000000000000000UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_module_definition1922 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_module_definition1928 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_module_definition1930 = new BitSet(new ulong[]{0x40010A0000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_module_body_in_module_definition1932 = new BitSet(new ulong[]{0x0000020000000000UL});
    public static readonly BitSet FOLLOW_END_KW_in_module_definition1934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_module_identifier1941 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_module_identifier1944 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_exports_in_module_body1955 = new BitSet(new ulong[]{0x4000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_imports_in_module_body1960 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_assignment_in_module_body1965 = new BitSet(new ulong[]{0x0000080000000002UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_obj_id_comp_lst1977 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_defined_value_in_obj_id_comp_lst1992 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_obj_id_component_in_obj_id_comp_lst1997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000200010400UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_obj_id_comp_lst2001 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_value2012 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_value2014 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_defined_value2018 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component2028 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_obj_id_component2049 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_obj_id_component2052 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_obj_id_component2054 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_obj_id_component2056 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_tag_default2069 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXPORTS_KW_in_exports2084 = new BitSet(new ulong[]{0x0000080000000040UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_list_in_exports2089 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_exports2095 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_SEMI_in_exports2099 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPORTS_KW_in_imports2106 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbols_from_module_in_imports2109 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080008000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_SEMI_in_imports2113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2123 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2125 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2127 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_assignment2142 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_assignment2144 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2146 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_assignment2148 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_assignment2164 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_macroName_in_assignment2168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_153_in_assignment2171 = new BitSet(new ulong[]{0x0000000000000400UL});
    public static readonly BitSet FOLLOW_ASSIGN_OP_in_assignment2173 = new BitSet(new ulong[]{0x0000000000020000UL});
    public static readonly BitSet FOLLOW_BEGIN_KW_in_assignment2175 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_set_in_assignment2177 = new BitSet(new ulong[]{0xFFFFFFFFFFFFFFF0UL,0xFFFFFFFFFFFFFFFFUL,0xFFFFFFFFFFFFFFFFUL,0x000000000000003FUL});
    public static readonly BitSet FOLLOW_END_KW_in_assignment2185 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2199 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_symbol_list2202 = new BitSet(new ulong[]{0x0000080000000000UL,0xC080000000880400UL,0xF0E5405DC01C817BUL,0x0000000000000001UL});
    public static readonly BitSet FOLLOW_symbol_in_symbol_list2204 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_symbol_list_in_symbols_from_module2214 = new BitSet(new ulong[]{0x0010000000000000UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_symbols_from_module2216 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbols_from_module2218 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_symbols_from_module2247 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_symbols_from_module2284 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_symbol2320 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_symbol2324 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macroName_in_symbol2328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_macroName2335 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_macroName2339 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_136_in_macroName2344 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_192_in_macroName2348 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_134_in_macroName2362 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_133_in_macroName2366 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_146_in_macroName2370 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_148_in_macroName2384 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_147_in_macroName2388 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_189_in_macroName2392 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_190_in_macroName2396 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_181_in_macroName2403 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_macroName2407 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_174_in_macroName2411 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_178_in_macroName2415 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_126_in_macroName2419 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_129_in_macroName2426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_128_in_macroName2430 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_127_in_macroName2434 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_132_in_macroName2441 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_143_in_macroName2445 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_183_in_macroName2449 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_182_in_macroName2453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_176_in_macroName2457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_macros_in_macroName2464 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_built_in_type_in_type2471 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_type_in_type2475 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_selection_type_in_type2479 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_macros_type_in_type2483 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_type2487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_value2500 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_value2516 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_value2532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_value2549 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_value2565 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_value2581 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_value2596 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_value2612 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_value2628 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_value2644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_value2660 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_value2676 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_value2692 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_any_type_in_built_in_type2699 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_bit_string_type_in_built_in_type2717 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_boolean_type_in_built_in_type2735 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_str_type_in_built_in_type2753 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_type_in_built_in_type2771 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_embedded_type_in_built_in_type2788 = new BitSet(new ulong[]{0x0000010000000000UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_built_in_type2790 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_built_in_type2792 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_enum_type_in_built_in_type2810 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_external_type_in_built_in_type2827 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_integer_type_in_built_in_type2837 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_null_type_in_built_in_type2847 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_object_identifier_type_in_built_in_type2857 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_octetString_type_in_built_in_type2867 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_real_type_in_built_in_type2877 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_relativeOid_type_in_built_in_type2887 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_type_in_built_in_type2897 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_type_in_built_in_type2907 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_type_in_built_in_type2917 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_setof_type_in_built_in_type2927 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tagged_type_in_built_in_type2937 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2945 = new BitSet(new ulong[]{0x0000002000000000UL});
    public static readonly BitSet FOLLOW_DOT_in_defined_type2947 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000000000UL});
    public static readonly BitSet FOLLOW_UPPER_in_defined_type2951 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_defined_type2954 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_selection_type2964 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_selection_type2966 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_selection_type2968 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ANY_KW_in_any_type2975 = new BitSet(new ulong[]{0x0000000800000002UL});
    public static readonly BitSet FOLLOW_DEFINED_KW_in_any_type2978 = new BitSet(new ulong[]{0x0000000000200000UL});
    public static readonly BitSet FOLLOW_BY_KW_in_any_type2980 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_any_type2982 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BIT_KW_in_bit_string_type2994 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_bit_string_type2996 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_bit_string_type3007 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_bit_string_type3012 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_BOOLEAN_KW_in_boolean_type3023 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHARACTER_KW_in_character_str_type3030 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_character_str_type3032 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_character_set_in_character_str_type3036 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_character_str_type3039 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_CHOICE_KW_in_choice_type3049 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_choice_type3051 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_choice_type3053 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_choice_type3055 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EMBEDDED_KW_in_embedded_type3062 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000008000000UL});
    public static readonly BitSet FOLLOW_PDV_KW_in_embedded_type3064 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ENUMERATED_KW_in_enum_type3071 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_enum_type3073 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXTERNAL_KW_in_external_type3080 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_integer_type3089 = new BitSet(new ulong[]{0x0000000000000002UL,0x00000000000000A0UL});
    public static readonly BitSet FOLLOW_namedNumber_list_in_integer_type3100 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_in_integer_type3104 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_null_type3115 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_object_identifier_type3122 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_object_identifier_type3124 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_octetString_type3131 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_octetString_type3133 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_octetString_type3136 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_REAL_KW_in_real_type3146 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_179_in_relativeOid_type3155 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequence_type3163 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_type3165 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_sequence_type3168 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_type3172 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SEQUENCE_KW_in_sequenceof_type3180 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_sequenceof_type3183 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_sequenceof_type3185 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_sequenceof_type3189 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_sequenceof_type3191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_set_type3198 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_set_type3200 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_elementType_list_in_set_type3203 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_set_type3207 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SET_KW_in_setof_type3214 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000200000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_setof_type3217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_setof_type3219 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_setof_type3223 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_setof_type3225 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_tag_in_tagged_type3232 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_tagged_type3235 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_tagged_type3239 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_namedNumber_list3246 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3248 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_namedNumber_list3251 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_namedNumber_list3253 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_namedNumber_list3257 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint3264 = new BitSet(new ulong[]{0x85FC4D0004DC20C0UL,0x1FC34B18A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_specs_in_constraint3267 = new BitSet(new ulong[]{0x0000400000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_exception_spec_in_constraint3272 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint3276 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_character_set3283 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3385 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_elementType_list3388 = new BitSet(new ulong[]{0x0000000100000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_elementType_in_elementType_list3390 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_tag3400 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_clazz_in_tag3403 = new BitSet(new ulong[]{0x0000000000000100UL,0x00A0000100010400UL});
    public static readonly BitSet FOLLOW_class_NUMBER_in_tag3407 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000400000000UL});
    public static readonly BitSet FOLLOW_R_BRACKET_in_tag3409 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_clazz3416 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NUMBER_in_class_NUMBER3433 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_class_NUMBER3437 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OPERATION_KW_in_operation_macro3446 = new BitSet(new ulong[]{0x0000100000000202UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_ARGUMENT_KW_in_operation_macro3449 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3458 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3462 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000004000000200UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_operation_macro3496 = new BitSet(new ulong[]{0x04E41D00049C0082UL,0x0FC14310809A8652UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_operation_macro3537 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_operation_macro3541 = new BitSet(new ulong[]{0x0000100000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_operation_macro3583 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3585 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_operation_errorlist_in_operation_macro3588 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3592 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000200UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_operation_macro3626 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_operation_macro3628 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34312A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_linkedOp_list_in_operation_macro3631 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_operation_macro3635 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERROR_KW_in_error_macro3655 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000002000000UL});
    public static readonly BitSet FOLLOW_PARAMETER_KW_in_error_macro3659 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_LOWER_in_error_macro3668 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_error_macro3672 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_operation_macro_in_macros_type3690 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_error_macro_in_macros_type3694 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objecttype_macro_in_macros_type3698 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_in_macros_type3702 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_in_macros_type3718 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_in_macros_type3722 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_in_macros_type3726 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_in_macros_type3742 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_in_macros_type3746 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_in_macros_type3750 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_in_macros_type3766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_traptype_macro_in_macros_type3770 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_smi_macros3777 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_137_in_smi_type3844 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INTEGER_KW_in_smi_type3848 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OCTET_KW_in_smi_type3852 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000200000000000UL});
    public static readonly BitSet FOLLOW_STRING_KW_in_smi_type3854 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_smi_type3858 = new BitSet(new ulong[]{0x0800000000000000UL});
    public static readonly BitSet FOLLOW_IDENTIFIER_KW_in_smi_type3860 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_smi_type3864 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3878 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3880 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3883 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3885 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3906 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000080000000000UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_smi_subtyping3908 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_smi_subtyping3910 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3912 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_BAR_in_smi_subtyping3915 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_range_in_smi_subtyping3917 = new BitSet(new ulong[]{0x0000000000004000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3921 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_smi_subtyping3923 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3929 = new BitSet(new ulong[]{0x0000004000000002UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_subtype_range3932 = new BitSet(new ulong[]{0x0100000000002000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_subtype_value_in_subtype_range3934 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_subtype_value3944 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_subtype_value3948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_subtype_value3952 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_subtype_value3956 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_166_in_objecttype_macro3965 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_objecttype_macro3967 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro4000 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_namedbits_in_objecttype_macro4002 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_type_in_objecttype_macro4034 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_objecttype_macro4037 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_type_in_objecttype_macro4064 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL,0x0000000000000004UL});
    public static readonly BitSet FOLLOW_194_in_objecttype_macro4108 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4110 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100310008000004UL});
    public static readonly BitSet FOLLOW_set_in_objecttype_macro4135 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_accesstypes_in_objecttype_macro4143 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_168_in_objecttype_macro4167 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_pibaccess_in_objecttype_macro4169 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100300000000000UL});
    public static readonly BitSet FOLLOW_172_in_objecttype_macro4207 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4209 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4211 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4213 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100200000000000UL});
    public static readonly BitSet FOLLOW_173_in_objecttype_macro4254 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4256 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4258 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4260 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objecttype_macro4307 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_statustypes_in_objecttype_macro4309 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C23080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_objecttype_macro4338 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4340 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000C21080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_151_in_objecttype_macro4396 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4400 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4403 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objecttype_macro_error_in_objecttype_macro4405 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4409 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_177_in_objecttype_macro4424 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objecttype_macro4426 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000040000421080UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4447 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4449 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_135_in_objecttype_macro4474 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_augments_in_objecttype_macro4476 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_170_in_objecttype_macro4501 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4503 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4505 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4507 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_145_in_objecttype_macro4553 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4555 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4557 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4559 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000401000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_150_in_objecttype_macro4627 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_objecttype_macro_index_in_objecttype_macro4629 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL,0x0000000000000002UL});
    public static readonly BitSet FOLLOW_193_in_objecttype_macro4678 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4680 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4683 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro4686 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4688 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4695 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000001000UL});
    public static readonly BitSet FOLLOW_140_in_objecttype_macro4734 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro4736 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_bitsvalue_in_objecttype_macro4777 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro4804 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro4828 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_accesstypes4842 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_pibaccess4895 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_statustypes4948 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_index4998 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5000 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_index5003 = new BitSet(new ulong[]{0x2108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_objecttype_macro_indextype_in_objecttype_macro_index5005 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_index5009 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_IMPLIED_KW_in_objecttype_macro_indextype5023 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_indextype5027 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_augments5033 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objecttype_macro_augments5035 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_augments5037 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_namedbits5047 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5050 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5053 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5055 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5057 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_namedbits5060 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_namedbits5063 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_namedbits5066 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_namedbits5068 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_namedbits5070 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_namedbits5074 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objecttype_macro_bitsvalue5085 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5087 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objecttype_macro_bitsvalue5090 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_bitsvalue5092 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objecttype_macro_bitsvalue5096 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objecttype_macro_error5107 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_objecttype_macro_error5109 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_objecttype_macro_error5111 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_objecttype_macro_error5113 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_159_in_moduleidentity_macro5122 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0200000001000000UL});
    public static readonly BitSet FOLLOW_185_in_moduleidentity_macro5150 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_moduleidentity_macro5152 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categories_in_moduleidentity_macro5154 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_moduleidentity_macro5156 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_152_in_moduleidentity_macro5186 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5188 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000008000000000UL});
    public static readonly BitSet FOLLOW_167_in_moduleidentity_macro5190 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5192 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_138_in_moduleidentity_macro5194 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5196 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro5223 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro5225 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_revision_in_moduleidentity_macro5228 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0010000000000000UL});
    public static readonly BitSet FOLLOW_180_in_moduleidentity_macro_revision5237 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5239 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_moduleidentity_macro_revision5241 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_moduleidentity_macro_revision5243 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categories5252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5290 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_moduleidentity_macro_categories5293 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_moduleidentity_macro_categoryid_in_moduleidentity_macro_categories5295 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_moduleidentity_macro_categoryid5303 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_moduleidentity_macro_categoryid5305 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_moduleidentity_macro_categoryid5307 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_moduleidentity_macro_categoryid5309 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_164_in_objectidentity_macro5319 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectidentity_macro5321 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectidentity_macro_statustypes_in_objectidentity_macro5323 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectidentity_macro5325 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5327 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectidentity_macro5330 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectidentity_macro5332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectidentity_macro_statustypes5345 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_162_in_notificationtype_macro5398 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100002000000000UL});
    public static readonly BitSet FOLLOW_165_in_notificationtype_macro5401 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationtype_macro5403 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5405 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationtype_macro5408 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationtype_macro5410 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationtype_macro5414 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationtype_macro5463 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationtype_macro_status_in_notificationtype_macro5465 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationtype_macro5467 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5469 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationtype_macro5472 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationtype_macro5474 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationtype_macro_status5487 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_188_in_textualconvention_macro5539 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000004000UL});
    public static readonly BitSet FOLLOW_142_in_textualconvention_macro5542 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5544 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_textualconvention_macro5577 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_status_in_textualconvention_macro5579 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_textualconvention_macro5610 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5612 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0802000000000000UL});
    public static readonly BitSet FOLLOW_177_in_textualconvention_macro5644 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_textualconvention_macro5646 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000000000UL});
    public static readonly BitSet FOLLOW_187_in_textualconvention_macro5679 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_smi_type_in_textualconvention_macro5691 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_textualconvention_macro5693 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5695 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_textualconvention_macro5735 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_textualconvention_macro_namedbit_in_textualconvention_macro5737 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_textualconvention_macro5741 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_textualconvention_macro5745 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_status5756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_textualconvention_macro_namedbit5805 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_textualconvention_macro_namedbit5807 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_MINUS_in_textualconvention_macro_namedbit5810 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_textualconvention_macro_namedbit5814 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_textualconvention_macro_namedbit5816 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_163_in_objectgroup_macro5825 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000002000000000UL});
    public static readonly BitSet FOLLOW_165_in_objectgroup_macro5827 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_objectgroup_macro5829 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5831 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_objectgroup_macro5834 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_objectgroup_macro5836 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_objectgroup_macro5840 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_objectgroup_macro5867 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_objectgroup_macro_status_in_objectgroup_macro5869 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_objectgroup_macro5871 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5873 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_objectgroup_macro5876 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_objectgroup_macro5878 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_objectgroup_macro_status5889 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_160_in_notificationgroup_macro5941 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_161_in_notificationgroup_macro5943 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_notificationgroup_macro5945 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5947 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_notificationgroup_macro5950 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_notificationgroup_macro5952 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_notificationgroup_macro5956 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_notificationgroup_macro5983 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_notificationgroup_macro_status_in_notificationgroup_macro5985 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_notificationgroup_macro5987 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5989 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_notificationgroup_macro5992 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_notificationgroup_macro5994 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_notificationgroup_macro_status6005 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_158_in_modulecompliance_macro6057 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_modulecompliance_macro6059 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_status_in_modulecompliance_macro6061 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro6087 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6089 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_177_in_modulecompliance_macro6092 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro6094 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_module_in_modulecompliance_macro6099 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000020000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_status6110 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_157_in_modulecompliance_macro_module6158 = new BitSet(new ulong[]{0x0000000000000002UL,0x0080000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_UPPER_in_modulecompliance_macro_module6167 = new BitSet(new ulong[]{0x0108000000402002UL,0x008200002009E420UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6176 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000004200000UL});
    public static readonly BitSet FOLLOW_154_in_modulecompliance_macro_module6217 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_module6219 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6221 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_module6224 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_module6226 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_module6230 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_compliance_in_modulecompliance_macro_module6267 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000080000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_149_in_modulecompliance_macro_compliance6276 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6278 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6280 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6282 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_OBJECT_KW_in_modulecompliance_macro_compliance6319 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_modulecompliance_macro_compliance6321 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_modulecompliance_macro_compliance6361 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6363 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_modulecompliance_macro_compliance6405 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_syntax_in_modulecompliance_macro_compliance6407 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080010002000UL});
    public static readonly BitSet FOLLOW_156_in_modulecompliance_macro_compliance6454 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_access_in_modulecompliance_macro_compliance6456 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000080000002000UL});
    public static readonly BitSet FOLLOW_171_in_modulecompliance_macro_compliance6498 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_pibaccess_in_modulecompliance_macro_compliance6500 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_modulecompliance_macro_compliance6545 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_modulecompliance_macro_compliance6547 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6561 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_modulecompliance_macro_syntax6563 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6565 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_modulecompliance_macro_syntax6568 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_modulecompliance_macro_namedbit_in_modulecompliance_macro_syntax6570 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_modulecompliance_macro_syntax6574 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_modulecompliance_macro_syntax6613 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_modulecompliance_macro_syntax6616 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_modulecompliance_macro_syntax6651 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_namedbit6657 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_modulecompliance_macro_namedbit6659 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_modulecompliance_macro_namedbit6661 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_modulecompliance_macro_namedbit6663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_access6671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_modulecompliance_macro_pibaccess6721 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_131_in_agentcapabilities_macro6772 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000800000000000UL});
    public static readonly BitSet FOLLOW_175_in_agentcapabilities_macro6774 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6776 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0100000000000000UL});
    public static readonly BitSet FOLLOW_184_in_agentcapabilities_macro6778 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_status_in_agentcapabilities_macro6780 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro6807 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6809 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0402000000000000UL});
    public static readonly BitSet FOLLOW_177_in_agentcapabilities_macro6812 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro6814 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_module_in_agentcapabilities_macro6819 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0400000000000000UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_status6829 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_186_in_agentcapabilities_macro_module6877 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_module6879 = new BitSet(new ulong[]{0x8108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6882 = new BitSet(new ulong[]{0x8000000000000000UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_agentcapabilities_macro_module6919 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_module6921 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6923 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_module6926 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_module6928 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_module6932 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_variation_in_agentcapabilities_macro_module6968 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0000000000000000UL,0x0000000000000010UL});
    public static readonly BitSet FOLLOW_196_in_agentcapabilities_macro_variation6976 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation6978 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0800000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_187_in_agentcapabilities_macro_variation6981 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6983 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_197_in_agentcapabilities_macro_variation6988 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_syntax_in_agentcapabilities_macro_variation6990 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003804UL});
    public static readonly BitSet FOLLOW_130_in_agentcapabilities_macro_variation6995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_access_in_agentcapabilities_macro_variation6997 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003800UL});
    public static readonly BitSet FOLLOW_139_in_agentcapabilities_macro_variation7039 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7041 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7043 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7046 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7048 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7052 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000003000UL});
    public static readonly BitSet FOLLOW_140_in_agentcapabilities_macro_variation7094 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7096 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_variation7117 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7120 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_variation7125 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_variation7127 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_variation7131 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_value_in_agentcapabilities_macro_variation7135 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000002000UL});
    public static readonly BitSet FOLLOW_141_in_agentcapabilities_macro_variation7178 = new BitSet(new ulong[]{0x0000000000400000UL});
    public static readonly BitSet FOLLOW_C_STRING_in_agentcapabilities_macro_variation7180 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7231 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_agentcapabilities_macro_syntax7233 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7235 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_agentcapabilities_macro_syntax7238 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_agentcapabilities_macro_namedbit_in_agentcapabilities_macro_syntax7240 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_agentcapabilities_macro_syntax7244 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_agentcapabilities_macro_syntax7284 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_smi_subtyping_in_agentcapabilities_macro_syntax7287 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_agentcapabilities_macro_syntax7323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_access7332 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_agentcapabilities_macro_namedbit7380 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_agentcapabilities_macro_namedbit7382 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_agentcapabilities_macro_namedbit7384 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_agentcapabilities_macro_namedbit7386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_191_in_traptype_macro7396 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_144_in_traptype_macro7398 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7400 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL,0x0000000000000008UL});
    public static readonly BitSet FOLLOW_195_in_traptype_macro7403 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_traptype_macro7405 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7407 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_traptype_macro7410 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7412 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_traptype_macro7416 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000002000UL});
    public static readonly BitSet FOLLOW_141_in_traptype_macro7448 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7450 = new BitSet(new ulong[]{0x0000000000000002UL,0x0000000000000000UL,0x0002000000000000UL});
    public static readonly BitSet FOLLOW_177_in_traptype_macro7455 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_traptype_macro7457 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7467 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_operation_errorlist7470 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_operation_errorlist7472 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7482 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_linkedOp_list7485 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_linkedOp_list7487 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_type_in_typeorvalue7503 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_typeorvalue7507 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7515 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_typeorvaluelist7518 = new BitSet(new ulong[]{0x05EC0D0004DC2080UL,0x0FC34310A09BE472UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_typeorvalue_in_typeorvaluelist7520 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_elementType7532 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_in_elementType7550 = new BitSet(new ulong[]{0x14E48D00049C0880UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_tag_default_in_elementType7576 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7580 = new BitSet(new ulong[]{0x0000000400000002UL,0x0000000001000000UL});
    public static readonly BitSet FOLLOW_OPTIONAL_KW_in_elementType7583 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_DEFAULT_KW_in_elementType7587 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_elementType7589 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_elementType7607 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000200000UL});
    public static readonly BitSet FOLLOW_OF_KW_in_elementType7609 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_elementType7611 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_namedNumber7620 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_namedNumber7622 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000012400UL});
    public static readonly BitSet FOLLOW_signed_number_in_namedNumber7625 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_defined_value_in_namedNumber7629 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_namedNumber7632 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_in_signed_number7640 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010000UL});
    public static readonly BitSet FOLLOW_NUMBER_in_signed_number7644 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7651 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7654 = new BitSet(new ulong[]{0x0000008000000000UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_element_set_specs7656 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_element_set_specs7661 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_element_set_specs7663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_EXCLAMATION_in_exception_spec7673 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809BA452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_signed_number_in_exception_spec7700 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_exception_spec7729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_exception_spec7752 = new BitSet(new ulong[]{0x0000000010000000UL});
    public static readonly BitSet FOLLOW_COLON_in_exception_spec7754 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_exception_spec7756 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7781 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_set_in_element_set_spec7785 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_intersections_in_element_set_spec7793 = new BitSet(new ulong[]{0x0000000000004002UL,0x0008000000000000UL});
    public static readonly BitSet FOLLOW_ALL_KW_in_element_set_spec7817 = new BitSet(new ulong[]{0x0000200000000000UL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_element_set_spec7819 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_element_set_spec7821 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7828 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7831 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7833 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_set_in_intersections7856 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7864 = new BitSet(new ulong[]{0x0000200000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_EXCEPT_KW_in_intersections7867 = new BitSet(new ulong[]{0x85FC0D0004DC2080UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_constraint_elements_in_intersections7869 = new BitSet(new ulong[]{0x0000000000000002UL,0x000000000000000CUL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements7888 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_range_in_constraint_elements7918 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_SIZE_KW_in_constraint_elements7941 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7943 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FROM_KW_in_constraint_elements7967 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements7969 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_PAREN_in_constraint_elements7993 = new BitSet(new ulong[]{0x85FC0D0004DC20C0UL,0x1FC34B10A49BF4F2UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_element_set_spec_in_constraint_elements7995 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000800000000UL});
    public static readonly BitSet FOLLOW_R_PAREN_in_constraint_elements7997 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_INCLUDES_KW_in_constraint_elements8022 = new BitSet(new ulong[]{0x04E40D00049C0080UL,0x0FC14310809A8452UL,0x9008005DC0000208UL});
    public static readonly BitSet FOLLOW_type_in_constraint_elements8026 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PATTERN_KW_in_constraint_elements8050 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_constraint_elements8052 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_WITH_KW_in_constraint_elements8076 = new BitSet(new ulong[]{0x0000000180000000UL});
    public static readonly BitSet FOLLOW_COMPONENT_KW_in_constraint_elements8079 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000080UL});
    public static readonly BitSet FOLLOW_constraint_in_constraint_elements8081 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_COMPONENTS_KW_in_constraint_elements8116 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_constraint_elements8118 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_DOTDOTDOT_in_constraint_elements8121 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_constraint_elements8123 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_type_constraint_list_in_constraint_elements8160 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_constraint_elements8162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_value_range8171 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_MIN_KW_in_value_range8175 = new BitSet(new ulong[]{0x0000004000000000UL,0x0000000000000100UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8179 = new BitSet(new ulong[]{0x0000004000000000UL});
    public static readonly BitSet FOLLOW_DOTDOT_in_value_range8183 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001ED20UL});
    public static readonly BitSet FOLLOW_LESS_in_value_range8186 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001EC20UL});
    public static readonly BitSet FOLLOW_value_in_value_range8191 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MAX_KW_in_value_range8195 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8204 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_type_constraint_list8207 = new BitSet(new ulong[]{0x0000008000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_constraint_in_type_constraint_list8209 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_constraint8219 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000080UL});
    public static readonly BitSet FOLLOW_constraint_in_named_constraint8222 = new BitSet(new ulong[]{0x0000000000000012UL,0x0000000041000000UL});
    public static readonly BitSet FOLLOW_set_in_named_constraint8226 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_choice_value8245 = new BitSet(new ulong[]{0x0108000010402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_COLON_in_choice_value8248 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_choice_value8252 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequence_value8259 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8262 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequence_value8267 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_named_value_in_sequence_value8269 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequence_value8273 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_sequenceof_value8280 = new BitSet(new ulong[]{0x0108000020402000UL,0x008200022001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8283 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_sequenceof_value8288 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_sequenceof_value8290 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_sequenceof_value8294 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_cstr_value8307 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_cstr_value8328 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_cstr_value8343 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_id_list_in_cstr_value8366 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_cstr_value8391 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_cstr_value8410 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_cstr_value8426 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8433 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_id_list8436 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_id_list8438 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8448 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_char_defs_list8451 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000000420UL});
    public static readonly BitSet FOLLOW_char_defs_in_char_defs_list8453 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8464 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8466 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8468 = new BitSet(new ulong[]{0x0000000020000002UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8471 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8473 = new BitSet(new ulong[]{0x0000000020000000UL});
    public static readonly BitSet FOLLOW_COMMA_in_tuple_or_quad8475 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000012000UL});
    public static readonly BitSet FOLLOW_signed_number_in_tuple_or_quad8477 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_char_defs8488 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_char_defs8502 = new BitSet(new ulong[]{0x0000000000400000UL,0x0080000000012420UL});
    public static readonly BitSet FOLLOW_tuple_or_quad_in_char_defs8504 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_R_BRACE_in_char_defs8506 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_char_defs8519 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_named_value8529 = new BitSet(new ulong[]{0x0108000000402000UL,0x008200002001E420UL});
    public static readonly BitSet FOLLOW_value_in_named_value8531 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred1_Smi1981 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred1_Smi1983 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequence_value_in_synpred10_Smi2607 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_sequenceof_value_in_synpred11_Smi2623 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_cstr_value_in_synpred12_Smi2639 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_obj_id_comp_lst_in_synpred13_Smi2655 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_PLUS_INFINITY_KW_in_synpred14_Smi2671 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_MINUS_INFINITY_KW_in_synpred15_Smi2687 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred16_Smi3000 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred16_Smi3002 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred17_Smi3093 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_namedNumber_in_synpred17_Smi3095 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred18_Smi3453 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_RESULT_KW_in_synpred19_Smi3491 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred2_Smi2279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred20_Smi3525 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred21_Smi3532 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_ERRORS_KW_in_synpred22_Smi3578 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LINKED_KW_in_synpred23_Smi3621 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred24_Smi3663 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred25_Smi3993 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred25_Smi3995 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred26_Smi4029 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred27_Smi4333 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_set_in_synpred28_Smi4438 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_140_in_synpred29_Smi4729 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_TRUE_KW_in_synpred3_Smi2495 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred30_Smi4762 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000400UL});
    public static readonly BitSet FOLLOW_LOWER_in_synpred30_Smi4764 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000000UL});
    public static readonly BitSet FOLLOW_set_in_synpred30_Smi4766 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred31_Smi5684 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred31_Smi5686 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_UPPER_in_synpred32_Smi6162 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred33_Smi6171 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred34_Smi6554 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred34_Smi6556 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred35_Smi6608 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred36_Smi7100 = new BitSet(new ulong[]{0x0000000020000000UL,0x0000000200000400UL});
    public static readonly BitSet FOLLOW_set_in_synpred36_Smi7102 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred37_Smi7187 = new BitSet(new ulong[]{0x0000000000000000UL,0x0000000000000020UL});
    public static readonly BitSet FOLLOW_L_BRACE_in_synpred37_Smi7189 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_smi_type_in_synpred38_Smi7279 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_141_in_synpred39_Smi7443 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_FALSE_KW_in_synpred4_Smi2511 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_type_in_synpred40_Smi7498 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_L_BRACKET_in_synpred41_Smi7537 = new BitSet(new ulong[]{0x0000000000000000UL,0x0080000000010400UL});
    public static readonly BitSet FOLLOW_set_in_synpred41_Smi7539 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred42_Smi7695 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred43_Smi7724 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_in_synpred44_Smi7883 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_value_range_in_synpred45_Smi7913 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_H_STRING_in_synpred46_Smi8302 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_B_STRING_in_synpred47_Smi8323 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_id_list_in_synpred48_Smi8361 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_char_defs_list_in_synpred49_Smi8386 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_NULL_KW_in_synpred5_Smi2527 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_C_STRING_in_synpred6_Smi2544 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_defined_value_in_synpred7_Smi2560 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_signed_number_in_synpred8_Smi2576 = new BitSet(new ulong[]{0x0000000000000002UL});
    public static readonly BitSet FOLLOW_choice_value_in_synpred9_Smi2591 = new BitSet(new ulong[]{0x0000000000000002UL});

}
}