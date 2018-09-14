
namespace Strategy.Data
{
    public class ClientPurchaseInfo
    {
        public ClientPurchaseInfo(ClientAddressInfo addressInfo)
        {
            BillingInfo = addressInfo;
            ShippingInfo = addressInfo;
        }

        public ClientPurchaseInfo(ClientAddressInfo billingInfo, ClientAddressInfo shippingInfo)
        {
            BillingInfo = billingInfo;
            ShippingInfo = shippingInfo;
        }

        public ClientAddressInfo BillingInfo { get; set; }

        public ClientAddressInfo ShippingInfo { get; set; }

        public string DeliveryType { get; set; }

        public GiftWrappingStyles GiftWrapping { get; set; }
    }
    public enum GiftWrappingStyles
    {
        Fancy,
        Cheap,
        UltraFancy,
        Paper,
        None
    }
}