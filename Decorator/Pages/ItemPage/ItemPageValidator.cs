

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Decorator.Pages.ItemPage
{
    public class ItemPageValidator : Core.BasePageValidator<ItemPageMap>
    {
        public void ProductTitle(string expectedTitle)
        {
            //Selenium Testing Tools Cookbook
            Assert.AreEqual<string>(expectedTitle, Map.ProductTitle.Text);
        }
    }
}