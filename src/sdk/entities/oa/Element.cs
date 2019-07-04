using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class Element
    {
        private string title;
        private string subtitle;
        private string image_url;
        private string type;
        private List<Button> buttons;

        protected Element(string title, string subtitle, string image_url, string type)
        {
            Title = title;
            Subtitle = subtitle;
            Image_url = image_url;
            Type = type;
        }

        public string Title { get => title; set => title = value; }
        public string Subtitle { get => subtitle; set => subtitle = value; }
        public string Image_url { get => image_url; set => image_url = value; }
        public string Type { get => type; set => type = value; }
        public List<Button> Buttons { get => buttons; set => buttons = value; }
    }
}
