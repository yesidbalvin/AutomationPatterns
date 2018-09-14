using Facade.Data;
using Facade.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Facades
{
    /// <summary>
    /// Access to ItemPage
    /// CheckoutPage
    /// ShippingAddressPage
    /// SignInPage
    /// </summary>
    public class PurchaseFacade
    {
        private ItemPage _itemPage;
        private CheckoutPage _checkoutPage;
        //private ShippingAddressPage _shippingAddressPage;
        private LoginPage _loginInPage;

        private readonly IWebDriver _browser;

        public PurchaseFacade(IWebDriver browser)
        {
            _browser = browser;
        }
        #region Pages
        
        public ItemPage ItemPage
        {
            get
            {
                if (_itemPage == null)
                {
                    _itemPage = new ItemPage(this._browser);
                }
                return _itemPage;
            }
        }

        public LoginPage LoginPage
        {
            get
            {
                if (_loginInPage == null)
                {
                    _loginInPage = new LoginPage(this._browser);
                }
                return _loginInPage;
            }
        }

        public CheckoutPage CheckoutPage
        {
            get
            {
                if (_checkoutPage == null)
                {
                    _checkoutPage = new CheckoutPage(this._browser);
                }
                return _checkoutPage;
            }
        }

        //public ShippingAddressPage ShippingAddressPage
        //{
        //    get
        //    {
        //        if (_shippingAddressPage == null)
        //        {
        //            _shippingAddressPage = new ShippingAddressPage();
        //        }
        //        return _shippingAddressPage;
        //    }
        //}
        #endregion

        #region ItemPage

        public void SearchItem()
        {
            ItemPage.Navigate();

        }
        public string GetPrice()
        {
            return ItemPage.Price();
        }
        public void BuyNow()
        {
            ItemPage.BuyNow();
        }
        #endregion

        #region LoginPage
        public void ContinueAsTempUser()
        {
            LoginPage.ContinueAsTempUser();
        }
        #endregion

        #region CheckoutPage
        public void SetClientInfo(ClientInfo clientInfo)
        {
            CheckoutPage.SetClientInfo(clientInfo);
        }
        public string GetTotalPrice()
        {
            return CheckoutPage.GetTotalPrice();
        }
        #endregion
    }
}
