
using Decorator.Pages.ItemPage;
using Decorator.Pages.PreviewShoppingCartPage;
using Decorator.Pages.ShippingAddressPage;
using Decorator.Pages.ShippingPaymentPage;
using Decorator.Pages.SignInPage;

namespace Decorator.Advanced.Base
{
    public class PurchaseContext
    {
        private readonly Strategies.OrderPurchaseStrategy _orderPurchaseStrategy;

        public PurchaseContext(Strategies.OrderPurchaseStrategy orderPurchaseStrategy)
        {
            _orderPurchaseStrategy = orderPurchaseStrategy;
        }

        public void PurchaseItem(string itemUrl, string itemPrice, Data.ClientLoginInfo clientLoginInfo, Data.ClientPurchaseInfo clientPurchaseInfo)
        {
            ItemPage.Instance.Navigate(itemUrl);
            ItemPage.Instance.ClickBuyNowButton();
            PreviewShoppingCartPage.Instance.ClickProceedToCheckoutButton();
            SignInPage.Instance.Login(clientLoginInfo.Email, clientLoginInfo.Password);
            ShippingAddressPage.Instance.FillShippingInfo(clientPurchaseInfo);
            ShippingAddressPage.Instance.ClickContinueButton();
            ShippingPaymentPage.Instance.ClickBottomContinueButton();
            ShippingAddressPage.Instance.StandardContinueButton();
            var expectedTotalPrice = _orderPurchaseStrategy.CalculateTotalPrice();
            _orderPurchaseStrategy.ValidateOrderSummary(expectedTotalPrice);
        }
    }
}