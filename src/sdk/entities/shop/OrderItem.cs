using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.shop
{
    public class OrderItem
    {
        private string product_id;
        private int quantity;
        private string variation_id;
        private string partner_item_data;

        public OrderItem(string product_id, int quantity, string variation_id, string partner_item_data)
        {
            Product_id = product_id;
            Quantity = quantity;
            Variation_id = variation_id;
            Partner_item_data = partner_item_data;
        }

        public OrderItem()
        {
        }

        public string Product_id { get => product_id; set => product_id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Partner_item_data { get => partner_item_data; set => partner_item_data = value; }
        public string Variation_id { get => variation_id; set => variation_id = value; }
    }
}
