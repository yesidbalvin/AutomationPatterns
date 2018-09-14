
using Decorator.Pages.PlaceOrderPage;

namespace Decorator.Advanced.Strategies
{
    public class TotalPriceOrderPurchaseStrategy : OrderPurchaseStrategy
    {
        private readonly decimal _itemsPrice;

        public TotalPriceOrderPurchaseStrategy(decimal itemsPrice)
        {
            _itemsPrice = itemsPrice;
        }

        public override decimal CalculateTotalPrice()
        {
            return _itemsPrice;
        }

        public override void ValidateOrderSummary(decimal totalPrice)
        {
            PlaceOrderPage.Instance.Validate().OrderTotalPrice(totalPrice.ToString());
        }
    }
}