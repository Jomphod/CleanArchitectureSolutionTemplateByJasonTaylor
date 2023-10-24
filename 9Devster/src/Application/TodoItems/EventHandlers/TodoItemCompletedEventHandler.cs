using _9Devster.Domain.Events;
using MediatR;
using Microsoft.Extensions.Logging;

namespace _9Devster.Application.TodoItems.EventHandlers;
public class TodoItemCompletedEventHandler : INotificationHandler<TodoItemCompletedEvent>
{
    private readonly ILogger<TodoItemCompletedEventHandler> _logger;

    public TodoItemCompletedEventHandler(ILogger<TodoItemCompletedEventHandler> logger)
    {
        _logger = logger;
    }

    public Task Handle(TodoItemCompletedEvent notification, CancellationToken cancellationToken)
    {
        _logger.LogInformation("_9Devster Domain Event: {DomainEvent}", notification.GetType().Name);

        return Task.CompletedTask;
    }
}
