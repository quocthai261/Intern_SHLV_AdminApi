using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatPolicyStatus;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatPolicyStatusesController : BaseCQController<CatPolicyStatus, QueryCatPolicyStatusDto, CreateCatPolicyStatusDto, UpdateCatPolicyStatusDto>
    {
        private readonly IMediator _mediator;

        public CatPolicyStatusesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
