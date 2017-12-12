using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class QueryHideAction : MsgAction
    {
        private string _data;
        private string _action = "oa.query.hide";

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
