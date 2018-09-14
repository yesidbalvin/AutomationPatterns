﻿

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Strategy.Pages.PlaceOrderPage
{
    public class PlaceOrderPageValidator : Core.BasePageValidator<PlaceOrderPageMap>
    {
        public void ItemsPrice(string expectedPrice)
        {
            Assert.AreEqual<string>(expectedPrice, Map.ItemsPrice.Text);
        }

        public void BeforeTaxesPrice(string expectedPrice)
        {
            Assert.AreEqual<string>(expectedPrice, Map.TotalBeforeTaxPrice.Text);
        }

        public void EstimatedTaxPrice(string expectedPrice)
        {
            Assert.AreEqual<string>("$4.67", Map.EstimatedTaxPrice.Text);
        }

        public void OrderTotalPrice(string expectedPrice)
        {
            Assert.AreEqual<string>(expectedPrice, Map.TotalPrice.Text);
        }

        public void GiftWrapPrice(string expectedPrice)
        {
            Assert.AreEqual<string>(expectedPrice, Map.GiftWrapPrice.Text);
        }

        public void ShippingTaxPrice(string expectedPrice)
        {
            Assert.AreEqual<string>(expectedPrice, Map.ShippingTax.Text);
        }
    }
}