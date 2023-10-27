using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysLanguage;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysLanguage
{
    public class CreateSysLanguageDtoValidator : BaseValidator<CreateSysLanguageDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSysLanguageDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.Name).NotEmpty().WithMessage(_localizer["Loi bat buoc Name"]);
            RuleFor(x => x.LanguageCulture).NotEmpty().WithMessage(_localizer["Loi bat buoc LanguageCulture"]);
        }
    }
}
