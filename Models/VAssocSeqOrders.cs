﻿using System;
using System.Collections.Generic;

namespace AdoCrudTutorials.Models
{
    public partial class VAssocSeqOrders
    {
        public string OrderNumber { get; set; }
        public int CustomerKey { get; set; }
        public string Region { get; set; }
        public string IncomeGroup { get; set; }
    }
}
