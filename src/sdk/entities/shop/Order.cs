using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.shop
{
    public class Order
    {
        private Customer customer;
        private List<OrderItem> order_items;
        private string extra_note;

        public Order(Customer customer, string extra_note, List<OrderItem> order_items)
        {
            Customer = customer;
            Extra_note = extra_note;
            Order_items = order_items;
        }

        public Order()
        {
        }

        public Customer Customer { get => customer; set => customer = value; }
        public string Extra_note { get => extra_note; set => extra_note = value; }
        public List<OrderItem> Order_items { get => order_items; set => order_items = value; }
    }
}
