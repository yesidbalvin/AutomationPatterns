using Rules.Interfaces;
using Rules.Rules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules
{
    class RulesEvaluator
    {
        private readonly List<RulesChain> _rules;

        public RulesEvaluator()
        {
            _rules = new List<RulesChain>();
        }

        public RulesChain Eval(IRule rule)
        {
            var rulesChain = new RulesChain(rule);
            _rules.Add(rulesChain);
            return rulesChain;
        }

        public void OtherwiseEval(IRule alternativeRule)
        {
            if (_rules.Count == 0)
            {
                throw new ArgumentException("You cannot add ElseIf clause without If!");
            }
            _rules.Last().ElseRules.Add(new RulesChain(alternativeRule));
        }

        public void OtherwiseDo(Action otherwiseAction)
        {
            if (_rules.Count == 0)
            {
                throw new ArgumentException("You cannot add Else clause without If!");
            }
            _rules.Last().ElseRules.Add(new RulesChain(new NullRule(otherwiseAction), true));
        }

        public void EvaluateRulesChains()
        {
            Evaluate(_rules, false);
        }

        private void Evaluate(List<RulesChain> rulesToBeEvaluated, bool isAlternativeChain = false)
        {
            foreach (var currentRuleChain in rulesToBeEvaluated)
            {
                var currentRulesChainResult = currentRuleChain.Rule.Eval();
                if (currentRulesChainResult.IsSuccess)
                {
                    currentRulesChainResult.Execute();
                    if (isAlternativeChain)
                    {
                        break;
                    }
                }
                else
                {
                    Evaluate(currentRuleChain.ElseRules, true);
                }
            }
        }
    }
}
