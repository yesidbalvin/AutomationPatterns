using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM_1_Approach.SecondApproach
{
    public class SearchEngineMainPage
    {
        private readonly IWebDriver _browser;
        private readonly string _url = @"http://www.bing.com/";

        public SearchEngineMainPage(IWebDriver browser)
        {
            _browser = browser;
        }

        protected SearchEngineElementMap Map
        {
            get
            {
                return new SearchEngineElementMap(_browser);
            }
        }

        public SearchEnginePageValidator Validate()
        {
            return new SearchEnginePageValidator(_browser);
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
        public string GetResultsCount()
        {
            return Map.ResultsCountDiv.Text;
        }
    }
}
