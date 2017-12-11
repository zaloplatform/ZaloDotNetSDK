using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class ActionLink
    {
        private int _type;
        private string _label;
        private string _url;

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

        public string label
        {
            get
            {
                return _label;
            }

            set
            {
                _label = value;
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
    }
}
