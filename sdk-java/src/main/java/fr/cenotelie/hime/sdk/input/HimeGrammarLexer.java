/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.3.1.0
 */

package fr.cenotelie.hime.sdk.input;

import fr.cenotelie.hime.redist.Symbol;
import fr.cenotelie.hime.redist.lexer.Automaton;
import fr.cenotelie.hime.redist.lexer.ContextFreeLexer;

import java.io.InputStreamReader;

/**
 * Represents a lexer
 */
class HimeGrammarLexer extends ContextFreeLexer {
    /**
     * The automaton for this lexer
     */
    private static final Automaton commonAutomaton = Automaton.find(HimeGrammarLexer.class, "HimeGrammarLexer.bin");

    /**
     * Contains the constant IDs for the terminals for this lexer
     */
    public static class ID {
        /**
         * The unique identifier for terminal NAME
         */
        public static final int TERMINAL_NAME = 0x0009;
        /**
         * The unique identifier for terminal NAME_FIRST
         */
        public static final int TERMINAL_NAME_FIRST = 0x0008;
        /**
         * The unique identifier for terminal LITERAL_ANY
         */
        public static final int TERMINAL_LITERAL_ANY = 0x000D;
        /**
         * The unique identifier for terminal OPERATOR_OPTIONAL
         */
        public static final int TERMINAL_OPERATOR_OPTIONAL = 0x0014;
        /**
         * The unique identifier for terminal OPERATOR_ZEROMORE
         */
        public static final int TERMINAL_OPERATOR_ZEROMORE = 0x0015;
        /**
         * The unique identifier for terminal OPERATOR_ONEMORE
         */
        public static final int TERMINAL_OPERATOR_ONEMORE = 0x0016;
        /**
         * The unique identifier for terminal OPERATOR_UNION
         */
        public static final int TERMINAL_OPERATOR_UNION = 0x0017;
        /**
         * The unique identifier for terminal OPERATOR_DIFFERENCE
         */
        public static final int TERMINAL_OPERATOR_DIFFERENCE = 0x0018;
        /**
         * The unique identifier for terminal TREE_ACTION_PROMOTE
         */
        public static final int TERMINAL_TREE_ACTION_PROMOTE = 0x0019;
        /**
         * The unique identifier for terminal TREE_ACTION_DROP
         */
        public static final int TERMINAL_TREE_ACTION_DROP = 0x001A;
        /**
         * The unique identifier for terminal SEPARATOR
         */
        public static final int TERMINAL_SEPARATOR = 0x0007;
        /**
         * The unique identifier for terminal NEW_LINE
         */
        public static final int TERMINAL_NEW_LINE = 0x0003;
        /**
         * The unique identifier for terminal WHITE_SPACE
         */
        public static final int TERMINAL_WHITE_SPACE = 0x0004;
        /**
         * The unique identifier for terminal INTEGER
         */
        public static final int TERMINAL_INTEGER = 0x000A;
        /**
         * The unique identifier for terminal LITERAL_STRING
         */
        public static final int TERMINAL_LITERAL_STRING = 0x000C;
        /**
         * The unique identifier for terminal UNICODE_SPAN_MARKER
         */
        public static final int TERMINAL_UNICODE_SPAN_MARKER = 0x0013;
        /**
         * The unique identifier for terminal ESCAPEES
         */
        public static final int TERMINAL_ESCAPEES = 0x000B;
        /**
         * The unique identifier for terminal COMMENT_LINE
         */
        public static final int TERMINAL_COMMENT_LINE = 0x0005;
        /**
         * The unique identifier for terminal UNICODE_CODEPOINT
         */
        public static final int TERMINAL_UNICODE_CODEPOINT = 0x0012;
        /**
         * The unique identifier for terminal LITERAL_CLASS
         */
        public static final int TERMINAL_LITERAL_CLASS = 0x000F;
        /**
         * The unique identifier for terminal LITERAL_TEXT
         */
        public static final int TERMINAL_LITERAL_TEXT = 0x000E;
        /**
         * The unique identifier for terminal COMMENT_BLOCK
         */
        public static final int TERMINAL_COMMENT_BLOCK = 0x0006;
        /**
         * The unique identifier for terminal UNICODE_BLOCK
         */
        public static final int TERMINAL_UNICODE_BLOCK = 0x0010;
        /**
         * The unique identifier for terminal UNICODE_CATEGORY
         */
        public static final int TERMINAL_UNICODE_CATEGORY = 0x0011;
        /**
         * The unique identifier for terminal BLOCK_RULES
         */
        public static final int TERMINAL_BLOCK_RULES = 0x001D;
        /**
         * The unique identifier for terminal BLOCK_OPTIONS
         */
        public static final int TERMINAL_BLOCK_OPTIONS = 0x001B;
        /**
         * The unique identifier for terminal BLOCK_CONTEXT
         */
        public static final int TERMINAL_BLOCK_CONTEXT = 0x001E;
        /**
         * The unique identifier for terminal BLOCK_TERMINALS
         */
        public static final int TERMINAL_BLOCK_TERMINALS = 0x001C;
    }

    /**
     * Contains the constant IDs for the contexts for this lexer
     */
    public static class Context {
        /**
         * The unique identifier for the default context
         */
        public static final int DEFAULT = 0;
    }

    /**
     * The collection of terminals matched by this lexer
     * <p>
     * The terminals are in an order consistent with the automaton,
     * so that terminal indices in the automaton can be used to retrieve the terminals in this table
     */
    private static final Symbol[] terminals = {
            new Symbol(0x0001, "ε"),
            new Symbol(0x0002, "$"),
            new Symbol(0x0009, "NAME"),
            new Symbol(0x0008, "NAME_FIRST"),
            new Symbol(0x000D, "LITERAL_ANY"),
            new Symbol(0x0014, "OPERATOR_OPTIONAL"),
            new Symbol(0x0015, "OPERATOR_ZEROMORE"),
            new Symbol(0x0016, "OPERATOR_ONEMORE"),
            new Symbol(0x0017, "OPERATOR_UNION"),
            new Symbol(0x0018, "OPERATOR_DIFFERENCE"),
            new Symbol(0x0019, "TREE_ACTION_PROMOTE"),
            new Symbol(0x001A, "TREE_ACTION_DROP"),
            new Symbol(0x0042, "="),
            new Symbol(0x0043, ";"),
            new Symbol(0x0044, "("),
            new Symbol(0x0045, ")"),
            new Symbol(0x0047, "{"),
            new Symbol(0x0048, ","),
            new Symbol(0x0049, "}"),
            new Symbol(0x0051, "@"),
            new Symbol(0x0052, "<"),
            new Symbol(0x0054, ">"),
            new Symbol(0x0055, "#"),
            new Symbol(0x005D, ":"),
            new Symbol(0x0007, "SEPARATOR"),
            new Symbol(0x0003, "NEW_LINE"),
            new Symbol(0x0004, "WHITE_SPACE"),
            new Symbol(0x000A, "INTEGER"),
            new Symbol(0x000C, "LITERAL_STRING"),
            new Symbol(0x0013, "UNICODE_SPAN_MARKER"),
            new Symbol(0x004E, "->"),
            new Symbol(0x000B, "ESCAPEES"),
            new Symbol(0x0005, "COMMENT_LINE"),
            new Symbol(0x0012, "UNICODE_CODEPOINT"),
            new Symbol(0x000F, "LITERAL_CLASS"),
            new Symbol(0x000E, "LITERAL_TEXT"),
            new Symbol(0x0006, "COMMENT_BLOCK"),
            new Symbol(0x0010, "UNICODE_BLOCK"),
            new Symbol(0x0011, "UNICODE_CATEGORY"),
            new Symbol(0x001D, "BLOCK_RULES"),
            new Symbol(0x001B, "BLOCK_OPTIONS"),
            new Symbol(0x001E, "BLOCK_CONTEXT"),
            new Symbol(0x005F, "grammar"),
            new Symbol(0x004F, "fragment"),
            new Symbol(0x001C, "BLOCK_TERMINALS")};

    /**
     * Initializes a new instance of the lexer
     *
     * @param input The lexer's input
     */
    public HimeGrammarLexer(String input) {
        super(commonAutomaton, terminals, 0x0007, input);
    }

    /**
     * Initializes a new instance of the lexer
     *
     * @param input The lexer's input
     */
    public HimeGrammarLexer(InputStreamReader input) {
        super(commonAutomaton, terminals, 0x0007, input);
    }
}
