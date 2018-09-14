

namespace Decorator.Pages.ShippingPaymentPage
{
    public class ShippingPaymentPage : Core.BasePageSingleton<ShippingPaymentPage, ShippingPaymentPageMap>
    {
        public void ClickBottomContinueButton()
        {
            Map.BottomContinueButton.Click();
        }

        public void ClickTopContinueButton()
        {
            Map.TopContinueButton.Click();
        }
    }
}