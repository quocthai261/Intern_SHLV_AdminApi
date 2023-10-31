using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysMenus;
using SDMS.Admin.App.Dtos.SysRole;
using SDMS.Admin.App.Dtos.SysUserInformation;
using SDMS.Admin.App.Queries.SysMenus;
using SDMS.Admin.App.Queries.SysUserInformation;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysUserInformationsController : BaseCQController<SysUserInformation, QuerySysUserInformationDto, CreateSysUserInformationDto, UpdateSysUserInformationDto>
    {
        private readonly IMediator _mediator;

        public SysUserInformationsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        [Route("user-detail/{id}")]
        public async Task<ActionResult<List<QuerySysUserInformationDto>>> GetListUserInformationByUserId(long id)
        {
            return await _mediator.Send(new GetUserInformationByUserIdQuery {UserId = id });
        }

    }
}
