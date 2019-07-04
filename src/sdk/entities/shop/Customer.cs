using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.shop
{
    public class Customer
    {
        private string name;
        private string phone;
        private string user_id;
        private string address;
        private int dictrict;
        private int city;

        public Customer(string name, string phone, string user_id, string address, int dictrict, int city)
        {
            Name = name;
            Phone = phone;
            User_id = user_id;
            Address = address;
            Dictrict = dictrict;
            City = city;
        }

        public Customer()
        {
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string User_id { get => user_id; set => user_id = value; }
        public string Address { get => address; set => address = value; }
        public int Dictrict { get => dictrict; set => dictrict = value; }
        public int City { get => city; set => city = value; }
    }
}
