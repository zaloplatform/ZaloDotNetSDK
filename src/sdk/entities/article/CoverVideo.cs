using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class CoverVideo : Cover
    {
        private CoverViewVideoType coverView;
        private string videoId;

        public CoverVideo() : base("video")
        {
        }

        public CoverVideo(ArticleStatus status, CoverViewVideoType coverView, string videoId) : base("video")
        {
            this.coverView = coverView;
            this.videoId = videoId;
            this.Status = status;
        }



        public string VideoId { get => videoId; set => videoId = value; }
        public CoverViewVideoType CoverView { get => coverView; set => coverView = value; }
    }
}
