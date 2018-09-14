

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Decorator.Pages.ShippingAddressPage
{
    public class ShippingAddressPageMap : Core.BasePageElementMap
    {
        public SelectElement CountryDropDown
        {
            get
            {
                BrowserWait.Until<IWebElement>((d) => { return d.FindElement(By.Name("enterAddressCountryCode")); });
                return new SelectElement(Browser.FindElement(By.Name("enterAddressCountryCode")));
            }
        }

        public IWebElement FullNameInput
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressFullName"));
            }
        }

        public IWebElement Address1Input
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressAddressLine1"));
            }
        }

        public IWebElement CityInput
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressCity"));
            }
        }
        public IWebElement State
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressStateOrRegion"));
            }
        }
        public IWebElement ZipInput
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressPostalCode"));
            }
        }

        public IWebElement PhoneInput
        {
            get
            {
                return Browser.FindElement(By.Id("enterAddressPhoneNumber"));
            }
        }

        public SelectElement DeliveryPreferenceDropDown
        {
            get
            {
                return new SelectElement(Browser.FindElement(By.Name("AddressType")));
            }
        }

        public IWebElement ContinueButton
        {
            get
            {
                return BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.Id("continue-top")));
            }
        }
        public IWebElement SelectAddress
        {
            get
            {
                return Browser.FindElement(By.Id("addr_0"));
            }
        }
        public IWebElement UseSelectedAddress
        {
            get
            {
                return Browser.FindElement(By.Name("useSelectedAddress"));
            }
        }

        public IWebElement ShipToThisAddress
        {
            get
            {
                return Browser.FindElement(By.CssSelector("input.a-button-text"));
            }
        }

        public IWebElement DifferemtFromBillingCheckbox
        {
            get
            {
                return Browser.FindElement(By.Id("addr_1"));
            }
        }
    }
}