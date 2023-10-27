using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatBank;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatBanksController : BaseCQController<CatBank, QueryCatBankDto, CreateCatBankDto, UpdateCatBankDto>
    {
        private readonly IMediator _mediator;

        public CatBanksController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
