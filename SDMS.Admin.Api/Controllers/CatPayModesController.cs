using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using PB22.Extensions.Minio.Operations;
using SDMS.Admin.App.Dtos.CatPayMode;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatPayModesController : BaseCQController<CatPayMode, QueryCatPayModeDto, CreateCatPayModeDto, UpdateCatPayModeDto>
    {
        private readonly IMediator _mediator;

        public CatPayModesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
