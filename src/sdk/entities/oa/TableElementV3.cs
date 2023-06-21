using System;
using System.Collections.Generic;
using System.Text;

namespace ZaloDotNetSDK.entities.oa
{
    public class TableElementV3 : ElementV3
    {
        private List<ElementV3TableItem> content;

        public TableElementV3(List<ElementV3TableItem> content) : base("table")
        {
            this.Content = content;
        }

        public List<ElementV3TableItem> Content { get => content; set => content = value; }

    }
}
