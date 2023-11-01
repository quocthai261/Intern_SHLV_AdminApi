using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatDiagnosisGroup;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatDiagnosisGroupsController : BaseCQController<CatDiagnosisGroup, QueryCatDiagnosisGroupDto, CreateCatDiagnosisGroupDto, UpdateCatDiagnosisGroupDto>
    {
        private readonly IMediator _mediator;

        public CatDiagnosisGroupsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
