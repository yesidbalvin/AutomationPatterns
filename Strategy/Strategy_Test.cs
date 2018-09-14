using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy.Base;
using Strategy.Core;
using Strategy.Data;
using Strategy.Strategies;

namespace Strategy
{
    [TestClass]
    public class Strategy_Test
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
        public void TestMethod1()
        {
            var itemUrl = "/Selenium-Testing-Cookbook-Gundecha-Unmesh/dp/1849515743";
            var itemPrice = "44.99";
            var clientPurchaseInfo = new ClientPurchaseInfo(
            new ClientAddressInfo()
            {
                FullName = "John Smith",
                Country = "United States",
                Address1 = "950 Avenue of the Americas",
                State = "New York",
                City = "New York City",
                Zip = "10001-2121",
                Phone = "00164644885569"
            })
            {
                GiftWrapping = GiftWrappingStyles.None
            };
            var clientLoginInfo = new ClientLoginInfo()
            {
                Email = "ybalvins@psl.com.co",
                Password = "ASDFG_12345"
            };
            //new PurchaseContext(new SalesTaxOrderValidationStrategy()).PurchaseItem(itemUrl, itemPrice, clientLoginInfo, clientPurchaseInfo);
            var salesTaxStrategy = new PurchaseContext(new SalesTaxOrderValidationStrategy());
            salesTaxStrategy.PurchaseItem(itemUrl, itemPrice, clientLoginInfo, clientPurchaseInfo);

            Thread.Sleep(5000);
        }
    }
}
