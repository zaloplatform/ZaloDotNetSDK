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
            return "oa.query.show";
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
