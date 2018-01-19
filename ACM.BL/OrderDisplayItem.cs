using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    class OrderDisplayItem
    {
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal ? PurchasePrica { get; set; }
    }
}
