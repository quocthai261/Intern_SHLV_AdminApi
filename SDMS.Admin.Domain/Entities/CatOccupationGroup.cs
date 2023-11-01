using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatOccupationGroup
    {
        public long Id { get; set; }
        public string OccupantionGroupCode { get; set; }
        public string OccupantionGroupNameEng { get; set; }
        public string OccupantionGroupNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
