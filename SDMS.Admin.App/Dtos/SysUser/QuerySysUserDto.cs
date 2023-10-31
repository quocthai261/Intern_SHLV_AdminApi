using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysUser
{
    public class QuerySysUserDto
    {
        public long Id { get; set; }
        public string? ReferentId { get; set; }
        public string UserName { get; set; } = null!;
        public int UserType { get; set; }
        public int UserRule { get; set; }
        public string? Provider { get; set; }
        public string? Name { get; set; }
        public string? SurName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
