using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysApplication;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysApplicationController : BaseCQController<SysApplication,QuerySysApplicationDto, CreateSysApplicationDto, UpdateSysApplicationDto>
    {
        private readonly IMediator _mediator;

        public SysApplicationController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
