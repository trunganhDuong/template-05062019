﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Template_RealEstate_20052019.Areas.FrontEnd.Models;

namespace Template_RealEstate_20052019.Models
{
    public class SearchRequest
    {
        public int PageIndex { get; set; }

        public int PageSize { get; set; }

        public int ItemId { get; set; }

        public bool IsPolicy { get; set; }
    }
}
