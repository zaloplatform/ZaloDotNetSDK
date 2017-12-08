using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    class OpenOutAppAction : MsgAction
    {
        private string _url;

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

        public override string getAction()
        {
            return "oa.open.outapp";
        }

        public override string getHref()
        {
            return null;
        }

        public override Object getData()
        {
            return url;
        }
    }
}
