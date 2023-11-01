using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatOfficeBranch;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatOfficeBranchsController : BaseCQController<CatOfficeBranch, QueryCatOfficeBranchDto, CreateCatOfficeBranchDto, UpdateCatOfficeBranchDto>
    {
        private readonly IMediator _mediator;

        public CatOfficeBranchsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
