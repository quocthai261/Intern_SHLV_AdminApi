using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysUserLoginHistory;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysUserLoginHistoriesController : BaseCQController<SysUserLoginHistory, QuerySysUserLoginHistoryDto, CreateSysUserLoginHistoryDto, UpdateSysUserLoginHistoryDto>
    {
        private readonly IMediator _mediator;

        public SysUserLoginHistoriesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
