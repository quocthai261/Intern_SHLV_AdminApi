using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatHospital
{
    public class UpdateCatHospitalDto
    {
        public long Id { get; set; }

        public string? HospitalCode { get; set; }
        public string? HospitalNameEng { get; set; }

        public string? HospitalNameVie { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
