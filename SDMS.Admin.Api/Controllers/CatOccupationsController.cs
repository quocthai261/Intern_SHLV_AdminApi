using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatOccupation;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatOccupationsController : BaseCQController<CatOccupation, QueryCatOccupationDto, CreateCatOccupationDto, UpdateCatOccupationDto>
    {
        private readonly IMediator _mediator;

        public CatOccupationsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
