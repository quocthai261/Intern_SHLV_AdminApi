﻿using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatDiagnosisGroup
    {
        public long Id { get; set; }
        public string CategoryDescription { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public long LastUpdatedBy { get; set; }
    }
}
