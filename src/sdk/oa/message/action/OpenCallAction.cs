using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class OpenCallAction : MsgAction
    {
        private string _phoneCode;

        public string phoneCode
        {
            get
            {
                return _phoneCode;
            }

            set
            {
                _phoneCode = value;
            }
        }

        public override string getAction()
        {
            return "oa.open.phone";
        }

        public override string getHref()
        {
            return null;
        }

        public override Object getData()
        {
            JObject obj = new JObject();
            obj.Add("phoneCode", _phoneCode);
            return obj;
        }
    }
}
