using PB22.Extend.Api.Transform;
using SDMS.Admin.Api.Dtos.CatProvince;

namespace SDMS.Admin.App.Dtos.CatProvince
{
    public class CreateCatProvinceDtoTransform : BaseModelHandleTransform<CreateCatProvinceDto, Domain.Entities.CatProvince>, IModelHandleTransform<CreateCatProvinceDto, Domain.Entities.CatProvince>
    {
        //public override Domain.Entities.CatProvince Transform(CreateProvinceDto source)
        //{
        //    var des = base.Transform(source);
        //    //des.SetName("create");
        //    return des;
        //}
    }
}
