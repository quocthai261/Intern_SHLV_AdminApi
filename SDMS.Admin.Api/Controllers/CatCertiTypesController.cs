using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatCertiType;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatCertiTypesController : BaseCQController<CatCertiType, QueryCatCertiTypeDto, CreateCatCertiTypeDto, UpdateCatCertiTypeDto>
    {
        private readonly IMediator _mediator;

        public CatCertiTypesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
