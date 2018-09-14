using Microsoft.VisualStudio.TestTools.UnitTesting;
using Observer.Attributes;
using Observer.Pages;

namespace Observer
{
    [TestClass]
    [ExecutionBrowser(BrowserTypes.Chrome)]
    public class BingTestsClassicObserver : BaseTest
    {
        [TestMethod]
        [ExecutionBrowser(BrowserTypes.Chrome)]
        public void SearchTextInBing_First_Observer()
        {
            var bingMainPage = new BingMainPage(Driver.Browser);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.Validate().ResultsCount("395.000");
        }
    }
}