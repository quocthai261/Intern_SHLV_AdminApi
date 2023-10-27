using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatWard;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatWardsController : BaseCQController<CatWard, QueryCatWardDto, CreateCatWardDto, UpdateCatWardDto>
    {
        private readonly IMediator _mediator;

        public CatWardsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
