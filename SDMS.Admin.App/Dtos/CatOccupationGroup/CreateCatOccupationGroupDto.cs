﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatOccupationGroup
{
    public class CreateCatOccupationGroupDto
    {
        public string OccupantionGroupCode { get; set; }
        public string OccupantionGroupNameEng { get; set; }
        public string OccupantionGroupNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
  
    }
}