using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Common
{
    public class DataItem
    {
        public DataItem(string _header)
        {
            this.Header = _header;
        }
        public string Header { get; set; }
    }
}
