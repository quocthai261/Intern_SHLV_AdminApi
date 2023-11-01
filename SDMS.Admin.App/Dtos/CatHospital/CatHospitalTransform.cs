using PB22.Extend.Api.Transform;
using SDMS.Admin.App.Dtos.CatHospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatHospital
{
    public class CreateCatHospitalDtoTransform : BaseModelHandleTransform<CreateCatHospitalDto, Domain.Entities.CatHospital>, IModelHandleTransform<CreateCatHospitalDto, Domain.Entities.CatHospital>
    {

    }
}
