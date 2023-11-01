using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatOccupation
{
    public class CreateCatOccupationDto
    {
         public string OccupationCode { get; set; }
        public string OccupationNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long? CreatedBy { get; set; }
 
        public string OccupationNameEng { get; set; }
        public string OccupationNameVieCore { get; set; }
    }
}
