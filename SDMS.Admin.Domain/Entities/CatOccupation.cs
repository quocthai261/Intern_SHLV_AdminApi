using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatOccupation
    {
        public long Id { get; set; }
        public string OccupationCode { get; set; }
        public string OccupationNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
        public string OccupationNameEng { get; set; }
        public string OccupationNameVieCore { get; set; }
    }
}
