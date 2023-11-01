using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatMarriage
{
    public class CreateCatMarriageDto
    {
 
        public string MarriageCode { get; set; }
        public string MarriageNameEng { get; set; }
        public string MarriageNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
 
    }
}
