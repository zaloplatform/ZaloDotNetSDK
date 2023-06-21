using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ElementV3Align
    {
        private string value;

        private ElementV3Align(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static ElementV3Align LEFT = new ElementV3Align("left");
        public static ElementV3Align CENTER = new ElementV3Align("center");
        public static ElementV3Align RIGHT = new ElementV3Align("right");
    }
}
