using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenSMSElement:Element
    {
        private string content;
        private string phone_code;

        public OpenSMSElement(string title, string subtitle, string image_url, string content, string phone_code) : base(title, subtitle, image_url, "oa.open.sms")
        {
            this.Content = content;
            this.Phone_code = phone_code;
        }

        public string Content { get => content; set => content = value; }
        public string Phone_code { get => phone_code; set => phone_code = value; }
    }
}
