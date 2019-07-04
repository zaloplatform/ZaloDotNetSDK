using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class CoverPhoto : Cover
    {
        private string photoUrl;

        public CoverPhoto() : base("photo")
        {
        }

        public CoverPhoto(string photoUrl, ArticleStatus status) : base("photo")
        {
            this.photoUrl = photoUrl;
            this.Status = status;
        }

        public string PhotoUrl { get => photoUrl; set => photoUrl = value; }
    }
}
