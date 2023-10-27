using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.Entities
{
    public partial class CatBank
    {
        public int Id { get; set; }

        public string BankOrgName { get; set; }

        public string BankOrgCode { get; set; }

        public int? IdType { get; set; }

        public string? IdNumber { get; set; }

        public string AbbrName { get; set; }

        public string Status { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
