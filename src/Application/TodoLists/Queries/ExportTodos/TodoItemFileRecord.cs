using CA.XUnit.Application.Common.Mappings;
using CA.XUnit.Domain.Entities;

namespace CA.XUnit.Application.TodoLists.Queries.ExportTodos;

public class TodoItemRecord : IMapFrom<TodoItem>
{
    public string? Title { get; set; }

    public bool Done { get; set; }
}
