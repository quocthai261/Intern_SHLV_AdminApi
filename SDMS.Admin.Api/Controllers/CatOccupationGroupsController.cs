using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatOccupationGroup;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatOccupationGroupsController : BaseCQController<CatOccupationGroup, QueryCatOccupationGroupDto, CreateCatOccupationGroupDto, UpdateCatOccupationGroupDto>
    {
        private readonly IMediator _mediator;

        public CatOccupationGroupsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
