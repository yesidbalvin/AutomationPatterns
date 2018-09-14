using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Core
{
    public class SearchEngineElementMap
    {
        private readonly IWebDriver _browser;

        public SearchEngineElementMap(IWebDriver browser)
        {
            _browser = browser;
        }

        public IWebElement SearchBox
        {
            get
            {
                return _browser.FindElement(By.Id("sb_form_q"));
            }
        }

        public IWebElement GoButton
        {
            get
            {
                return _browser.FindElement(By.Id("sb_form_go"));
            }
        }

        public IWebElement ResultsCountDiv
        {
            get
            {
                return _browser.FindElement(By.Id("b_tween"));
            }
        }
    }
}
