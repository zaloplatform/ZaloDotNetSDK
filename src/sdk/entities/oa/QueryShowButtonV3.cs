using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryShowButtonV3 : ButtonV3
    {
        private string payload;

        public QueryShowButtonV3(string title, string image_icon, string payload) : base(title, image_icon, "oa.query.show")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
