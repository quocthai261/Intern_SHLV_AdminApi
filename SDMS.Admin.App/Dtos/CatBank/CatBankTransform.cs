using PB22.Extend.Api.Transform;
using SDMS.Admin.App.Dtos.CatBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Dtos.CatBank
{
    public class CreateCatBankDtoTransform : BaseModelHandleTransform<CreateCatBankDto, Domain.Entities.CatBank>, IModelHandleTransform<CreateCatBankDto, Domain.Entities.CatBank>
    {

    }
}
