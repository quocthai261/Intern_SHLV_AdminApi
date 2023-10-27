using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysApplication
{
    public class CreateSysApplicationDto
    {
        public string Id { get; set; } = null!;
        public string? SysApplicationName { get; set; }
        public int? Index { get; set; }
        public DateTime? CreationDate { get; set; }
        public decimal? CreatedBy { get; set; }
    }
}
