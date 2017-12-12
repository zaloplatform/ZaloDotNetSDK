using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public abstract class MsgAction
    {
        private string _title;
        private string _description;
        private string _thumb;
        private JObject _popup;
        private string _href;

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

        public string description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
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

        public JObject popup
        {
            get
            {
                return _popup;
            }

            set
            {
                _popup = value;
            }
        }

        public string href
        {
            get
            {
                return _href;
            }

            set
            {
                _href = value;
            }
        }
    }
}
