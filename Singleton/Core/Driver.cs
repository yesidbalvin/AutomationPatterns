using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using Singleton.Data;
using System;

namespace Singleton.Core
{
    public static class Driver
    {
        public static IWebDriver WebBrowser { get; set; }
        public static WebDriverWait BrowserWait { get; set; }
            
        public static void StartBrowser(BrowserType browserType = BrowserType.Chrome, int defaultTimeOut = 30)
        {
            switch (browserType)
            {
                case BrowserType.Firefox:
                    WebBrowser = new FirefoxDriver();
                    break;
                case BrowserType.InternetExplorer:
                    break;
                case BrowserType.Chrome:
                    WebBrowser = new ChromeDriver();
                    break;
            }
            BrowserWait = new WebDriverWait(WebBrowser, TimeSpan.FromSeconds(defaultTimeOut));            
        }
        public static void StopBrowser()
        {
            WebBrowser.Quit();
        }
    }
}
