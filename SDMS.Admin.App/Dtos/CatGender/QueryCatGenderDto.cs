using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatGender
{
    public class QueryCatGenderDto
    {
        public long Id { get; set; }

        public string? GenderCode { get; set; }

        public string? GenderNameEng { get; set; }

        public string? GenderNameVie { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
