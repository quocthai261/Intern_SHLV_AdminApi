using PB22.Extend.Api.Transform;
using SDMS.Admin.Api.Dtos.CatProvince;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatNationality
{
    public class CreateCatNationalityDtoTransform : BaseModelHandleTransform<CreateCatNationalityDto, Domain.Entities.CatNationality>, IModelHandleTransform<CreateCatNationalityDto, Domain.Entities.CatNationality>
    {
        
    }
}
