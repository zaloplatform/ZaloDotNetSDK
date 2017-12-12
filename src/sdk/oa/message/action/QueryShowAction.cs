using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    class QueryShowAction : MsgAction
    {
        private string _data;
        private string _action = "oa.query.show";

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
    }
}
