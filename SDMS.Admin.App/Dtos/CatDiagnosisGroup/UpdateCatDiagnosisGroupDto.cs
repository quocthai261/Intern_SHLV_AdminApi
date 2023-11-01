﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatDiagnosisGroup
{
    public class UpdateCatDiagnosisGroupDto
    {
        public long Id { get; set; }
        public string CategoryDescription { get; set; }
        public bool? IsActive { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public long LastUpdatedBy { get; set; }
    }
}
