using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Order
    {
        private string _orderid;
        private int _status;
        private string _reason;
        private string _cancelReason;

        public int status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }

        public string reason
        {
            get
            {
                return _reason;
            }

            set
            {
                _reason = value;
            }
        }

        public string cancelReason
        {
            get
            {
                return _cancelReason;
            }

            set
            {
                _cancelReason = value;
            }
        }

        public string orderid
        {
            get
            {
                return _orderid;
            }

            set
            {
                _orderid = value;
            }
        }
    }
}
