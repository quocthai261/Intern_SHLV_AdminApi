using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatDistrict
{
    public class UpdateCatDistrictDto
    {
        public long Id { get; set; }

        public long? ProvinceCode { get; set; }

        public string? DistrictCode { get; set; }

        public string? DistrictName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
