using System;
using Decorator.Enums;
using Decorator.Pages.PlaceOrderPage;
using Decorator.Services;

namespace Decorator.Advanced.Strategies
{
    public class VatTaxOrderPurchaseStrategy : OrderPurchaseStrategyDecorator
    {
        private readonly VatTaxCalculationService _vatTaxCalculationService;
        private decimal _vatTax;     

        public VatTaxOrderPurchaseStrategy(OrderPurchaseStrategy orderPurchaseStrategy, decimal itemsPrice, Data.ClientPurchaseInfo clientPurchaseInfo) : base(orderPurchaseStrategy, itemsPrice, clientPurchaseInfo)
        {
            _vatTaxCalculationService = new VatTaxCalculationService();
        }

        public override decimal CalculateTotalPrice()
        {
            var currentCountry = (Countries)Enum.Parse(typeof(Countries), ClientPurchaseInfo.BillingInfo.Country);
            _vatTax = _vatTaxCalculationService.Calculate(ItemsPrice, currentCountry);
            return OrderPurchaseStrategy.CalculateTotalPrice() + _vatTax;
        }

        public override void ValidateOrderSummary(decimal totalPrice)
        {
            OrderPurchaseStrategy.ValidateOrderSummary(totalPrice);
            PlaceOrderPage.Instance.Validate().EstimatedTaxPrice(_vatTax.ToString());
        }
    }
}