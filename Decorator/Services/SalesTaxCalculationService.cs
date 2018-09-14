using Decorator.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Services
{
    public class SalesTaxCalculationService
    {
        public decimal Calculate(decimal price, States state, string zip)
        {
            var taxPrice = default(decimal);
            // Call Real Web Service to determine the Sales Tax.
            switch (state)
            {
                case States.Arizona:
                    taxPrice = CalculateTaxPriceInternal(price, 7.125, zip);
                    break;
                case States.Illinois:
                    taxPrice = CalculateTaxPriceInternal(price, 3.75, zip);
                    break;
                case States.Massachusetts:
                    taxPrice = CalculateTaxPriceInternal(price, 6.25, zip);
                    break;
                case States.California:
                    taxPrice = CalculateTaxPriceInternal(price, 2.50, zip);
                    break;
                case States.Washington:
                    taxPrice = CalculateTaxPriceInternal(price, 3.10, zip);
                    break;
                case States.NewJersey:
                    taxPrice = CalculateTaxPriceInternal(price, 7.00, zip);
                    break;
                case States.Texas:
                    taxPrice = CalculateTaxPriceInternal(price, 8.15, zip);
                    break;
                default:
                    taxPrice = CalculateTaxPriceInternal(price, 4.67, zip);
                    break;
            }

            return taxPrice;
        }

        private static decimal CalculateTaxPriceInternal(decimal price, double percent, string zip)
        {
            var taxPrice = price / (decimal)percent;
            return taxPrice;
        }
    }
}
