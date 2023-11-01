using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatClaimType
{
    public class CreateCatClaimTypeDto
    {
        public string Description { get; set; }
        public string ClaimTypeCode { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public bool? IsActiveForClaim { get; set; }
        public bool IsRequireDoc { get; set; }
    }
}
