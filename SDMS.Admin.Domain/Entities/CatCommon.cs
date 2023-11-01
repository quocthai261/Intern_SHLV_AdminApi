using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatCommon
    {
        public long Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public long? Type { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
