
using Decorator.Enums;

namespace Decorator.Services
{
    public class VatTaxCalculationService
    {
        public decimal Calculate(decimal price, Countries country)
        {
            var taxPrice = default(decimal);
            // Call Real Web Service to determine the VAT Tax.
            switch (country)
            {
                case Countries.Bulgaria:
                    taxPrice = CalculateTaxPriceInternal(price, 6.25);
                    break;
                case Countries.Germany:
                    taxPrice = CalculateTaxPriceInternal(price, 19);
                    break;
                case Countries.Austria:
                    taxPrice = CalculateTaxPriceInternal(price, 20);
                    break;
                case Countries.France:
                    taxPrice = CalculateTaxPriceInternal(price, 23);
                    break;
                default:
                    taxPrice = 0;
                    break;
            }

            return taxPrice;
        }

        private static decimal CalculateTaxPriceInternal(decimal price, double percent)
        {
            var taxPrice = price / (decimal)percent;
            return taxPrice;
        }
    }
}