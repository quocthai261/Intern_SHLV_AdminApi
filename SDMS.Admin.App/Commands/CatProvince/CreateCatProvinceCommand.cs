using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Commands.CatProvince
{
    public class CreateCatProvinceCommand : IRequest
    {
        public string ProvinceCode { get; set; }

        public string ProvinceName { get; set; }

        public bool? IsActive { get; set; }
    }
}
