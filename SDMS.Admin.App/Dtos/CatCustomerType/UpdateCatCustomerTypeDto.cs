using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatCustomerType
{
    public class UpdateCatCustomerTypeDto
    {
        public long Id { get; set; }

        public string CustomerTypeCode { get; set; }

        public string CustomerTypeName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
