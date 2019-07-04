using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TargetBroadcastGender
    {
        private string value;

        private TargetBroadcastGender(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static TargetBroadcastGender ALL = new TargetBroadcastGender("0");
        public static TargetBroadcastGender MALE = new TargetBroadcastGender("1");
        public static TargetBroadcastGender FEMALE = new TargetBroadcastGender("2");
    }
}
