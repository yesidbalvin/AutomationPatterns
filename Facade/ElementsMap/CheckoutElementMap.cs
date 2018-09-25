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
                return _browser.FindElement(By.Id("firstName"));
            }
        }

        public IWebElement LastName
        {
            get
            {
                return _browser.FindElement(By.Id("lastName"));
            }
        }
        public IWebElement Country
        {
            get
            {
                return _browser.FindElement(By.Id("country"));
            }
        }
        public IWebElement Address1
        {
            get
            {
                return _browser.FindElement(By.Id("addressLine1"));
            }
        }
        public IWebElement City
        {
            get
            {
                return _browser.FindElement(By.Id("city"));
            }
        }
        public IWebElement Phone
        {
            get
            {
                return _browser.FindElement(By.Id("phoneNumber"));
            }
        }
        public IWebElement Zip
        {
            get
            {
                return _browser.FindElement(By.Id("postalCode"));
            }
        }
        public IWebElement Email
        {
            get
            {
                return _browser.FindElement(By.Id("email"));
            }
        }
        public IWebElement ConfirmEmail
        {
            get
            {
                return _browser.FindElement(By.Id("emailConfirm"));
            }
        }

        public IWebElement TotalPrice
        {
            get
            {
                //*[@id="mainContent"]/div/div/div/div[2]/div[3]/section/div[1]/div/table/tbody/tr[3]/td[2]/span
                return _browser.FindElement(By.XPath(String.Concat("//*[@id=", '"', "mainContent", '"', "]/div/div/div/div[2]/div[3]/section/div[1]/div/table/tbody/tr[3]/td[2]/span")));
            }
        }
    }
}
