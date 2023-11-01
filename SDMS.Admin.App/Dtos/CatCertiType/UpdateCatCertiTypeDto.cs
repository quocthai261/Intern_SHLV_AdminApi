using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatCertiType
{
    public class UpdateCatCertiTypeDto
    {
        public long Id { get; set; }
        public string CertiTypeName { get; set; }
        public string CertiTypeNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
