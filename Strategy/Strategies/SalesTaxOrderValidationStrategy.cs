using Strategy.Base;
using Strategy.Data;
using Strategy.Pages.PlaceOrderPage;
using Strategy.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    public class SalesTaxOrderValidationStrategy : IOrderValidationStrategy
    {
        public SalesTaxOrderValidationStrategy()
        {
            SalesTaxCalculationService = new SalesTaxCalculationService();
        }

        public SalesTaxCalculationService SalesTaxCalculationService { get; set; }

        public void ValidateOrderSummary(string itemsPrice, ClientPurchaseInfo clientPurchaseInfo)
        {
            var currentState = (States)Enum.Parse(typeof(States), clientPurchaseInfo.ShippingInfo.State.Replace(" ",String.Empty));
            var currentItemPrice = decimal.Parse(itemsPrice);
            var salesTax = SalesTaxCalculationService.Calculate(currentItemPrice, currentState, clientPurchaseInfo.ShippingInfo.Zip);

            PlaceOrderPage.Instance.Validate().EstimatedTaxPrice(salesTax.ToString());
        }
    }
}
