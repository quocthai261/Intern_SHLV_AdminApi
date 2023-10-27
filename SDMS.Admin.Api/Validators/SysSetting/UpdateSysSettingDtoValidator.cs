using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysSetting;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysSetting
{
    public class UpdateSysSettingsDtoValidator : BaseValidator<UpdateSysSettingDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public UpdateSysSettingsDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.IsActive).NotEmpty().WithMessage(_localizer["Loi bat buoc IsActive"]);
        }
    }
}
