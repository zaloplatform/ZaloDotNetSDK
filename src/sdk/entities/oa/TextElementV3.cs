using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TextElementV3 : ElementV3
    {
        private string content;
        private ElementV3Align align;

        public TextElementV3(string content, ElementV3Align align) : base("text")
        {
            this.Content = content;
            this.Align = align;
        }

        public string Content { get => content; set => content = value; }

        public ElementV3Align Align { get => align; set => align = value; }
    }
}
