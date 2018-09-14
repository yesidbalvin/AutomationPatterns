using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ElementsMap
{
    public class ItemElementMap
    {
        private readonly IWebDriver _browser;

        public ItemElementMap(IWebDriver browser)
        {
            _browser = browser;
        }

            public IWebElement Price
            {
                get
                {
                    return _browser.FindElement(By.Id("prcIsum"));
                }
            }

        public IWebElement BuyNowButton
        {
            get
            {
                return _browser.FindElement(By.Id("binBtn_btn"));
            }
        }
    }
}
