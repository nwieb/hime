/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.3.1.0
 */
using System.Collections.Generic;
using System.IO;
using Hime.Redist;
using Hime.Redist.Lexer;

namespace Hime.SDK.Input
{
	/// <summary>
	/// Represents a lexer
	/// </summary>
	internal class HimeGrammarLexer : ContextFreeLexer
	{
		/// <summary>
		/// The automaton for this lexer
		/// </summary>
		private static readonly Automaton commonAutomaton = Automaton.Find(typeof(HimeGrammarLexer), "HimeGrammarLexer.bin");
		/// <summary>
		/// Contains the constant IDs for the terminals for this lexer
		/// </summary>
		public class ID
		{
			/// <summary>
			/// The unique identifier for terminal SEPARATOR
			/// </summary>
			public const int TerminalSeparator = 0x0007;
			/// <summary>
			/// The unique identifier for terminal NAME
			/// </summary>
			public const int TerminalName = 0x0009;
			/// <summary>
			/// The unique identifier for terminal INTEGER
			/// </summary>
			public const int TerminalInteger = 0x000A;
			/// <summary>
			/// The unique identifier for terminal LITERAL_STRING
			/// </summary>
			public const int TerminalLiteralString = 0x000C;
			/// <summary>
			/// The unique identifier for terminal LITERAL_ANY
			/// </summary>
			public const int TerminalLiteralAny = 0x000D;
			/// <summary>
			/// The unique identifier for terminal LITERAL_TEXT
			/// </summary>
			public const int TerminalLiteralText = 0x000E;
			/// <summary>
			/// The unique identifier for terminal LITERAL_CLASS
			/// </summary>
			public const int TerminalLiteralClass = 0x000F;
			/// <summary>
			/// The unique identifier for terminal UNICODE_BLOCK
			/// </summary>
			public const int TerminalUnicodeBlock = 0x0010;
			/// <summary>
			/// The unique identifier for terminal UNICODE_CATEGORY
			/// </summary>
			public const int TerminalUnicodeCategory = 0x0011;
			/// <summary>
			/// The unique identifier for terminal UNICODE_CODEPOINT
			/// </summary>
			public const int TerminalUnicodeCodepoint = 0x0012;
			/// <summary>
			/// The unique identifier for terminal UNICODE_SPAN_MARKER
			/// </summary>
			public const int TerminalUnicodeSpanMarker = 0x0013;
			/// <summary>
			/// The unique identifier for terminal OPERATOR_OPTIONAL
			/// </summary>
			public const int TerminalOperatorOptional = 0x0014;
			/// <summary>
			/// The unique identifier for terminal OPERATOR_ZEROMORE
			/// </summary>
			public const int TerminalOperatorZeromore = 0x0015;
			/// <summary>
			/// The unique identifier for terminal OPERATOR_ONEMORE
			/// </summary>
			public const int TerminalOperatorOnemore = 0x0016;
			/// <summary>
			/// The unique identifier for terminal OPERATOR_UNION
			/// </summary>
			public const int TerminalOperatorUnion = 0x0017;
			/// <summary>
			/// The unique identifier for terminal OPERATOR_DIFFERENCE
			/// </summary>
			public const int TerminalOperatorDifference = 0x0018;
			/// <summary>
			/// The unique identifier for terminal TREE_ACTION_PROMOTE
			/// </summary>
			public const int TerminalTreeActionPromote = 0x0019;
			/// <summary>
			/// The unique identifier for terminal TREE_ACTION_DROP
			/// </summary>
			public const int TerminalTreeActionDrop = 0x001A;
			/// <summary>
			/// The unique identifier for terminal BLOCK_OPTIONS
			/// </summary>
			public const int TerminalBlockOptions = 0x001B;
			/// <summary>
			/// The unique identifier for terminal BLOCK_TERMINALS
			/// </summary>
			public const int TerminalBlockTerminals = 0x001C;
			/// <summary>
			/// The unique identifier for terminal BLOCK_RULES
			/// </summary>
			public const int TerminalBlockRules = 0x001D;
			/// <summary>
			/// The unique identifier for terminal BLOCK_CONTEXT
			/// </summary>
			public const int TerminalBlockContext = 0x001E;
		}
		/// <summary>
		/// Contains the constant IDs for the contexts for this lexer
		/// </summary>
		public class Context
		{
			/// <summary>
			/// The unique identifier for the default context
			/// </summary>
			public const int Default = 0;
		}
		/// <summary>
		/// The collection of terminals matched by this lexer
		/// </summary>
		/// <remarks>
		/// The terminals are in an order consistent with the automaton,
		/// so that terminal indices in the automaton can be used to retrieve the terminals in this table
		/// </remarks>
		private static readonly Symbol[] terminals = {
			new Symbol(0x0001, "ε"),
			new Symbol(0x0002, "$"),
			new Symbol(0x0007, "SEPARATOR"),
			new Symbol(0x0009, "NAME"),
			new Symbol(0x000A, "INTEGER"),
			new Symbol(0x000C, "LITERAL_STRING"),
			new Symbol(0x000D, "LITERAL_ANY"),
			new Symbol(0x000E, "LITERAL_TEXT"),
			new Symbol(0x000F, "LITERAL_CLASS"),
			new Symbol(0x0010, "UNICODE_BLOCK"),
			new Symbol(0x0011, "UNICODE_CATEGORY"),
			new Symbol(0x0012, "UNICODE_CODEPOINT"),
			new Symbol(0x0013, "UNICODE_SPAN_MARKER"),
			new Symbol(0x0014, "OPERATOR_OPTIONAL"),
			new Symbol(0x0015, "OPERATOR_ZEROMORE"),
			new Symbol(0x0016, "OPERATOR_ONEMORE"),
			new Symbol(0x0017, "OPERATOR_UNION"),
			new Symbol(0x0018, "OPERATOR_DIFFERENCE"),
			new Symbol(0x0019, "TREE_ACTION_PROMOTE"),
			new Symbol(0x001A, "TREE_ACTION_DROP"),
			new Symbol(0x001B, "BLOCK_OPTIONS"),
			new Symbol(0x001C, "BLOCK_TERMINALS"),
			new Symbol(0x001D, "BLOCK_RULES"),
			new Symbol(0x001E, "BLOCK_CONTEXT"),
			new Symbol(0x0043, "="),
			new Symbol(0x0044, ";"),
			new Symbol(0x0045, "("),
			new Symbol(0x0046, ")"),
			new Symbol(0x0048, "{"),
			new Symbol(0x0049, ","),
			new Symbol(0x004A, "}"),
			new Symbol(0x004F, "->"),
			new Symbol(0x0050, "fragment"),
			new Symbol(0x0052, "@"),
			new Symbol(0x0053, "<"),
			new Symbol(0x0055, ">"),
			new Symbol(0x0056, "#"),
			new Symbol(0x005E, ":"),
			new Symbol(0x0060, "grammar") };
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public HimeGrammarLexer(string input) : base(commonAutomaton, terminals, 0x0007, input) {}
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public HimeGrammarLexer(TextReader input) : base(commonAutomaton, terminals, 0x0007, input) {}
	}
}
