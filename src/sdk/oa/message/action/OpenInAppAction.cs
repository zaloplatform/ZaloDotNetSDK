using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class OpenInAppAction : MsgAction
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
            return "oa.open.inapp";
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
