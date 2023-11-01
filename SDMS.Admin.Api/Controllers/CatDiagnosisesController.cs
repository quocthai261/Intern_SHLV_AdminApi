using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatDiagnosis;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatDiagnosisesController : BaseCQController<CatDiagnosis, QueryCatDiagnosisDto, CreateCatDiagnosisDto, UpdateCatDiagnosisDto>
    {
        private readonly IMediator _mediator;

        public CatDiagnosisesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
