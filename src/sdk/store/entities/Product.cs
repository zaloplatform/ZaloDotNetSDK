using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Product
    {
        private List<JObject> _cateids;
        private string _name;
        private string _desc;
        private string _code;
        private long _price;
        private List<JObject> _photos;
        private string _display;
        private int _payment;

        public List<JObject> cateids
        {
            get
            {
                return _cateids;
            }

            set
            {
                _cateids = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
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

        public string code
        {
            get
            {
                return _code;
            }

            set
            {
                _code = value;
            }
        }

        public long price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public List<JObject> photos
        {
            get
            {
                return _photos;
            }

            set
            {
                _photos = value;
            }
        }

        public string display
        {
            get
            {
                return _display;
            }

            set
            {
                _display = value;
            }
        }

        public int payment
        {
            get
            {
                return _payment;
            }

            set
            {
                _payment = value;
            }
        }
    }
}
