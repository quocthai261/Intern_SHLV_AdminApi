using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.SysUserInformation
{
    public class QuerySysUserInformationDto
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long IdentificationNumber { get; set; }
        public string? Gender { get; set; }
        public DateTime? DayOfBirth { get; set; }
        public string? Address { get; set; }
        public int? Status { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? ResignationDate { get; set; }
        public string? Degree { get; set; }
        public string? Major { get; set; }
        public string? DegreeClassification { get; set; }
        public string? ImageIdentificationFront { get; set; }
        public string? ImageIdentificationBack { get; set; }
        public string? ImageDegree { get; set; }
        public string? ImageHealthCertification { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
