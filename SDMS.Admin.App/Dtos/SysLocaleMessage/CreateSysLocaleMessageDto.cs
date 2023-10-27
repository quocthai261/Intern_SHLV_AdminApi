using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysLocaleMessage
{
    public class CreateSysLocaleMessageDto
    {
        public long LanguageId { get; set; }
        public string MessageName { get; set; } = null!;
        public string MessageValue { get; set; } = null!;
        public DateTime? CreationDate { get; set; }
        public decimal? CreatedBy { get; set; }
    }
}
