using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Observer.Pages
{
    public class BingMainPageValidator
    {
        private readonly IWebDriver _browser;

        public BingMainPageValidator(IWebDriver browser)
        {
            _browser = browser;
        }

        protected BingMainPageElementMap Map
        {
            get
            {
                return new BingMainPageElementMap(_browser);
            }
        }

        public void ResultsCount(string expectedCount)
        {
            Assert.IsTrue(Map.ResultsCountDiv.Text.Contains(expectedCount), "The results DIV doesn't contains the specified text.");
        }
    }
}