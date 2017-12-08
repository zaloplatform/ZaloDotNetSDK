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

        public override string getAction()
        {
            return "oa.query.hide";
        }

        public override String getHref()
        {
            return null;
        }

        public override Object getData()
        {
            return data;
        }
    }
}
