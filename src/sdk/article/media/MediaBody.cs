using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class MediaBody
    {
        private int _type;
        private string _content;
        private string _url;
        private string _caption;
        private int _width;
        private int _height;
        private string _category;
        private string _thumb;
        private string _videoId;
        private string _id;

        public int type
        {
            get
            {
                return _type;
            }

            set
            {
                _type = value;
            }
        }

        public string content
        {
            get
            {
                return _content;
            }

            set
            {
                _content = value;
            }
        }

        public string url
        {
            get
            {
                return _url;
            }

            set
            {
                _url = value;
            }
        }

        public string caption
        {
            get
            {
                return _caption;
            }

            set
            {
                _caption = value;
            }
        }

        public int width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public int height
        {
            get
            {
                return _height;
            }

            set
            {
                _height = value;
            }
        }

        public string category
        {
            get
            {
                return _category;
            }

            set
            {
                _category = value;
            }
        }

        public string thumb
        {
            get
            {
                return _thumb;
            }

            set
            {
                _thumb = value;
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

        public string id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}
