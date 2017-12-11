using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class RelatedMedia
    {
        private string _id;

        public RelatedMedia(string id)
        {
            _id = id;
        }

        public string id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }
    }
}
