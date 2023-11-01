using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatHospital
{
    public class CreateCatHospitalDto
    {

        public string? HospitalCode { get; set; }

        public string? HospitalNameVie { get; set; }
        public string? HospitalNameEng { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }
    }
}
