using FSH.BackEnd.Shared.Events;

namespace FSH.BackEnd.Application.Common.Events;

public interface IEventPublisher : ITransientService
{
    Task PublishAsync(IEvent @event);
}