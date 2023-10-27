using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Commands.CatProvince
{
    public class DeleteCatProvinceCommand : IRequest
    {
        public long ProvinceId { get; set; }
    }
}
