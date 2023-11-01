using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatBankBranch
{
    public class CreateCatBankBranchDto
    {
        public string BranchCode { get; set; }

        public string longernalCode { get; set; }

        public string BranchName { get; set; }

        public string BranchClass { get; set; }

        public string Status { get; set; }

        public string BranchType { get; set; }

        public string AbbrName { get; set; }

        public long? IdType { get; set; }

        public string IdNumber { get; set; }

        public long? BankId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public long? AddressId { get; set; }
    }
}
