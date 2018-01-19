using System.Collections.Generic;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = OrderItemId;
        }
        public int OrderItemId { get; private set; }
        public int OrderQuantity { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }

        public bool Save()
        {
            return true;

        }

        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity<=0) isValid = false;
            if (ProductId<=0) isValid = false;
            if (PurchasePrice == null) isValid = false;

            return isValid;
        }
    }
}