namespace ZaloDotNetSDK.entities
{
    public class Paragraph
    {
        private string type;

        protected Paragraph(string type)
        {
            this.type = type;
        }

        public string Type { get => type; set => type = value; }
    }
}