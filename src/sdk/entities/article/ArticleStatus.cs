namespace ZaloDotNetSDK.entities
{
    public class ArticleStatus
    {
        private string value;

        private ArticleStatus(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static ArticleStatus SHOW = new ArticleStatus("show");
        public static ArticleStatus HIDE = new ArticleStatus("hide");
    }

}