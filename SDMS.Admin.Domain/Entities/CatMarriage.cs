using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatMarriage
    {
        public byte Id { get; set; }
        public string MarriageCode { get; set; }
        public string MarriageNameEng { get; set; }
        public string MarriageNameVie { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
