﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysMenus
{
    public class QuerySysMenusDto
    {
        public long Id { get; set; }

        public string Content { get; set; } = null!;

        public string? IconClass { get; set; }

        public string Url { get; set; } = null!;

        public long Order { get; set; }

        public string? PermissionName { get; set; }

        public string? ParentCode { get; set; }
        public string? Code { get; set; }
        public string ParentName { get; set; }

        public bool IsDisplay { get; set; }

        public bool IsActive { get; set; }

        public string? SystemName { get; set; }

        public long? AppId { get; set; }

        public bool? IsDefault { get; set; }

        public string? Color1 { get; set; }

        public string? Color2 { get; set; }

        public string? Icon1 { get; set; }

        //public string? Code { get; set; }

        public string? Icon2 { get; set; }

        public string? Color3 { get; set; }


        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
