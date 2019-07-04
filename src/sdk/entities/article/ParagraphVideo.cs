using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class ParagraphVideo : Paragraph
    {
        private string url;
        private string videoId;
        private string thumb;

        public ParagraphVideo() : base("video")
        {
        }

        public ParagraphVideo(string url, string videoId, string thumb) : base("video")
        {
            this.url = url;
            this.videoId = videoId;
            this.thumb = thumb;
        }

        public string Url { get => url; set => url = value; }
        public string VideoId { get => videoId; set => videoId = value; }
        public string Thumb { get => thumb; set => thumb = value; }
    }
}
