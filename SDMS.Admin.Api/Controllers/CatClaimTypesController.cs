using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatClaimType;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatClaimTypesController : BaseCQController<CatClaimType, QueryCatClaimTypeDto, CreateCatClaimTypeDto, UpdateCatClaimTypeDto>
    {
        private readonly IMediator _mediator;

        public CatClaimTypesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
