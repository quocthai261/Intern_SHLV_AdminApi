using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatEmailTemplate;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatEmailTemplatesController : BaseCQController<CatEmailTemplate, QueryCatEmailTemplateDto, CreateCatEmailTemplateDto, UpdateCatEmailTemplateDto>
    {
        private readonly IMediator _mediator;

        public CatEmailTemplatesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
