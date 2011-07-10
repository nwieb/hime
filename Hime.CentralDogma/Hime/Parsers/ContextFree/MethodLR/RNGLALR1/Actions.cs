﻿using System.Collections.Generic;

namespace Hime.Parsers.CF.LR
{
    class StateReductionsRNGLALR1 : StateReductions
    {
        public override TerminalSet ExpectedTerminals
        {
            get
            {
                TerminalSet Set = new TerminalSet();
                foreach (StateActionRNReduce Reduction in this)
                    Set.Add(Reduction.Lookahead);
                return Set;
            }
        }

        public StateReductionsRNGLALR1() : base() { }

        public override void Build(State Set)
        {
            // Build shift actions
            foreach (Symbol Next in Set.Children.Keys)
            {
                List<StateAction> Actions = new List<StateAction>();
                Actions.Add(new StateActionShift(Next, Set.Children[Next]));
            }

            // Redutions dictionnary for the given set
            Dictionary<Terminal, ItemLALR1> Reductions = new Dictionary<Terminal, ItemLALR1>();
            // Construct reductions
            foreach (ItemLALR1 Item in Set.Items)
            {
                // Check for right nulled reduction
                if (Item.Action == ItemAction.Shift && !Item.BaseRule.Definition.GetChoiceAtIndex(Item.DotPosition).Firsts.Contains(TerminalEpsilon.Instance))
                    continue;
                bool rightnulled = (Item.DotPosition != Item.BaseRule.Definition.GetChoiceAtIndex(0).Length);
                foreach (Terminal Lookahead in Item.Lookaheads)
                {
                    // There is already a shift action for the lookahead => conflict
                    if (Set.Children.ContainsKey(Lookahead))
                    {
                        StateReductionsLR1.HandleConflict_ShiftReduce("RNGLALR(1)", conflicts, Item, Set, Lookahead);
                        StateActionRNReduce Reduction = new StateActionRNReduce(Lookahead, Item.BaseRule, Item.DotPosition);
                        this.Add(Reduction);
                    }
                    // There is already a reduction action for the lookahead => conflict
                    else if (Reductions.ContainsKey(Lookahead))
                    {
                        StateReductionsLR1.HandleConflict_ReduceReduce("RNGLALR(1)", conflicts, Item, Reductions[Lookahead], Set, Lookahead);
                        StateActionRNReduce Reduction = new StateActionRNReduce(Lookahead, Item.BaseRule, Item.DotPosition);
                        this.Add(Reduction);
                    }
                    else // No conflict
                    {
                        // hide conflicts generated by reducing using right-nulled rules
                        if (!rightnulled)
                            Reductions.Add(Lookahead, Item);
                        StateActionRNReduce Reduction = new StateActionRNReduce(Lookahead, Item.BaseRule, Item.DotPosition);
                        this.Add(Reduction);
                    }
                }
            }
        }
    }
}
