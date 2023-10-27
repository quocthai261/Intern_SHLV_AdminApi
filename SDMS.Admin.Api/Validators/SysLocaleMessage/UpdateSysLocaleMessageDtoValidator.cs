using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysLocaleMessage;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysLocaleMessage
{
    public class UpdateSysLocaleMessageDtoValidator : BaseValidator<UpdateSysLocaleMessageDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public UpdateSysLocaleMessageDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.LanguageId).NotEmpty().WithMessage(_localizer["Loi bat buoc LanguageId"]);
            RuleFor(x => x.MessageName).NotEmpty().WithMessage(_localizer["Loi bat buoc MessageName"]);
            RuleFor(x => x.MessageValue).NotEmpty().WithMessage(_localizer["Loi bat buoc MessageValue"]);
        }
    }
}
