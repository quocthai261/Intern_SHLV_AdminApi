﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatPolicyStatus
{
    public class CreateCatPolicyStatusDto
    {
        public string? PolicyStatusCode { get; set; }
        public string? PolicyStatusName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}