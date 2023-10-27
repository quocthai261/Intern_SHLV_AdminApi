using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysRole;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysMobileMenu
{
    public class CreateSysRoleDtoValidator : BaseValidator<CreateSysRoleDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSysRoleDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.Name).NotEmpty().WithMessage(_localizer["Loi bat buoc Name"]);
            RuleFor(x => x.Code).NotEmpty().WithMessage(_localizer["Loi bat buoc Code"]);
        }
    }
}
