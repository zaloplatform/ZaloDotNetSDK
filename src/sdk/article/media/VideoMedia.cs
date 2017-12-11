using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class VideoMedia
    {
        private string _title;
        private string _desc;
        private string _status;
        private string _videoId;
        private string _avatar;
        private List<RelatedMedia> _relatedMedias;

        public string title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
        }

        public string desc
        {
            get
            {
                return _desc;
            }

            set
            {
                _desc = value;
            }
        }

        public string status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string videoId
        {
            get
            {
                return _videoId;
            }

            set
            {
                _videoId = value;
            }
        }

        public string avatar
        {
            get
            {
                return _avatar;
            }

            set
            {
                _avatar = value;
            }
        }

        public List<RelatedMedia> relatedMedias
        {
            get
            {
                return _relatedMedias;
            }

            set
            {
                _relatedMedias = value;
            }
        }
    }
}
