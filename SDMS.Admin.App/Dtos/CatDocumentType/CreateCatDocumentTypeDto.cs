using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatDocumentType
{
    public class CreateCatDocumentTypeDto
    {
        public string DocumentTypeName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public bool IsExternal { get; set; }
    }
}
