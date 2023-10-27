using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatNationality;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatNationalitiesController : BaseCQController<CatNationality, QueryCatNationalityDto, CreateCatNationalityDto, UpdateCatNationalityDto>
    {
        private readonly IMediator _mediator;

        public CatNationalitiesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
