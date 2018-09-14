using Decorator.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Base
{
    public interface IOrderValidationStrategy
    {
        void ValidateOrderSummary(string itemPrice, ClientPurchaseInfo clientPurchaseInfo);
    }
}
