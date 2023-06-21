using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class BannerElementV3 : ElementV3
    {
        private string image_url;
        private string attachment_id;

        public BannerElementV3(string image_url, string attachment_id) : base("banner")
        {
            this.Image_url = image_url;
            this.Attachment_id = attachment_id;
        }

        public string Image_url { get => image_url; set => image_url = value; }

        public string Attachment_id { get => attachment_id; set => attachment_id = value; }
    }
}
