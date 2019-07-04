using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class ParagraphText : Paragraph
    {
        private string content;

        public string Content { get => content; set => content = value; }

        public ParagraphText(string content) : base("text")
        {
            this.content = content;
        }

        public ParagraphText() : base("text")
        {
        }
    }
}
