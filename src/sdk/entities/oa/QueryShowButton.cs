using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class QueryShowButton:Button
    {
        private string payload;

        public QueryShowButton(string title, string payload) : base(title, "oa.query.show")
        {
            this.Payload = payload;
        }

        public string Payload { get => payload; set => payload = value; }
    }
}
