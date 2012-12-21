﻿/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 0.4.0.0
 */

using System.Collections.Generic;
using Hime.Redist.Parsers;
using Hime.Redist.Symbols;

namespace Hime.Demo.Generated
{
    internal class MathExpParser : LRkParser
    {
        private static readonly LRkAutomaton automaton = LRkAutomaton.FindAutomaton(typeof(MathExpParser), "MathExpParser.bin");
        private static readonly Variable[] variables = {
            new Variable(0x8, "exp_atom"), 
            new Variable(0x9, "exp_op0"), 
            new Variable(0xA, "exp_op1"), 
            new Variable(0xB, "exp"), 
            new Variable(0x12, "_Axiom_") };
        private static readonly Virtual[] virtuals = {
 };
        public interface Actions
        {
            void OnNumber(object head, object[] body, int length);
            void OnMult(object head, object[] body, int length);
            void OnDiv(object head, object[] body, int length);
            void OnPlus(object head, object[] body, int length);
            void OnMinus(object head, object[] body, int length);
        }
        private static SemanticAction[] BuildActions(Actions actions)
        {
            SemanticAction[] result = new SemanticAction[5];
            result[0] = new SemanticAction(actions.OnNumber);
            result[1] = new SemanticAction(actions.OnMult);
            result[2] = new SemanticAction(actions.OnDiv);
            result[3] = new SemanticAction(actions.OnPlus);
            result[4] = new SemanticAction(actions.OnMinus);
            return result;
        }
        public MathExpParser(MathExpLexer lexer, Actions actions) : base (automaton, variables, virtuals, BuildActions(actions), lexer) { }
    }
}