

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Strategy.Pages.ShippingPaymentPage
{
    public class ShippingPaymentPageMap : Core.BasePageElementMap
    {
        public IWebElement BottomContinueButton
        {
            get
            {
                return Browser.FindElement(By.XPath("//*[@id='shippingOptionFormId']/div[3]/div/div/span[1]/span/input"));
                //return Browser.FindElement(By.Id("continue-top"));
            }
        }

        public IWebElement TopContinueButton
        {
            get
            {
                return  BrowserWait.Until(ExpectedConditions.ElementIsVisible(By.Id("continue-top")));
            }
        }
    }
}