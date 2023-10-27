using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysApplication
{
    public class UpdateSysApplicationDto
    {
        public string Id { get; set; } = null!;
        public string? SysApplicationName { get; set; }
        public int? Index { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
    }
}
