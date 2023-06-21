using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ElementV3
    {
        private string type;

        protected ElementV3(string type)
        {
            Type = type;
        }

        public string Type { get => type; set => type = value; }
    }
}
