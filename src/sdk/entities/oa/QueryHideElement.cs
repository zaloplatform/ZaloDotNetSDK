using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryHideElement : Element
    {
        private string payload;

        public QueryHideElement(string title, string subtitle, string image_url, string payload) : base(title, subtitle, image_url, "oa.query.hide")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
