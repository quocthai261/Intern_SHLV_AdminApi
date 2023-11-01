using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatHospital;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatHospitalController : BaseCQController<CatHospital, QueryCatHospitalDto, CreateCatHospitalDto, UpdateCatHospitalDto>
    {
        private readonly IMediator _mediator;

        public CatHospitalController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
