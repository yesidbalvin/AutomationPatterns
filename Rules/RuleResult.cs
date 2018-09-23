using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules
{
    public class RuleResult : IRuleResult
    {
        private readonly Delegate _actionToBeExecuted;

        public RuleResult(Delegate actionToBeExecuted)
        {
            _actionToBeExecuted = actionToBeExecuted;
        }

        public RuleResult()
        {
        }

        public bool IsSuccess { get; set; }

        public void Execute()
        {
            if (_actionToBeExecuted != null)
            {
                _actionToBeExecuted.DynamicInvoke();
            }
        }
    }
}
