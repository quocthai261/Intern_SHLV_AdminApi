using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SysMobileMenu;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SysMobileMenusController : BaseCQController<SysMobileMenu, QuerySysMobileMenuDto, CreateSysMobileMenuDto, UpdateSysMobileMenuDto>
    {
        private readonly IMediator _mediator;

        public SysMobileMenusController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
