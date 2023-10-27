using PB22.Core.Outbox.Events;

namespace SDMS.Admin.App.Events;

public class UserCreated : IntegrationEvent
{
    public long UserId { get; set; }
}