using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class ParagraphImage : Paragraph
    {
        private string url;
        private string caption;

        public ParagraphImage() : base("image")
        {
        }

        public ParagraphImage(string url, string caption) : base("image")
        {
            this.url = url;
            this.caption = caption;
        }

        public string Url { get => url; set => url = value; }
        public string Caption { get => caption; set => caption = value; }
    }
}
