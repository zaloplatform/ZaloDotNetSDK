using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryHideButton:Button
    {
        private string payload;

        public QueryHideButton(string title, string payload) : base(title, "oa.query.hide")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
