using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class Button
    {
        private string title;
        private string type;

        public Button(string title, string type)
        {
            Title = title;
            Type = type;
        }

        public string Title { get => title; set => title = value; }
        public string Type { get => type; set => type = value; }
    }
}
