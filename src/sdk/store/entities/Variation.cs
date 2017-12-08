using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaloCSharpSDK
{
    public class Variation
    {
        private string _variationid;
        private int _default;
        private double _price;
        private string _name;
        private List<string> _attributes;

        public int @default
        {
            get
            {
                return _default;
            }

            set
            {
                _default = value;
            }
        }

        public double price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

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

        public List<string> attributes
        {
            get
            {
                return _attributes;
            }

            set
            {
                _attributes = value;
            }
        }

        public string variationid
        {
            get
            {
                return _variationid;
            }

            set
            {
                _variationid = value;
            }
        }
    }
}
