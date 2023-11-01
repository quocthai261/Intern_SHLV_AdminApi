using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatClaimType
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public string ClaimTypeCode { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public bool? IsActiveForClaim { get; set; }
        public bool IsRequireDoc { get; set; }
    }
}
