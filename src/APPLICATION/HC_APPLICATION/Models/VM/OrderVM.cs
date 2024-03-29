﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.VM
{
    public class OrderVM
    {
        public Guid OrderID { get; set; }
        public string EmployeeName { get; set; }
        public string UserName { get; set; }
        public string ProductName { get; set; }

        public int Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public decimal? SubTotal { get => UnitPrice * Quantity; }
    }
}
