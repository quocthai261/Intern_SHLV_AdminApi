using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatIncome
{
    public class QueryCatIncomeDto
    {
        public long Id { get; set; }
        public string CatIncomeCode { get; set; }
        public string CatIncomeNameEng { get; set; }
        public string CatIncomeNameVie { get; set; }
        public string? Description { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreationDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public long? LastUpdatedBy { get; set; }
    }
}
