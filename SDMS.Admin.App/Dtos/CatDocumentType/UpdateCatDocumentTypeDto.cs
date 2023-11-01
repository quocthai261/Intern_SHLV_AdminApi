using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatDocumentType
{
    public class UpdateCatDocumentTypeDto
    {
        public long Id { get; set; }
        public string DocumentTypeName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool IsExternal { get; set; }
    }
}
