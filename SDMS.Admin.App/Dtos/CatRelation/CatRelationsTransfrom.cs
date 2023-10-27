using PB22.Extend.Api.Transform;
using SDMS.Admin.App.Dtos.CatRelation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatRelation
{
    public class CreateCatRelationDtoTransform : BaseModelHandleTransform<CreateCatRelationDto, Domain.Entities.CatRelation>, IModelHandleTransform<CreateCatRelationDto, Domain.Entities.CatRelation>
    {

    }
}
