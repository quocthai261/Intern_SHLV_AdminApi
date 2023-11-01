using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatDiagnosis
{
    public class CreateCatDiagnosisDto
    {
        public string? DiagnoDescription { get; set; }
        public long? ParentId { get; set; }
        public byte DiagnoCategory { get; set; }
        public string DiagnoName { get; set; }
        public char? Acceptable { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        
    }
}
