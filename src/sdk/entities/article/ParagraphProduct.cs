using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class ParagraphProduct : Paragraph
    {
        private string id;

        public string Id { get => id; set => id = value; }

        public ParagraphProduct(string id) : base("product")
        {
            this.id = id;
        }

        public ParagraphProduct() : base("product")
        {
        }
    }
}
