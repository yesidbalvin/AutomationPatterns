
namespace Decorator.Advanced.Strategies
{
    public abstract class OrderPurchaseStrategy 
    {
        public abstract decimal CalculateTotalPrice();

        public abstract void ValidateOrderSummary(decimal totalPrice);
    }
}