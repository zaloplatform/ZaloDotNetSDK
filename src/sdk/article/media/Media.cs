using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Media
    {
        private string _title;
        private string _author;
        private Cover _cover;
        private string _desc;
        private string _status;
        private ActionLink _actionLink;
        private List<RelatedMedia> _relatedMedias;
        private List<MediaBody> _body;
        private string _trackingLink;

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

        public string author
        {
            get
            {
                return _author;
            }

            set
            {
                _author = value;
            }
        }

        public Cover cover
        {
            get
            {
                return _cover;
            }

            set
            {
                _cover = value;
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

        public ActionLink actionLink
        {
            get
            {
                return _actionLink;
            }

            set
            {
                _actionLink = value;
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

        public List<MediaBody> body
        {
            get
            {
                return _body;
            }

            set
            {
                _body = value;
            }
        }

        public string trackingLink
        {
            get
            {
                return _trackingLink;
            }

            set
            {
                _trackingLink = value;
            }
        }
    }
}
