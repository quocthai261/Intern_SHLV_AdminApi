using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysPermission;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysPermissionsController : BaseCQController<SysPermission, QuerySysPermissionDto, CreateSysPermissionDto, UpdateSysPermissionDto>
    {
        private readonly IMediator _mediator;

        public SysPermissionsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
