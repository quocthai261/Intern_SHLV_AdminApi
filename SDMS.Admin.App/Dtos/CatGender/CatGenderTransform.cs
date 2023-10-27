using PB22.Extend.Api.Transform;

namespace SDMS.Admin.App.Dtos.CatGender
{
    public class CreateCatGenderDtoTransform : BaseModelHandleTransform<CreateCatGenderDto, Domain.Entities.CatGender>, IModelHandleTransform<CreateCatGenderDto, Domain.Entities.CatGender>
    {

    }
}
