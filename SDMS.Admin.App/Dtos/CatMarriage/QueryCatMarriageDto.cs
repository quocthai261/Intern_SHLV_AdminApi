using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatMarriage
{
    public class QueryCatMarriageDto
    {
        public byte Id { get; set; }
        public string MarriageCode { get; set; }
        public string MarriageNameEng { get; set; }
        public string MarriageNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
