﻿using System;
using System.Collections.Generic;

namespace ACM.BL
{
   public  class Order : EntityBase
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;

        }

        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public List<OrderItem> orderItems { get; set; }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public List<Order> Retrieve()
        {
            return new List<Order>();
        }

        public bool Save()
        {
            return true;

        }

        public override bool Validate()
        {
            var isValid = true;
            if (OrderDate==null) isValid = false;
            

            return isValid;
        }

        public override string ToString()
        {
            return OrderDate + "(" + OrderId + ")";
        }
    }
}