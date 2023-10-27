using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatNationality
{
    public class UpdateCatNationalityDto
    {
        public long Id { get; set; }

        public string? NationalityCode { get; set; }

        public string? NationalityName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
