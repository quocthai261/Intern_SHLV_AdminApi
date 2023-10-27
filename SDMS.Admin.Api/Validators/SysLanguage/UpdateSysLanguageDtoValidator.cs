using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysLanguage;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysLanguage
{
    public class UpdateSysLanguageDtoValidator : BaseValidator<UpdateSysLanguageDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public UpdateSysLanguageDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.Name).NotEmpty().WithMessage(_localizer["Loi bat buoc Name"]);
            RuleFor(x => x.LanguageCulture).NotEmpty().WithMessage(_localizer["Loi bat buoc LanguageCulture"]);
        }
    }
}
