using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatGender;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatGendersController : BaseCQController<CatGender, QueryCatGenderDto, CreateCatGenderDto, UpdateCatGenderDto>
    {
        private readonly IMediator _mediator;

        public CatGendersController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
