using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatRelation;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatRelationsController : BaseCQController<CatRelation, QueryCatRelationDto, CreateCatRelationDto, UpdateCatRelationDto>
    {
        private readonly IMediator _mediator;

        public CatRelationsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
