using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatChargeMode;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatChargeModesController : BaseCQController<CatChargeMode, QueryCatChargeModeDto, CreateCatChargeModeDto, UpdateCatChargeModeDto>
    {
        private readonly IMediator _mediator;

        public CatChargeModesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
