using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryHideButtonV3 : ButtonV3
    {
        private string payload;

        public QueryHideButtonV3(string title, string image_icon, string payload) : base(title, image_icon, "oa.query.hide")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
