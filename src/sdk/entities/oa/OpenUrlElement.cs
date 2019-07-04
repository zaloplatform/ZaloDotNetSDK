using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenUrlElement : Element
    {
        private string url;

        public OpenUrlElement(string title, string subtitle, string image_url, string url) : base(title, subtitle, image_url, "oa.open.url")
        {
            this.Url = url;
        }

        public string Url { get => url; set => url = value; }
    }
}
