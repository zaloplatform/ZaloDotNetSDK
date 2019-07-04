namespace ZaloDotNetSDK.entities
{
    public class CoverViewVideoType
    {
        private string value;

        private CoverViewVideoType(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static CoverViewVideoType HORIZONTAL = new CoverViewVideoType("horizontal");
        public static CoverViewVideoType VERTICAL = new CoverViewVideoType("vertical");
        public static CoverViewVideoType SQUARE = new CoverViewVideoType("square");
    }
}