using FluentValidation;
using PB22.Core.Api.Misc;
using SDMS.Admin.Api.Dtos.CatProvince;

namespace SDMS.Admin.Api.Validators.CatProvince
{
    public class UpdateCatProvinceDtoValidator : BaseValidator<UpdateCatProvinceDto>
    {
        public UpdateCatProvinceDtoValidator()
        {
            RuleFor(x => x.ProvinceCode).NotEmpty().WithMessage("ProvinceCode is required");
        }
    }
}
