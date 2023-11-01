using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatClaimStatus
{
    public class CreateCatClaimStatusDto
    {
        public string ClaimStatusName { get; set; }
        public string ClaimStatusNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
    }
}
