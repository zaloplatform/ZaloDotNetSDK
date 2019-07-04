namespace ZaloDotNetSDK.entities.shop
{
    public class ShopStatus
    {
        private string value;

        private ShopStatus(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static ShopStatus SHOW = new ShopStatus("show");
        public static ShopStatus HIDE = new ShopStatus("hide");
    }
}