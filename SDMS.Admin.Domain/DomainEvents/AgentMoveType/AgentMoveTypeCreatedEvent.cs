using MediatR;
using PB22.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.DomainEvents.AgentMoveType
{
    public class AgentMoveTypeCreatedEvent : INotification, IAddObjectEvent
    {
        public Entities.AgentMoveType Entity { get; }

        public AgentMoveTypeCreatedEvent(Entities.AgentMoveType entity)
        {
            Entity = entity;
        }
    }
}
