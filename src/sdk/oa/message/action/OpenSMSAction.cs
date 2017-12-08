using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class OpenSMSAction : MsgAction
    {
        private string _content;
        private string _phoneCode;

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
            return "oa.open.sms";
        }

        public override string getHref()
        {
            return null;
        }

        public override Object getData()
        {
            JObject obj = new JObject();
            obj.Add("content", _content);
            obj.Add("phoneCode", _phoneCode);
            return obj;
        }
    }
}
