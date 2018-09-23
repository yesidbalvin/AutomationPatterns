using Rules.Data;
using Rules.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Rules
{
    public class CreditCardChargeRule : BaseRule
    {
        private readonly PurchaseTestInput _purchaseTestInput;
        private readonly decimal _totalPriceLowerBoundary;

        public CreditCardChargeRule(PurchaseTestInput purchaseTestInput, decimal totalPriceLowerBoundary, Action actionToBeExecuted) : base(actionToBeExecuted)
        {
            _purchaseTestInput = purchaseTestInput;
            _totalPriceLowerBoundary = totalPriceLowerBoundary;
        }

        public override IRuleResult Eval()
        {
            if (!string.IsNullOrEmpty(_purchaseTestInput.CreditCardNumber) &&
                !_purchaseTestInput.IsWiretransfer &&
                !_purchaseTestInput.IsPromotionalPurchase &&
                _purchaseTestInput.TotalPrice > _totalPriceLowerBoundary)
            {
                RuleResult.IsSuccess = true;
                return RuleResult;
            }
            return new RuleResult();
        }

    }
}
