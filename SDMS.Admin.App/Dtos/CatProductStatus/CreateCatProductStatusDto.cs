﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatProductStatus
{
    public class CreateCatProductStatusDto
    {
        public long Id { get; set; }
        public string? ProductStatusCode { get; set; }
        public string? ProductStatusNameEng { get; set; }
        public string? ProductStatusNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}