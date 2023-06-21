using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenUrlButtonV3 : ButtonV3
    {
        private string url;

        public OpenUrlButtonV3(string title, string image_icon, string url) : base(title, image_icon, "oa.open.url")
        {
            this.Url = url;
        }

        public string Url { get => url; set => url = value; }
    }
}
