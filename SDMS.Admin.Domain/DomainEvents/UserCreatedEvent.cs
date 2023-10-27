using MediatR;
using PB22.Core.Database;
using SysUser = SDMS.Admin.Domain.Entities.SysUser;

namespace SDMS.Admin.Domain.DomainEvents;

public class UserCreatedEvent : INotification, IAddObjectEvent
{
    public Entities.SysUser User { get; }

    public UserCreatedEvent(Entities.SysUser user)
    {
        User = user;
    }
}