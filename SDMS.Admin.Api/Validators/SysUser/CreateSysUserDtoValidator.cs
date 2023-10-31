using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysUser;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysUser
{
    public class CreateSysUserDtoValidator : BaseValidator<CreateSysUserDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSysUserDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.UserName).NotEmpty().WithMessage(_localizer["Loi bat buoc UserName"]);
            RuleFor(x => x.UserType).NotEmpty().WithMessage(_localizer["Loi bat buoc UserType"]);
            RuleFor(x => x.UserRule).NotEmpty().WithMessage(_localizer["Loi bat buoc UserRule"]);
        }
    }
}
