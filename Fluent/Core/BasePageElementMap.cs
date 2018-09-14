using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent.Core
{
   public class BasePageElementMap
    {
        protected IWebDriver Browser;
        protected WebDriverWait BrowserWait;

        public BasePageElementMap()
        {
            Browser = Driver.Browser;
            BrowserWait = Driver.BrowserWait;
        }
    }
}
