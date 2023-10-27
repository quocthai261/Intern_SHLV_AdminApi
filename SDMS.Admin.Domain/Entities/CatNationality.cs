using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public partial class CatNationality
    {
        public long Id { get; set; }

        public string? NationalityCode { get; set; }

        public string? NationalityName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
