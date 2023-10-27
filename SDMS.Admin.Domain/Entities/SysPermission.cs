using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public class SysPermission
    {
        public long Id { get; set; }
        public string? PermissionName { get; set; }
        public string? Description { get; set; }
        public long? Type { get; set; }
        public string? Application { get; set; }
        public long? ParentId { get; set; }
        public bool? IsPermisstion { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
