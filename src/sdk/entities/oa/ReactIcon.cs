using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ReactIcon
    {
        private string value;

        private ReactIcon(string value)
        {
            this.value = value;
        }

        public string getValue()
        {
            return value;
        }

        public static ReactIcon HAHA = new ReactIcon(":>");
        public static ReactIcon WORRY = new ReactIcon("–-b");
        public static ReactIcon SAD = new ReactIcon(":-((");
        public static ReactIcon STRONG = new ReactIcon("/-strong");
        public static ReactIcon HEART = new ReactIcon("/-heart");
        public static ReactIcon ANGRY = new ReactIcon(":-h");
        public static ReactIcon TRANSACTION_EVENT = new ReactIcon(":o");
        public static ReactIcon SURPRISED = new ReactIcon("/-remove");

    }
}
