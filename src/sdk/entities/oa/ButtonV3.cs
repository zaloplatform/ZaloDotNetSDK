using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class ButtonV3 : Button
    {
        private string image_icon;

        public ButtonV3(string title, string image_icon, string type) : base(title, type)
        {
            this.Image_icon = image_icon;
        }

        public string Image_icon { get => image_icon; set => image_icon = value; }
    }
}
