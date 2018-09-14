using Strategy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Base
{
    public interface IOrderValidationStrategy
    {
        void ValidateOrderSummary(string itemPrice, ClientPurchaseInfo clientPurchaseInfo);
    }
}
