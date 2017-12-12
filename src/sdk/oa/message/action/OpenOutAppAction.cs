using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    class OpenOutAppAction : MsgAction
    {
        private string _data;
        private string _action = "oa.open.outapp";

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

        public string data
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
