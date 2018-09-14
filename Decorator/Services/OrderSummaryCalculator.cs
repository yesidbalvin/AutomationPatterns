
namespace Decorator.Services
{
    public class OrderSummaryCalculator
    {
        public OrderSummaryCalculator()
        {
            ShippingCostsCalculationService = new ShippingCostsCalculationService();
        }

        public ShippingCostsCalculationService ShippingCostsCalculationService { get; set; }

        public decimal CalculateTotalPrice(decimal itemsPrice, decimal estimatedTax, Data.ClientPurchaseInfo clientPurchaseInfo)
        {
            var totalPrice = default(decimal);
            var shippingCosts = CalculateShippingPrice(clientPurchaseInfo);
            totalPrice = itemsPrice + estimatedTax + shippingCosts;

            return totalPrice;
        }

        public decimal CalculateBeforeTaxPrice(decimal itemsPrice, Data.ClientPurchaseInfo clientPurchaseInfo)
        {
            var beforeTaxPrice = default(decimal);
            var shippingCosts = CalculateShippingPrice(clientPurchaseInfo);
            beforeTaxPrice = itemsPrice + shippingCosts;

            return beforeTaxPrice;
        }

        public decimal CalculateShippingPrice(Data.ClientPurchaseInfo clientPurchaseInfo)
        {
            var shippingCosts = ShippingCostsCalculationService.Calculate(clientPurchaseInfo.ShippingInfo.Country, clientPurchaseInfo.ShippingInfo.State, clientPurchaseInfo.ShippingInfo.Address1, clientPurchaseInfo.ShippingInfo.Zip);
            return shippingCosts;
        }
    }
}