using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatProductStatus;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatProductStatusesController : BaseCQController<CatProductStatus, QueryCatProductStatusDto, CreateCatProductStatusDto, UpdateCatProductStatusDto>
    {
        private readonly IMediator _mediator;

        public CatProductStatusesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
