using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Category
    {
        private string _name;
        private string _desc;
        private string _photo;
        private int _status;

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public string desc
        {
            get
            {
                return _desc;
            }

            set
            {
                _desc = value;
            }
        }

        public string photo
        {
            get
            {
                return _photo;
            }

            set
            {
                _photo = value;
            }
        }

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
    }
}
