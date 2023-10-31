using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysUser;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysUsersController : BaseCQController<SysUser, QuerySysUserDto, CreateSysUserDto, UpdateSysUserDto>
    {
        private readonly IMediator _mediator;

        public SysUsersController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
