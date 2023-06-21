using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ElementV3TableItemStyle
    {
        private string value;

        private ElementV3TableItemStyle(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static ElementV3TableItemStyle GREEN = new ElementV3TableItemStyle("green");
        public static ElementV3TableItemStyle BLUE = new ElementV3TableItemStyle("blue");
        public static ElementV3TableItemStyle YELLOW = new ElementV3TableItemStyle("yellow");
        public static ElementV3TableItemStyle RED = new ElementV3TableItemStyle("red");
        public static ElementV3TableItemStyle GREY = new ElementV3TableItemStyle("grey");
        public static ElementV3TableItemStyle NONE = new ElementV3TableItemStyle("none");
    }
}
