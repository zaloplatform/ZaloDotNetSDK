using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastTelcos
    {
        private string value;

        private TargetBroadcastTelcos(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastTelcos MOBIPHONE = new TargetBroadcastTelcos("1");
        public static TargetBroadcastTelcos VINAPHONE = new TargetBroadcastTelcos("2");
        public static TargetBroadcastTelcos VIETTEL = new TargetBroadcastTelcos("3");
        public static TargetBroadcastTelcos VIETNAM_MOBILE = new TargetBroadcastTelcos("4");
    }
}
