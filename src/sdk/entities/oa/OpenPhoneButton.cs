using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class OpenPhoneButton:Button
    {
        private string phone_code;

        public OpenPhoneButton(string title, string phone_code) : base(title, "oa.open.phone")
        {
            this.Phone_code = phone_code;
        }

        public string Phone_code { get => phone_code; set => phone_code = value; }
    }
}
