using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public class SysLocaleMessage
    {
        public long Id { get; set; }
        public long LanguageId { get; set; }
        public string MessageName { get; set; } = null!;
        public string MessageValue { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public decimal? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public decimal? LastUpdatedBy { get; set; }
    }
}
