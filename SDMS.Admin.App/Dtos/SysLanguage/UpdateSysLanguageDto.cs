using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysLanguage
{
    public class UpdateSysLanguageDto
    {
        public decimal Id { get; set; }
        public string Name { get; set; } = null!;
        public string LanguageCulture { get; set; } = null!;
        public string? FlagImageFileName { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
