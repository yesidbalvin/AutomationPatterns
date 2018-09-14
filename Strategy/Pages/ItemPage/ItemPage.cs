
namespace Strategy.Pages.ItemPage
{
    public class ItemPage : Core.BasePageSingleton<ItemPage, ItemPageMap, ItemPageValidator>
    {
        public ItemPage()
        {
        }

        public void ClickBuyNowButton()
        {
            Map.AddToCartButton.Click();
        }

        public override void Navigate(string part)
        {
            ///Selenium-Testing-Cookbook-Gundecha-Unmesh/dp/1849515743
            base.Navigate(string.Concat(@"http://www.amazon.com/", part));
        }
    }
}