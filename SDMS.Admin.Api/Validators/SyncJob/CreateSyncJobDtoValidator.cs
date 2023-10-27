using FluentValidation;
using Microsoft.Extensions.Localization;
using PB22.Core.Api.Misc;
using SDMS.Admin.App.Dtos.SyncJob;
using SDMS.Admin.Resources;

namespace SDMS.Admin.Api.Validators.SyncJob
{
    public class CreateSyncJobDtoValidator : BaseValidator<CreateSyncJobDto>
    {
        private readonly IStringLocalizer<SharedResource> _localizer;
        public CreateSyncJobDtoValidator(IStringLocalizer<SharedResource> localizer)
        {
            _localizer = localizer;
            RuleFor(x => x.ScheduleTypeId).NotEmpty().WithMessage(_localizer["Loi bat buoc ScheduleTypeId"]);
        }
    }
}
