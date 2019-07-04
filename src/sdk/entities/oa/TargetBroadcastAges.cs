using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastAges
    {
        private string value;

        private TargetBroadcastAges(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastAges FROM_0_TO_12 = new TargetBroadcastAges("0");
        public static TargetBroadcastAges FROM_13_TO_17 = new TargetBroadcastAges("1");
        public static TargetBroadcastAges FROM_18_TO_24 = new TargetBroadcastAges("2");
        public static TargetBroadcastAges FROM_25_TO_34 = new TargetBroadcastAges("3");
        public static TargetBroadcastAges FROM_35_TO_44 = new TargetBroadcastAges("4");
        public static TargetBroadcastAges FROM_45_TO_54 = new TargetBroadcastAges("5");
        public static TargetBroadcastAges FROM_55_TO_64 = new TargetBroadcastAges("6");
        public static TargetBroadcastAges GREATER_THAN_65 = new TargetBroadcastAges("7");
    }
}
