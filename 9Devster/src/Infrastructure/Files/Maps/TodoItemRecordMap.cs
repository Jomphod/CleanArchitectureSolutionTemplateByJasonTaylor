using System.Globalization;
using _9Devster.Application.TodoLists.Queries.ExportTodos;
using CsvHelper.Configuration;

namespace _9Devster.Infrastructure.Files.Maps;
public class TodoItemRecordMap : ClassMap<TodoItemRecord>
{
    public TodoItemRecordMap()
    {
        AutoMap(CultureInfo.InvariantCulture);

        Map(m => m.Done).Convert(c => c.Value.Done ? "Yes" : "No");
    }
}
