using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ElementsMap
{
    public class LoginElementMap
    {
        private readonly IWebDriver _browser;

        public LoginElementMap(IWebDriver browser)
        {
            _browser = browser;
        }
        public IWebElement TempUserButton
        {
            get
            {
                return _browser.FindElement(By.Id("sbin-gxo-btn"));
            }
        }
    }
}
