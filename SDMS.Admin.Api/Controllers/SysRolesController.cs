using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysRole;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysRolesController : BaseCQController<SysRole, QuerySysRoleDto, CreateSysRoleDto, UpdateSysRoleDto>
    {
        private readonly IMediator _mediator;

        public SysRolesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
