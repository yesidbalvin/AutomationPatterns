using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Singleton.Core;

namespace Singleton
{
    /// <summary>
    ///Ensure a class has only one instance and provide a global point of access to it.
    ///Instance control– prevents other objects from instantiating their own copies of the Singleton object, ensuring that all objects access the single instance.
    ///Flexibility– since the class controls the instantiation process, the class has the flexibility to change the instantiation process.
    ///Lazy initialization– defers the object’s creation until it is first used.
    /// </summary>
    [TestClass]
    public class Singleton_Test
    {
        [TestInitialize]
        public void SetupTest()
        {
            Driver.StartBrowser(Data.BrowserType.Chrome, 30);
        }

        [TestCleanup]
        public void TeardownTest()
        {
            Driver.StopBrowser();
        }
        [TestMethod]
        public void SearchText_No_Singleton_Test()
        {
            SearchEngineMainPage searchEngineMainPage = new SearchEngineMainPage(Driver.WebBrowser);
            searchEngineMainPage.Navigate();
            searchEngineMainPage.Search("Automate The Planet");
            Assert.IsTrue(searchEngineMainPage.GetResultsCount().Contains(".000 Resultados"));
            System.Threading.Thread.Sleep(3000);
        }

        [TestMethod]
        public void SearchText_Singleton_Test()
        {
            SearchEngineMainPage.Instance.Navigate();
            SearchEngineMainPage.Instance.Search("Automate The Planet");
            Assert.IsTrue(SearchEngineMainPage.Instance.GetResultsCount().Contains(".000 Resultados"));
            System.Threading.Thread.Sleep(3000);
        }

        [TestMethod]
        public void SearchText_Singleton_ThreadSafe_Test()
        {
            SearchEngineMainPage.SafeInstance.Navigate();
            SearchEngineMainPage.SafeInstance.Search("Automate The Planet");
            Assert.IsTrue(SearchEngineMainPage.SafeInstance.GetResultsCount().Contains(".000 Resultados"));
            System.Threading.Thread.Sleep(3000);
        }

    }
}
