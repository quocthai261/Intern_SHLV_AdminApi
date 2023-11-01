using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatDiagnosis
    {
        public long Id { get; set; }
        public string DiagnoDescription { get; set; }
        public long? ParentId { get; set; }
        public byte DiagnoCategory { get; set; }
        public string DiagnoName { get; set; }
        public char? Acceptable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
