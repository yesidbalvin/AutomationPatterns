

using OpenQA.Selenium;

namespace Strategy.Pages.PreviewShoppingCartPage
{
    public class PreviewShoppingCartPageMap : Core.BasePageElementMap
    {
        public IWebElement ProceedToCheckoutButton
        {
            get
            {
                return Browser.FindElement(By.Id("hlb-ptc-btn-native"));
            }
        }

        public IWebElement EditYourCartButton
        {
            get
            {
                return Browser.FindElement(By.Id("a-autoid-0-announce"));
            }
        }

        public IWebElement ThisOrderContainsGiftCheckbox
        {
            get
            {
                return Browser.FindElement(By.Id("sc-buy-box-gift-checkbox"));
            }
        }
    }
}