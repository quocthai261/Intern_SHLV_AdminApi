using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysLanguage;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysLanguageController : BaseCQController<SysLanguage,QuerySysLanguageDto, CreateSysLanguageDto, UpdateSysLanguageDto>
    {
        private readonly IMediator _mediator;

        public SysLanguageController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
