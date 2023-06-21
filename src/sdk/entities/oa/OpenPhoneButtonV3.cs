using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenPhoneButtonV3 : ButtonV3
    {
        private string phone_code;

        public OpenPhoneButtonV3(string title, string image_icon, string phone_code) : base(title, image_icon, "oa.open.phone")
        {
            this.Phone_code = phone_code;
        }

        public string Phone_code { get => phone_code; set => phone_code = value; }
    }
}
