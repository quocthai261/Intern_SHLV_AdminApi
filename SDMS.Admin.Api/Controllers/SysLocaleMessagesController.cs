using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysLocaleMessage;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysLocaleMessagesController : BaseCQController<SysLocaleMessage, QuerySysLocaleMessageDto, CreateSysLocaleMessageDto, UpdateSysLocaleMessageDto>
    {
        private readonly IMediator _mediator;

        public SysLocaleMessagesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
