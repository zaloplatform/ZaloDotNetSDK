using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Cover
    {
        private int _coverType;
        private int _coverView;
        private string _videoId;
        private string _photoUrl;
        private string _status;

        public int coverType
        {
            get
            {
                return _coverType;
            }

            set
            {
                _coverType = value;
            }
        }

        public int coverView
        {
            get
            {
                return _coverView;
            }

            set
            {
                _coverView = value;
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

        public string photoUrl
        {
            get
            {
                return _photoUrl;
            }

            set
            {
                _photoUrl = value;
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
    }
}
