using Decorator.Data;
using Decorator.Pages.ItemPage;
using Decorator.Pages.PreviewShoppingCartPage;
using Decorator.Pages.ShippingAddressPage;
using Decorator.Pages.ShippingPaymentPage;
using Decorator.Pages.SignInPage;

namespace Decorator.Base
{
    public class PurchaseContext
    {
        private readonly IOrderValidationStrategy _orderValidationStrategy;

        public PurchaseContext(IOrderValidationStrategy orderValidationStrategy)
        {
            _orderValidationStrategy = orderValidationStrategy;
        }

        public void PurchaseItem(string itemUrl, string itemPrice, ClientLoginInfo clientLoginInfo, ClientPurchaseInfo clientPurchaseInfo)
        {
            ItemPage.Instance.Navigate(itemUrl);
            ItemPage.Instance.ClickBuyNowButton();
            PreviewShoppingCartPage.Instance.ClickProceedToCheckoutButton();
            SignInPage.Instance.Login(clientLoginInfo.Email, clientLoginInfo.Password);
            ShippingAddressPage.Instance.FillShippingInfo(clientPurchaseInfo);
            ShippingAddressPage.Instance.ClickContinueButton();
            ShippingPaymentPage.Instance.ClickBottomContinueButton();
            ShippingPaymentPage.Instance.ClickTopContinueButton();
        }
    }
}
