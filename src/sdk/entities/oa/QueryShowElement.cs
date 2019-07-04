using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryShowElement : Element
    {
        private string payload;

        public QueryShowElement(string title, string subtitle, string image_url, string payload) : base(title, subtitle, image_url, "oa.query.show")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
