using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatClaimStatus
{
    public class UpdateCatClaimStatusDto
    {
        public long Id { get; set; }
        public string ClaimStatusName { get; set; }
        public string ClaimStatusNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
