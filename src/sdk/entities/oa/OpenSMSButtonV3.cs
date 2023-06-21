using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenSMSButtonV3 : ButtonV3
    {
        private string phone_code;
        private string content;

        public OpenSMSButtonV3(string title, string image_icon, string phone_code, string content) : base(title, image_icon, "oa.open.sms")
        {
            this.Phone_code = phone_code;
            this.Content = content;
        }

        public string Phone_code { get => phone_code; set => phone_code = value; }
        public string Content { get => content; set => content = value; }
    }
}
