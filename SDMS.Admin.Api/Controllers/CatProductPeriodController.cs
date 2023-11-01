using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using PB22.Extensions.Minio.Operations;
using SDMS.Admin.App.Dtos.CatProductPeriod;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatProductPeriodController : BaseCQController<CatProductPeriod, QueryCatProductPeriodDto, CreateCatProductPeriodDto, UpdateCatProductPeriodDto>
    {
        private readonly IMediator _mediator;

        public CatProductPeriodController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
