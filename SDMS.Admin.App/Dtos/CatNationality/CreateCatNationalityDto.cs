using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatNationality
{
    public class CreateCatNationalityDto
    {
        public string? NationalityCode { get; set; }

        public string? NationalityName { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }

    }
}
