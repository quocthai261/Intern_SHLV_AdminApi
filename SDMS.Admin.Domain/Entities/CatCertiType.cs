using System;

namespace SDMS.Admin.Domain.Entities
{
    public class CatCertiType
    {
        public long Id { get; set; }
        public string CertiTypeName { get; set; }
        public string CertiTypeNameVN { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
