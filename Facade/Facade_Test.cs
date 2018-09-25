using System;
using Facade.Data;
using Facade.Facades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Facade
{
    /// <summary>
    /// An object that provides a simplified interface to a larger body of code, such as class library.
    ///Make a software library easier to use, understand and more readable.
    ///Reduce dependencies of outside code.
    ///Keeps the Principle of least knowledge.
    ///Wrap a poorly designed APIs in a better one.
    /// </summary>
    [TestClass]
    public class Facade_Test
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void PurchaseTest()
        {
            PurchaseFacade purchaseFacade = new PurchaseFacade(this.Driver);

            var itemPrice = "US $719.00";
            var itemPriceWithDelivery = "US $739.00";
            var clientInfo = new ClientInfo()
            {
                FirstName ="Pepito",
                LastName = "Perez",
                Address1 ="Fake Street 123",
                City ="Miami",
                Country = "United States",
                Email ="pepito@mail.com",
                Phone = "123456789",
                Zip= "123456"
            };

            purchaseFacade.SearchItem();
            var currentPrice =  purchaseFacade.GetPrice();
            Assert.AreEqual(itemPrice, currentPrice);
            purchaseFacade.BuyNow();

            purchaseFacade.ContinueAsTempUser();
            purchaseFacade.SetClientInfo(clientInfo);

            var totalPrice = purchaseFacade.GetTotalPrice();
            Assert.AreEqual(itemPriceWithDelivery, totalPrice);
        }
    }
}
