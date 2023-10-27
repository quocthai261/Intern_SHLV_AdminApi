using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SysMobileMenu;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SysMobileMenu
{
    public class UpdateSysMobileMenuDtoValidator : BaseValidator<UpdateSysMobileMenuDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public UpdateSysMobileMenuDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.IsInstantPush).NotEmpty().WithMessage(_localizer["Loi bat buoc IsInstantPush"]);
            RuleFor(x => x.SetInstantPush).NotEmpty().WithMessage(_localizer["Loi bat buoc SetInstantPush"]);
        }
    }
}
