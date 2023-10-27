using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysPermission
{
    public class CreateSysPermissionDto
    {
        public string? PermissionName { get; set; }
        public string? Description { get; set; }
        public long? Type { get; set; }
        public string? Application { get; set; }
        public long? ParentId { get; set; }
        public int? IsActive { get; set; }
        public int? IsPermisstion { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
