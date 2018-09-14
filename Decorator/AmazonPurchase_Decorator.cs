using System;
using Decorator.Advanced.Base;
using Decorator.Core;
using Decorator.Data;
using Decorator.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decorator
{
    /*
     * So, We have a base user page. Then we add few components in the UI depends on the role. 
     * This is what exactly the decorator pattern is.
     * Decorator pattern allows us to add additional responsibilities to an object dynamically. 
     * If you need to add additional validators, you will have to add a couple of more classes to achieve the mixing behavior. 
     *          Here is where the Decorator Design Pattern comes to play
     */
    [TestClass]
    public class AmazonPurchase_Decorator
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser();
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }
        [TestMethod]
        public void Purchase_Decorator()
        {
            var itemUrl = "/Selenium-Testing-Cookbook-Gundecha-Unmesh/dp/1849515743";
            var itemPrice = 44.99m;
            var shippingInfo = new ClientAddressInfo()
            {
                FullName = "John Smith",
                Country = "United States",
                Address1 = "7518 CAROTHERS STREET",
                State = "Texas",
                City = "Houston",
                Zip = "77001",
                Phone = "00164644885569"
            };
            var billingInfo = new ClientAddressInfo()
            {
                FullName = "Anton Angelov",
                Country = "Bulgaria",
                Address1 = "950 Avenue of the Americas",
                City = "Sofia",
                Zip = "1672",
                Phone = "0894464647"
            };
            var clientPurchaseInfo = new ClientPurchaseInfo(billingInfo, shippingInfo)
            {
                GiftWrapping = GiftWrappingStyles.Fancy
            };
            var clientLoginInfo = new ClientLoginInfo()
            {
                Email = "ybalvins@psl.com.co",
                Password = "ASDFG_12345"
            };
            Advanced.Strategies.OrderPurchaseStrategy orderPurchaseStrategy = new Advanced.Strategies.TotalPriceOrderPurchaseStrategy(itemPrice);
            orderPurchaseStrategy = new Advanced.Strategies.SalesTaxOrderPurchaseStrategy(orderPurchaseStrategy, itemPrice, clientPurchaseInfo);
            orderPurchaseStrategy = new Advanced.Strategies.VatTaxOrderPurchaseStrategy(orderPurchaseStrategy, itemPrice, clientPurchaseInfo);

            new PurchaseContext(orderPurchaseStrategy).PurchaseItem(itemUrl, itemPrice.ToString(), clientLoginInfo, clientPurchaseInfo);
        }
    }
}
