using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenPhoneElement:Element
    {
        private string phone_code;

        public OpenPhoneElement(string title, string subtitle, string image_url, string phone_code) : base(title, subtitle, image_url, "oa.open.phone")
        {
            this.Phone_code = phone_code;
        }

        public string Phone_code { get => phone_code; set => phone_code = value; }
    }
}
