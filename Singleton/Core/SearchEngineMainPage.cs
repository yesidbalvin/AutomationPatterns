using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Core
{
    public class SearchEngineMainPage
    {
        private readonly IWebDriver _browser;
        private readonly string _url = @"http://www.bing.com/";

        public SearchEngineMainPage(IWebDriver browser)
        {
            _browser = browser;
        }

        #region Singleton Approach
        //Without Threadsafe
        private static SearchEngineMainPage _instance;
        public static SearchEngineMainPage Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SearchEngineMainPage(Driver.WebBrowser);
                return _instance;
            }
        }


        //With Thread Safe
        private static readonly object LockObject = new object();
        private static SearchEngineMainPage _safeInstance;
        public static SearchEngineMainPage SafeInstance
        {
            get
            {
                if (_safeInstance == null)
                {
                    lock (LockObject)
                    {
                        if (_safeInstance == null)
                        {
                            _safeInstance = new SearchEngineMainPage(Driver.WebBrowser);
                        }
                    }
                   
                }
                return _safeInstance;
            }
        }

        #endregion


        protected SearchEngineElementMap Map
        {
            get
            {
                return new SearchEngineElementMap(_browser);
            }
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
