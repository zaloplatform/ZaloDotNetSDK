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
        private JObject _data;
        private string _action = "oa.open.phone";

        public string action
        {
            get
            {
                return _action;
            }

            set
            {
                _action = value;
            }
        }

        public JObject data
        {
            get
            {
                return _data;
            }

            set
            {
                _data = value;
            }
        }
    }
}
