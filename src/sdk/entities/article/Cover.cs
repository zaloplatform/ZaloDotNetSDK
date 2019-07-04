namespace ZaloDotNetSDK.entities
{
    public class Cover
    {
        private string coverType;
        private ArticleStatus status;

        protected Cover(string coverType)
        {
            this.coverType = coverType;
        }

        public string CoverType { get => coverType; set => coverType = value; }
        public ArticleStatus Status { get => status; set => status = value; }
    }
}