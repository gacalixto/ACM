using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderReposit
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);
           if(orderId==10)
            {
                order.OrderDate = new DateTimeOffset(2018,new TimeSpan(2,0,0));
            }
            return order;
        }

        public OrderDisplay RetrieveOrderDisplay(int orderId)
        {
            OrderDisplay orderDisplay = new OrderDisplay();

            orderDisplay.orderDisplayIttemList = new List<OrderDisplayItem>();

            return orderDisplay;
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;

        }

        public bool Save(Order order)
        {
            var success = true;
            if (order.HasChanges && order.IsValid)
            {
                if (order.IsNew)
                {

                }
                else
                {

                }
            }
            return success;

        }
    }
}
