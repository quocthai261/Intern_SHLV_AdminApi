using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysRole
{
    public class CreateSysRoleDto
    {
        public string? ConCurrencyStamp { get; set; }
        public string Name { get; set; } = null!;
        public string? NormalizedName { get; set; }
        public string Code { get; set; } = null!;
        public long IsSystem { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
