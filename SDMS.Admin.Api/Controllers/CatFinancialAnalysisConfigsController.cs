using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatFinancialAnalysisConfig;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatFinancialAnalysisConfigsController : BaseCQController<CatFinancialAnalysisConfig, QueryCatFinancialAnalysisConfigDto, CreateCatFinancialAnalysisConfigDto, UpdateCatFinancialAnalysisConfigDto>
    {
        private readonly IMediator _mediator;

        public CatFinancialAnalysisConfigsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
