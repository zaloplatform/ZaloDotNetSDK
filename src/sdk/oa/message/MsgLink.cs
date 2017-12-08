using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class MsgLink
    {
        private string _link;
        private string _linktitle;
        private string _linkdes;
        private string _linkthumb;

        public string link
        {
            get
            {
                return _link;
            }

            set
            {
                _link = value;
            }
        }

        public string linktitle
        {
            get
            {
                return _linktitle;
            }

            set
            {
                _linktitle = value;
            }
        }

        public string linkdes
        {
            get
            {
                return _linkdes;
            }

            set
            {
                _linkdes = value;
            }
        }

        public string linkthumb
        {
            get
            {
                return _linkthumb;
            }

            set
            {
                _linkthumb = value;
            }
        }
    }
}
