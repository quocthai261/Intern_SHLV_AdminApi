using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatMarriage;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatMarriagesController : BaseCQController<CatMarriage, QueryCatMarriageDto, CreateCatMarriageDto, UpdateCatMarriageDto>
    {
        private readonly IMediator _mediator;

        public CatMarriagesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
