using Strategy.Data;
using Strategy.Pages.ItemPage;
using Strategy.Pages.PreviewShoppingCartPage;
using Strategy.Pages.ShippingAddressPage;
using Strategy.Pages.ShippingPaymentPage;
using Strategy.Pages.SignInPage;

namespace Strategy.Base
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
            _orderValidationStrategy.ValidateOrderSummary(itemPrice, clientPurchaseInfo);
        }
    }
}
