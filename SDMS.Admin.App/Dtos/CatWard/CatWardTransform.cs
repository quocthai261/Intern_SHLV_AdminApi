using PB22.Extend.Api.Transform;

namespace SDMS.Admin.App.Dtos.CatWard
{
    public class CreateCatWardDtoTransform : BaseModelHandleTransform<CreateCatWardDto, Domain.Entities.CatWard>, IModelHandleTransform<CreateCatWardDto, Domain.Entities.CatWard>
    {

    }
}
