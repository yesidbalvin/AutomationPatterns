using Rules.Data;
using Rules.Interfaces;

namespace Rules.Rules
{
    public class CreditCardChargeRule<TRuleResult> : BaseRule
        where TRuleResult : class, IRuleResult, new()
    {
        private readonly PurchaseTestInput _purchaseTestInput;
        private readonly decimal _totalPriceLowerBoundary;

        public CreditCardChargeRule(PurchaseTestInput purchaseTestInput, decimal totalPriceLowerBoundary)
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
            return new TRuleResult();
        }
    }
}
