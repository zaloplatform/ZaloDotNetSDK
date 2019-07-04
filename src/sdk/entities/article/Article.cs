using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities
{
    public class Article
    {
        private string type = "normal";
        private string title;
        private string author;
        private Cover cover;
        private string description;
        private List<Paragraph> body;
        private List<RelatedMedia> relatedMedias;
        private string trackingLink;
        private ArticleStatus status;
        private ArticleStatus comment;

        public Article()
        {
        }

        public Article(string title, string author, Cover cover, string description, List<Paragraph> body, List<RelatedMedia> relatedMedias, string trackingLink, ArticleStatus status, ArticleStatus comment)
        { 
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.description = description;
            this.body = body;
            this.relatedMedias = relatedMedias;
            this.trackingLink = trackingLink;
            this.status = status;
            this.comment = comment;
        }

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Description { get => description; set => description = value; }
        public string TrackingLink { get => trackingLink; set => trackingLink = value; }
        public Cover Cover { get => cover; set => cover = value; }
        public List<Paragraph> Body { get => body; set => body = value; }
        public List<RelatedMedia> RelatedMedias { get => relatedMedias; set => relatedMedias = value; }
        public ArticleStatus Status { get => status; set => status = value; }
        public ArticleStatus Comment { get => comment; set => comment = value; }
        public string Type { get => type;}
    }
}
