﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HC_APPLICATION.Models.DTO
{
    public class CreateSubCategoryDTO
    {
        public string SubCategoryName { get; set; }
        public string Description { get; set; }
        public Guid CategoryId { get; set; }
    }
}
