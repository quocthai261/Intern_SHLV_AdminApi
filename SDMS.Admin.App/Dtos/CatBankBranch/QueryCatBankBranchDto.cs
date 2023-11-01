﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatBankBranch
{
    public class QueryCatBankBranchDto
    {
        public long Id { get; set; }

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

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? Address3 { get; set; }

        public string? Address4 { get; set; }

        public string? Address5 { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }

        public long? AddressId { get; set; }
    }
}
