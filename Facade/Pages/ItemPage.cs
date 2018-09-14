using Facade.ElementsMap;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Pages
{
    public class ItemPage
    {
        private readonly IWebDriver _browser;
        private readonly string url = "https://www.ebay.com/itm/Casio-GPW-2000-1A2JF-G-Shock-Gravitymaster-Bluetooth-GPS-Watch-JP-GPW-2000-1A2/132234054374?epid=2226204759&hash=item1ec9c38ae6:g:bJEAAOSwbopZSelp";
        public ItemPage(IWebDriver browser)
        {
            _browser = browser;
        }

        public ItemElementMap Map
        {
            get
            {
                return new ItemElementMap(_browser);
            }
        }

        public void Navigate()
        {
            _browser.Navigate().GoToUrl(url);
        }
        public string Price()
        {
            return Map.Price.Text;
        }
        public void BuyNow()
        {
            Map.BuyNowButton.Click();
        }
    }
}
