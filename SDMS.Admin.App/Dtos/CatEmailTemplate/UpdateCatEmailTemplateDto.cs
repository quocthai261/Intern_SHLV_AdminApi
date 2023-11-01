using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatEmailTemplate
{
    public class UpdateCatEmailTemplateDto
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Creator { get; set; }
        public DateTime? EffectDate { get; set; }
        public string Subject { get; set; }
        public string? Note { get; set; }
        public bool? Active { get; set; }
        public string Name { get; set; }
        public string? Content { get; set; }
        public string EmailTypeGroup { get; set; }
        public byte? EmailType { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
