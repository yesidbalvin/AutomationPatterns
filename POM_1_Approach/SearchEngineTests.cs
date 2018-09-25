using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using POM_1_Approach.FirstApproach;
using System;

namespace POM_1_Approach
{
    [TestClass]
    public class SearchEngineTests
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }
        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new ChromeDriver();
            this.Wait = new WebDriverWait(this.Driver, TimeSpan.FromSeconds(30));
        }
        [TestMethod]
        public void SearchTextInSearchEngine_First()
        {
            SearchEngineMainPage searchEngineMainPage = new SearchEngineMainPage(this.Driver);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Search("Automate The Planet");

            Assert.IsTrue(searchEngineMainPage.ResultsCountDiv.Text.Contains(".000 Resultados"));
        }
    }
}
