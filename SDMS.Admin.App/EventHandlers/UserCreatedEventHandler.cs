using SDMS.Admin.Domain.DomainEvents;
using MediatR;
using PB22.Core.Outbox.Services;
using SDMS.Admin.App.Events;

namespace SDMS.Admin.App.EventHandlers;

public class UserCreatedEventHandler : INotificationHandler<UserCreatedEvent>
{
    private readonly IIntegrationEventService _integrationEventService;

    public UserCreatedEventHandler(IIntegrationEventService integrationEventService)
    {
        _integrationEventService = integrationEventService;
    }

    public async Task Handle(UserCreatedEvent notification, CancellationToken cancellationToken)
    {
        await _integrationEventService.AddAndSaveEventAsync(new UserCreated
        {
            UserId = notification.User.Id
        });
    }
}