
using OpenQA.Selenium;

namespace Strategy.Pages.ItemPage
{
    public class ItemPageMap : Core.BasePageElementMap
    {
        public IWebElement AddToCartButton
        {
            get
            {
                return Browser.FindElement(By.Id("add-to-cart-button"));
            }
        }

        public IWebElement ProductTitle
        {
            get
            {
                return Browser.FindElement(By.Id("productTitle"));
            }
        }
    }
}