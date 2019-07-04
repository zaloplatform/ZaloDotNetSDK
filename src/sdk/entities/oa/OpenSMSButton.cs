using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenSMSButton:Button
    {
        private string phone_code;
        private string content;

        public OpenSMSButton(string title, string phone_code, string content) : base(title, "oa.open.sms")
        {
            this.Phone_code = phone_code;
            this.Content = content;
        }

        public string Phone_code { get => phone_code; set => phone_code = value; }
        public string Content { get => content; set => content = value; }
    }
}
