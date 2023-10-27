using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Commands.CatProvince
{
    public class UpdateCatProvinceCommand : IRequest
    {
        public long ProvinceId { get; set; }

        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? CreationDate { get; set; }

        public long? CreatedBy { get; set; }

        public DateTime? LastUpdatedDate { get; set; }

        public long? LastUpdatedBy { get; set; }
    }
}
