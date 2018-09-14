using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Core
{
    public static class Driver
    {
        public static IWebDriver WebBrowser { get; set; }
        public static WebDriverWait BrowserWait { get; set; }
            
        public static void StartBrowser()
        {
            WebBrowser = new ChromeDriver();
            BrowserWait = new WebDriverWait(WebBrowser, TimeSpan.FromSeconds(30));
        }
        public static void StopBrowser()
        {
            WebBrowser.Quit();
        }
    }
}
