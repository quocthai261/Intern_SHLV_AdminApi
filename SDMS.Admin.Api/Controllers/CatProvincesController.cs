using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using PB22.Extensions.Minio.Operations;
using SDMS.Admin.Api.Dtos.CatProvince;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatProvincesController : BaseCQController<CatProvince, QueryCatProvinceDto, CreateCatProvinceDto, UpdateCatProvinceDto>
    {
        private readonly IMediator _mediator;

        public CatProvincesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
