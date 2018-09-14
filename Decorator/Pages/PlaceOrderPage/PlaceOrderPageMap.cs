

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Decorator.Pages.PlaceOrderPage
{
    public class PlaceOrderPageMap : Core.BasePageElementMap
    {
        public IWebElement TotalPrice
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[7]/td[2]/strong"));
            }
        }

        public IWebElement EstimatedTaxPrice
        {
            get
            {
                return BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[5]/td[2]")));
                //return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[5]/td[2]"));
            }
        }

        public IWebElement ItemsPrice
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[1]/td[2]"));
            }
        }

        public IWebElement TotalBeforeTaxPrice
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[4]/td[2]"));
            }
        }

        public IWebElement GiftWrapPrice
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[2]/td[2]"));
            }
        }

        public IWebElement ShippingTax
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='subtotals-marketplace-table']/table/tbody/tr[2]/td[2]"));
            }
        }
    }
}