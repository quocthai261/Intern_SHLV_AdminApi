using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatCommon
{
    public class UpdateCatCommonDto
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long? Type { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
