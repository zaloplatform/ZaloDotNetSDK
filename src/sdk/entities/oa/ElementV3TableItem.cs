using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ElementV3TableItem
    {
        private string key;
        private string value;
        private ElementV3TableItemStyle style;

        public ElementV3TableItem(string key, string value, ElementV3TableItemStyle style)
        {
            Key = key;
            Value = value;
            Style = style;
        }

        public string Key { get => key; set => key = value; }
        public string Value { get => value; set => this.value = value; }
        public ElementV3TableItemStyle Style { get => style; set => this.style = value; }
    }
}
