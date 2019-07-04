using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class VideoArticle
    {
        private string type = "video";
        private string title;
        private string description;
        private string video_id;
        private string avatar;
        private ArticleStatus comment;
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string Video_id { get => video_id; set => video_id = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public ArticleStatus Comment { get => comment; set => comment = value; }
        public string Type { get => type; }

        public VideoArticle(string title, string description, string video_id, string avatar, ArticleStatus comment)
        {
            Title = title;
            Description = description;
            Video_id = video_id;
            Avatar = avatar;
            Comment = comment;
        }
    }
}
