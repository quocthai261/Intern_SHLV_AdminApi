using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatBankBranch;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatBankBranchsController : BaseCQController<CatBankBranch, QueryCatBankBranchDto, CreateCatBankBranchDto, UpdateCatBankBranchDto>
    {
        private readonly IMediator _mediator;

        public CatBankBranchsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
