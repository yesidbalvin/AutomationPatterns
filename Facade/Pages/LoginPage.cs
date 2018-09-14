using Facade.ElementsMap;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Pages
{
    public class LoginPage
    {
        private readonly IWebDriver _browser;
        public LoginPage(IWebDriver browser)
        {
            _browser = browser;
        }

        public LoginElementMap Map
        {
            get
            {
                return new LoginElementMap(_browser);
            }
        }

        public void ContinueAsTempUser()
        {
            Map.TempUserButton.Click();
        }
    }
}
