using FSH.BackEnd.Shared.Events;

namespace FSH.BackEnd.Domain.Common.Contracts;

public abstract class DomainEvent : IEvent
{
    public DateTime TriggeredOn { get; protected set; } = DateTime.UtcNow;
}