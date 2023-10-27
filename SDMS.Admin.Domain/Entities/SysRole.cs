using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public class SysRole
    {
        public long Id { get; set; }
        public string? ConCurrencyStamp { get; set; }
        public string Name { get; set; } = null!;
        public string? NormalizedName { get; set; }
        public string Code { get; set; } = null!;
        public bool IsSystem { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
