﻿using HC_DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.VM
{
    public class ProductVM
    {
        public Guid Id { get; set; }
        public Guid SubCategoryId { get; set; }

        public string ProductName { get; set; }
        public string Description { get; set; }

        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }

        public string ImagePath { get; set; }

        public string SubCategoryName { get; set; }
        public Status Status { get; set; }

    }
}
