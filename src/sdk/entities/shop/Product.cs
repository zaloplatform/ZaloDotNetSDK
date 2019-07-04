using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.shop
{
    public class Product
    {
        private string id;
        private int industry;
        private string name;
        private string description;
        private string code;
        private long price;
        private int quantity;
        private List<string> categories;
        private List<string> photos;
        private ShopStatus status;
        private PackageSize packageSize;
        private List<Variation> variations;

        public Product(List<Variation> variations, PackageSize packageSize, ShopStatus status, List<string> photos, List<string> categories, int quantity, long price, string code, string description, string name, int industry, string id)
        {
            Variations = variations;
            PackageSize = packageSize;
            Status = status;
            Photos = photos;
            Categories = categories;
            Quantity = quantity;
            Price = price;
            Code = code;
            Description = description;
            Name = name;
            Industry = industry;
            Id = id;
        }

        public Product()
        {
        }

        public List<Variation> Variations { get => variations; set => variations = value; }
        public PackageSize PackageSize { get => packageSize; set => packageSize = value; }
        public ShopStatus Status { get => status; set => status = value; }
        public List<string> Photos { get => photos; set => photos = value; }
        public List<string> Categories { get => categories; set => categories = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public long Price { get => price; set => price = value; }
        public string Code { get => code; set => code = value; }
        public string Description { get => description; set => description = value; }
        public string Name { get => name; set => name = value; }
        public int Industry { get => industry; set => industry = value; }
        public string Id { get => id; set => id = value; }
    }
}
