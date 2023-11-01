using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatIncome;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatIncomesController : BaseCQController<CatIncome, QueryCatIncomeDto, CreateCatIncomeDto, UpdateCatIncomeDto>
    {
        private readonly IMediator _mediator;

        public CatIncomesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
