using PB22.Core.Outbox.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDMS.Admin.App.Events
{
    public class AgentMoveTypeCreated : IntegrationEvent
    {
        public long AgentMoveTypeId { get; set; }
    }
}
