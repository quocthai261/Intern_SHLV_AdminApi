using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysSetting;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysSettingsController : BaseCQController<SysSetting, QuerySysSettingDto, CreateSysSettingDto, UpdateSysSettingDto>
    {
        private readonly IMediator _mediator;

        public SysSettingsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
