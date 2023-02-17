using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class SortParam
    {
        public bool? SortOrderDescending { get; set; }

        public string OrderProperty { get; set; }
    }
}
