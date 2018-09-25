using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using POM_1_Approach.SecondApproach;
using System;

namespace POM_1_Approach
{
    [TestClass]
    public class SearchEngineTest_SA
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
        public void SearchTextInSearchEngine_Second()
        {
            SearchEngineMainPage searchEngineMainPage = new SearchEngineMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Search("Automate The Planet");
            Assert.IsTrue(searchEngineMainPage.GetResultsCount().Contains(".000 Resultados"));
            System.Threading.Thread.Sleep(3000);
        }
    }
}
