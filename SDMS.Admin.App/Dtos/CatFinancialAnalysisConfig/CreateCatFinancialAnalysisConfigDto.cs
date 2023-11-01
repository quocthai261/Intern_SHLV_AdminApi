﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatFinancialAnalysisConfig
{
    public class CreateCatFinancialAnalysisConfigDto
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long CreatedBy { get; set; }
    }
}
