﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class QueryObjectParams : PageParam
    {
        public List<SortParam> SortingParams { get; set; }
    }
}
