using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Rules
{
   public  class NullRule : BaseRule
    {
        public NullRule(System.Action actionToBeExecuted) : base(actionToBeExecuted)
        {
        }

        public override IRuleResult Eval()
        {
            RuleResult.IsSuccess = true;
            return RuleResult;
        }
    }
}
