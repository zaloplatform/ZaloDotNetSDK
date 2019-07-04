using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenUrlButton:Button
    {
        private string url;

        public OpenUrlButton(string title, string url) : base(title, "oa.open.url")
        {
            this.Url = url;
        }

        public string Url { get => url; set => url = value; }
    }
}
