using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysSetting;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysSetting
{
    public class CreateSysSettingDtoValidator : BaseValidator<CreateSysSettingDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSysSettingDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.IsActive).NotEmpty().WithMessage(_localizer["Loi bat buoc IsActive"]);
        }
    }
}
