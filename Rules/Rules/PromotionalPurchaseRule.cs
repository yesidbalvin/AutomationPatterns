using Rules.Data;
using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Rules
{
    public class PromotionalPurchaseRule : BaseRule
    {
        private readonly PurchaseTestInput _purchaseTestInput;

        public PromotionalPurchaseRule(PurchaseTestInput purchaseTestInput, Action actionToBeExecuted) : base(actionToBeExecuted)
        {
            _purchaseTestInput = purchaseTestInput;
        }

        public override IRuleResult Eval()
        {
            if (string.IsNullOrEmpty(_purchaseTestInput.CreditCardNumber) &&
                !_purchaseTestInput.IsWiretransfer &&
                _purchaseTestInput.IsPromotionalPurchase &&
                _purchaseTestInput.TotalPrice == 0)
            {
                RuleResult.IsSuccess = true;
                return RuleResult;
            }
            return new RuleResult();
        }
    }
}
