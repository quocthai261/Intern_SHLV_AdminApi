using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatBankBranch
{
    public class UpdateCatBankBranchDto
    {
        public int Id { get; set; }
        public string BranchCode { get; set; }

        public string InternalCode { get; set; }

        public string BranchName { get; set; }

        public string BranchClass { get; set; }

        public string Status { get; set; }

        public string BranchType { get; set; }

        public string AbbrName { get; set; }

        public int? IdType { get; set; }

        public string IdNumber { get; set; }

        public int? BankId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }

        public long? AddressId { get; set; }
    }
}
