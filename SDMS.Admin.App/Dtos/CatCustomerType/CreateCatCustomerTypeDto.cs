using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatCustomerType
{
    public class CreateCatCustomerTypeDto
    {
        public string CustomerTypeCode { get; set; }

        public string CustomerTypeName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }
    }
}
