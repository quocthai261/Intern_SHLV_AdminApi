
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysMenus;
using SDMS.Admin.App.Queries.SysMenus;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysMenusController : BaseCQController<SysMenu, QuerySysMenusDto, CreateSysMenusDto, UpdateSysMenusDto>
    {
        private readonly IMediator _mediator;

        public SysMenusController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("menu-active/{sourceType}")]
        public async Task<ActionResult<List<QuerySysMenusDto>>> GetListMenu(int sourceType)
        {
            return await _mediator.Send(new GetActiveMenuQuery { SourceType = sourceType });
        }
    }
}
