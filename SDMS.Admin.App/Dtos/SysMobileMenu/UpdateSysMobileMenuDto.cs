using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysMobileMenu
{
    public class UpdateSysMobileMenuDto
    {
        public long Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDefault { get; set; }
        public long? Order_ { get; set; }
        public string? Icon1 { get; set; }
        public string? Icon2 { get; set; }
        public string? Color1 { get; set; }
        public string? Color2 { get; set; }
        public string? Color3 { get; set; }
        public string? ParentId { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public string? PermissionName { get; set; }
        //public bool? IsFavoriteDefault { get; set; } //form Create & Edit không có 
        public int? FavoriteIndex { get; set; }
        public bool IsInstantPush { get; set; }
        public bool SetInstantPush { get; set; }
        public long? InstantPushId { get; set; }
    }
}
