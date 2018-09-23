using Rules.Interfaces;
using System;

namespace Rules.Rules
{
    public abstract class BaseRule : IRule
    {
        protected readonly RuleResult RuleResult;

        private readonly Action _actionToBeExecuted;

        public BaseRule(Action actionToBeExecuted)
        {
            _actionToBeExecuted = actionToBeExecuted;
            if (actionToBeExecuted != null)
            {
                RuleResult = new RuleResult(_actionToBeExecuted);
            }
            else
            {
                RuleResult = new RuleResult();
            }
        }

        public BaseRule()
        {
            RuleResult = new RuleResult();
        }

        public abstract IRuleResult Eval();
    }
}
