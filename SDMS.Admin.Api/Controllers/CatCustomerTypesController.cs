using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.CatCustomerType;
using SDMS.Admin.Domain.Entities;

namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CatCustomerTypesController : BaseCQController<CatCustomerType, QueryCatCustomerTypeDto, CreateCatCustomerTypeDto, UpdateCatCustomerTypeDto>
    {
        private readonly IMediator _mediator;

        public CatCustomerTypesController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
