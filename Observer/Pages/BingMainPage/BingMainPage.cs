using OpenQA.Selenium;

namespace Observer.Pages
{
    public class BingMainPage
    {
        private readonly IWebDriver _browser;
        private readonly string _url = @"http://www.bing.com/";

        public BingMainPage(IWebDriver browser)
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

        public BingMainPageValidator Validate()
        {
            return new BingMainPageValidator(_browser);
        }

        public void Navigate()
        {
            _browser.Navigate().GoToUrl(_url);
        }

        public void Search(string textToType)
        {
            Map.SearchBox.Clear();
            Map.SearchBox.SendKeys(textToType);
            Map.GoButton.Click();
        }
    }
}