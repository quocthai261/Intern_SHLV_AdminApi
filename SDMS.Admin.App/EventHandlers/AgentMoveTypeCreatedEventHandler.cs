using MediatR;
using PB22.Core.Outbox.Services;
using SDMS.Admin.App.Events;
using SDMS.Admin.Domain.DomainEvents;
using SDMS.Admin.Domain.DomainEvents.AgentMoveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.EventHandlers
{
    public class AgentMoveTypeCreatedEventHandler : INotificationHandler<AgentMoveTypeCreatedEvent>
    {
        private readonly IIntegrationEventService _integrationEventService;

        public AgentMoveTypeCreatedEventHandler(IIntegrationEventService integrationEventService)
        {
            _integrationEventService = integrationEventService;
        }
        public async Task Handle(AgentMoveTypeCreatedEvent notification, CancellationToken cancellationToken)
        {
            //error - /agent-move-types/create Sequence contains no matching element
            //await _integrationEventService.AddAndSaveEventAsync(new AgentMoveTypeCreated
            //{
            //    AgentMoveTypeId = notification.Entity.AgentMoveTypeId
            //});
        }
    }
}
