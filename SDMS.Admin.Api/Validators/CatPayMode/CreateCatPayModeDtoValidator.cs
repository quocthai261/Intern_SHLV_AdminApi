using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.CatPayMode;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysMobileMenu
{
    public class CreateCatPayModeDtoValidator : BaseValidator<CreateCatPayModeDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateCatPayModeDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.PayModeNameEng).NotEmpty().WithMessage(_localizer["Loi bat buoc PayModeNameEng"]);
        }
    }
}
