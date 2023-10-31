using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysUserInformation;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysUserInformation
{
    public class CreateSysUserInformationDtoValidator : BaseValidator<CreateSysUserInformationDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSysUserInformationDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.UserId).NotEmpty().WithMessage(_localizer["Loi bat buoc UserId"]);
            RuleFor(x => x.IdentificationNumber).NotEmpty().WithMessage(_localizer["Loi bat buoc IdentificationNumber"]);
        }
    }
}
