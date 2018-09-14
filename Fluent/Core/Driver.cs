using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Fluent
{
    public static class Driver
    {
        private static WebDriverWait _browserWait;
        private static IWebDriver _browser;
        public static IWebDriver Browser
        {
            get
            {
                if (_browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method Start.");

                }
                return _browser;
            }
            private set
            {
                _browser = value;
            }
        }
        public static WebDriverWait BrowserWait
        {
            get
            {
                if (_browserWait == null || _browser == null)
                {
                    throw new NullReferenceException("The WebDriver browser wait instance was not initialized. You should first call the method Start.");
                }
                return _browserWait;
            }
            private set
            {
                _browserWait = value;
            }

        }
        public static void StartBrowser(int defaultTimeOut = 20)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            BrowserWait = new WebDriverWait(Browser, TimeSpan.FromSeconds(defaultTimeOut));

        }
        public static void StopBrowser()
        {
            Browser.Quit();
            Browser = null;
            BrowserWait = null;
        }
    }
}
