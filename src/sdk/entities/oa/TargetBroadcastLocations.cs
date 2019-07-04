using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastLocations
    {
        private string value;

        private TargetBroadcastLocations(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastLocations NORTHERN_VIETNAM= new TargetBroadcastLocations("0");
        public static TargetBroadcastLocations CENTRAL_VIETNAM = new TargetBroadcastLocations("1");
        public static TargetBroadcastLocations SOUTHERN_VIETNAM = new TargetBroadcastLocations("2");
    }
}
