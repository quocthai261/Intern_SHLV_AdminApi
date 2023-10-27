using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatDistrict;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatDistrictsController : BaseCQController<CatDistrict,QueryCatDistrictDto, CreateCatDistrictDto, UpdateCatDistrictDto>
    {
        private readonly IMediator _mediator;

        public CatDistrictsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
