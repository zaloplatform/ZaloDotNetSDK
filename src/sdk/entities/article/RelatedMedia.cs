namespace ZaloDotNetSDK.entities
{
    public class RelatedMedia
    {
        private string id;

        public RelatedMedia(string id)
        {
            this.id = id;
        }

        public string Id { get => id; set => id = value; }
    }
}