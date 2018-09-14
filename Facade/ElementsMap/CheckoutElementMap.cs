using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.ElementsMap
{
    public class CheckoutElementMap
    {
        private readonly IWebDriver _browser;

        public CheckoutElementMap(IWebDriver browser)
        {
            _browser = browser;
        }
        public IWebElement FirstName
        {
            get
            {
                return _browser.FindElement(By.Id("af-first-name"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return _browser.FindElement(By.Id("af-last-name"));
            }
        }
        public IWebElement Country
        {
            get
            {
                return _browser.FindElement(By.Id("af-country"));
            }
        }
        public IWebElement Address1
        {
            get
            {
                return _browser.FindElement(By.Id("af-address1"));
            }
        }
        public IWebElement City
        {
            get
            {
                return _browser.FindElement(By.Id("af-city"));
            }
        }
        public IWebElement Phone
        {
            get
            {
                return _browser.FindElement(By.ClassName("ipt-phone"));
            }
        }
        public IWebElement Zip
        {
            get
            {
                return _browser.FindElement(By.Id("af-zip"));
            }
        }
        public IWebElement Email
        {
            get
            {
                return _browser.FindElement(By.Id("af-email"));
            }
        }
        public IWebElement ConfirmEmail
        {
            get
            {
                return _browser.FindElement(By.Id("af-email-confirm"));
            }
        }

        public IWebElement TotalPrice
        {
            get
            {
                return _browser.FindElement(By.XPath(String.Concat("//*[@id=", '"',"cart-total", '"', "]/table/tbody/tr[2]/td[2]/span")));
            }
        }
    }
}
