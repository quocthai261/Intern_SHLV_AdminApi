using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatClaimStatus;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatClaimStatusesController : BaseCQController<CatClaimStatus, QueryCatClaimStatusDto, CreateCatClaimStatusDto, UpdateCatClaimStatusDto>
    {
        private readonly IMediator _mediator;

        public CatClaimStatusesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
