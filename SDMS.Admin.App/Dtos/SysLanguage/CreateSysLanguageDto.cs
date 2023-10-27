using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysLanguage
{
    public class CreateSysLanguageDto
    {
        public string Name { get; set; } = null!;
        public string LanguageCulture { get; set; } = null!;
        public string? FlagImageFileName { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
