using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysUserLoginHistory
{
    public class CreateSysUserLoginHistoryDto
    {
        public string? UserName { get; set; }
        public string? FullName { get; set; }
        public DateTime? LoginDate { get; set; }
        public string? Browser { get; set; }
        public string? Device { get; set; }
        public string? IpAddress { get; set; }
        public bool? Status { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? CreatedBy { get; set; }
    }
}
