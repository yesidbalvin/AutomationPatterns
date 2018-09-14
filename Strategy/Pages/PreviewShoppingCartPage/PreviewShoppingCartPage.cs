
namespace Strategy.Pages.PreviewShoppingCartPage
{
    public class PreviewShoppingCartPage : Core.BasePageSingleton<PreviewShoppingCartPage, PreviewShoppingCartPageMap>
    {
        public void ClickProceedToCheckoutButton()
        {
            Map.ProceedToCheckoutButton.Click();
        }

        public void CheckOrderContainsGift()
        {
            Map.ThisOrderContainsGiftCheckbox.Click();
        }
    }
}