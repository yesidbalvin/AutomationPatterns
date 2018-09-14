

using Strategy.Data;

namespace Strategy.Pages.ShippingAddressPage
{
    public class ShippingAddressPage : Core.BasePageSingleton<ShippingAddressPage, ShippingAddressPageMap>
    {
        public void ClickContinueButton()
        {
            //Map.ContinueButton.Click();
            Map.SelectAddress.Click();
            Map.UseSelectedAddress.Click();
        }

        public void FillShippingInfo(ClientPurchaseInfo clientInfo)
        {
            FillAddressInfoInternal(clientInfo);
        }

        public void ClickDifferentBillingCheckBox(ClientPurchaseInfo clientInfo)
        {
            if (clientInfo.BillingInfo != null)
            {
                Map.DifferemtFromBillingCheckbox.Click();
            }
        }

        public void FillBillingInfo(ClientPurchaseInfo clientInfo)
        {
            if (clientInfo.BillingInfo != null)
            {
                FillAddressInfoInternal(clientInfo);
            }
        }

        private void FillAddressInfoInternal(ClientPurchaseInfo clientInfo)
        {
            Map.CountryDropDown.SelectByText(clientInfo.ShippingInfo.Country);
            Map.FullNameInput.SendKeys(clientInfo.ShippingInfo.FullName);
            Map.Address1Input.SendKeys(clientInfo.ShippingInfo.Address1);
            Map.CityInput.SendKeys(clientInfo.ShippingInfo.City);
            Map.State.SendKeys(clientInfo.ShippingInfo.State);
            Map.ZipInput.SendKeys(clientInfo.ShippingInfo.Zip);
            Map.PhoneInput.SendKeys(clientInfo.ShippingInfo.Phone);
            Map.ShipToThisAddress.Click();
        }
    }
}