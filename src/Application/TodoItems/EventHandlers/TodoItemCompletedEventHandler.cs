using CA.XUnit.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace CA.XUnit.Application.TodoItems.EventHandlers;

public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("CA.XUnit Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
