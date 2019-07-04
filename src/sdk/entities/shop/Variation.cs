using System.Collections.Generic;

namespace ZaloDotNetSDK.entities.shop
{
    public class Variation
    {
        private long price;
        private string name;
        private string code;
        private ShopStatus status;
        private int quantity;
        private List<string> attributes;
        private PackageSize packageSize;
        private int variationDefault;

        public Variation(int variationDefault, PackageSize packageSize, List<string> attributes, int quantity, ShopStatus status, string code, string name, long price)
        {
            VariationDefault = variationDefault;
            PackageSize = packageSize;
            Attributes = attributes;
            Quantity = quantity;
            Status = status;
            Code = code;
            Name = name;
            Price = price;
        }

        public Variation()
        {
        }

        public int VariationDefault { get => variationDefault; set => variationDefault = value; }
        public PackageSize PackageSize { get => packageSize; set => packageSize = value; }
        public List<string> Attributes { get => attributes; set => attributes = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public ShopStatus Status { get => status; set => status = value; }
        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public long Price { get => price; set => price = value; }
    }
}