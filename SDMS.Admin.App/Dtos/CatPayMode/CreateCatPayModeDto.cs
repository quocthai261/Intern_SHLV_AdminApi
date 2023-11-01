using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatPayMode
{
    public class CreateCatPayModeDto
    {
        public string PayModeNameEng { get; set; } = null!;
        public string? PayModeType { get; set; }
        public string? PayModeNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
