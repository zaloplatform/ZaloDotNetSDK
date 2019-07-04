using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastPlatforms
    {
        private string value;

        private TargetBroadcastPlatforms(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastPlatforms IOS = new TargetBroadcastPlatforms("1");
        public static TargetBroadcastPlatforms ANDROID = new TargetBroadcastPlatforms("2");
        public static TargetBroadcastPlatforms WINDOW_PHONE = new TargetBroadcastPlatforms("3");
    }
}
