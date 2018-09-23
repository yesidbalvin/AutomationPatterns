using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Rules
{
    public class CreditCardChargeRuleRuleResult: IRuleResult
    {
        public bool IsSuccess { get; set; }

        public void Execute()
        {
            Console.WriteLine("Assert that total amount label is over specified + additional UI actions");
        }
    }
}
