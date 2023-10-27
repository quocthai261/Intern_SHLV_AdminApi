using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysRole;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysMobileMenu
{
    public class UpdateSysRoleDtoValidator : BaseValidator<UpdateSysRoleDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public UpdateSysRoleDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.Name).NotEmpty().WithMessage(_localizer["Loi bat buoc Name"]);
            RuleFor(x => x.Code).NotEmpty().WithMessage(_localizer["Loi bat buoc Code"]);
        }
    }
}
