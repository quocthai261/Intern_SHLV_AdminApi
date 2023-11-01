using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatChargeMode
    {
        public long Id { get; set; }
        public string ChargeModeName { get; set; }
        public string ChargeModeNameVN { get; set; }
        public bool? IsActive { get; set; }
        public string ChargeType { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
