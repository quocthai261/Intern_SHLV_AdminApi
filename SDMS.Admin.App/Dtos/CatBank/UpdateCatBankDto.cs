using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatBank
{
    public class UpdateCatBankDto
    {
        public int Id { get; set; }
        public string BankOrgName { get; set; }
        public string BankOrgCode { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
