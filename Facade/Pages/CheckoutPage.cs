using Facade.Data;
using Facade.ElementsMap;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Pages
{
    public class CheckoutPage
    {
        private readonly IWebDriver _browser;
        public CheckoutPage(IWebDriver browser)
        {
            _browser = browser;
        }

        public CheckoutElementMap Map
        {
            get
            {
                return new CheckoutElementMap(_browser);
            }
        }

        public void SetClientInfo(ClientInfo clientInfo)
        {
            Map.Country.SendKeys(clientInfo.Country);
            Map.FirstName.SendKeys(clientInfo.FirstName);
            Map.LastName.SendKeys(clientInfo.LastName);
            Map.Phone.SendKeys(clientInfo.Phone);
            Map.Zip.SendKeys(clientInfo.Zip);
            Map.Address1.SendKeys(clientInfo.Address1);
            Map.City.SendKeys(clientInfo.City);
            Map.Email.SendKeys(clientInfo.Email);
            Map.ConfirmEmail.SendKeys(clientInfo.Email);
        }
        public string GetTotalPrice()
        {
            return Map.TotalPrice.Text;
        }
    }
}
