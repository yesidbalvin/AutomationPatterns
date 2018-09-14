
using Decorator.Pages.PlaceOrderPage;
using Decorator.Services;

namespace Decorator.Advanced.Strategies
{
    public class GiftOrderPurchaseStrategy : OrderPurchaseStrategyDecorator
    {
        private readonly GiftWrappingPriceCalculationService _giftWrappingPriceCalculationService;
        private decimal _giftWrapPrice;

        public GiftOrderPurchaseStrategy(OrderPurchaseStrategy orderPurchaseStrategy, decimal itemsPrice, Data.ClientPurchaseInfo clientPurchaseInfo) : base(orderPurchaseStrategy, itemsPrice, clientPurchaseInfo)
        {
            _giftWrappingPriceCalculationService = new GiftWrappingPriceCalculationService();
        }

        public override decimal CalculateTotalPrice()
        {
            _giftWrapPrice = _giftWrappingPriceCalculationService.Calculate(ClientPurchaseInfo.GiftWrapping);
            return OrderPurchaseStrategy.CalculateTotalPrice() + _giftWrapPrice;
        }

        public override void ValidateOrderSummary(decimal totalPrice)
        {
            OrderPurchaseStrategy.ValidateOrderSummary(totalPrice);
            PlaceOrderPage.Instance.Validate().GiftWrapPrice(_giftWrapPrice.ToString());
        }
    }
}