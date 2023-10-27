using MediatR;
using PB22.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.Domain.DomainEvents.AgentMoveType
{
    public class AgentMoveTypeUpdatedEvent : INotification, IAddObjectEvent
    {
        public Entities.AgentMoveType Entity { get; }

        public AgentMoveTypeUpdatedEvent(Entities.AgentMoveType entity)
        {
            Entity = entity;
        }
    }
}
