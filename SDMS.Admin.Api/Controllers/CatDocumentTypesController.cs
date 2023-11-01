using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatDocumentType;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatDocumentTypesController : BaseCQController<CatDocumentType, QueryCatDocumentTypeDto, CreateCatDocumentTypeDto, UpdateCatDocumentTypeDto>
    {
        private readonly IMediator _mediator;

        public CatDocumentTypesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
