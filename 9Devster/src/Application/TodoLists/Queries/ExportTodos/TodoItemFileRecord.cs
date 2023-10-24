using _9Devster.Application.Common.Mappings;
using _9Devster.Domain.Entities;

namespace _9Devster.Application.TodoLists.Queries.ExportTodos;
public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; init; }

    public bool Done { get; init; }
}
