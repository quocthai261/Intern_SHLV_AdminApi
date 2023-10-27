using MediatR;
using Microsoft.AspNetCore.Mvc;
using PB22.Extend.Api.Controllers;
using SDMS.Admin.App.Dtos.SyncJob;
using SDMS.Admin.Domain.Entities;
namespace SDMS.Admin.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SyncJobsController : BaseCQController<SyncJob,QuerySyncJobDto, CreateSyncJobDto, UpdateSyncJobDto>
    {
        private readonly IMediator _mediator;

        public SyncJobsController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
    }
}
