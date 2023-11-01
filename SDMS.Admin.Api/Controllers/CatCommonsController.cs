using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatCommon;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatCommonsController : BaseCQController<CatCommon, QueryCatCommonDto, CreateCatCommonDto, UpdateCatCommonDto>
    {
        private readonly IMediator _mediator;

        public CatCommonsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
