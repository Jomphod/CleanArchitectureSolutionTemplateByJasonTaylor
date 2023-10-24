using _9Devster.Application.TodoLists.Queries.ExportTodos;

namespace _9Devster.Application.Common.Interfaces;
public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
