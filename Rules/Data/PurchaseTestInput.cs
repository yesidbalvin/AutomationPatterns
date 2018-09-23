using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.Data
{
    public class PurchaseTestInput
    {
        public bool IsWiretransfer { get; set; }

        public bool IsPromotionalPurchase { get; set; }

        public string CreditCardNumber { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
