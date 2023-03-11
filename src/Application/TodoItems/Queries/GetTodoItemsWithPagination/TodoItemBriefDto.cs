using CA.XUnit.Application.Common.Mappings;
using CA.XUnit.Domain.Entities;

namespace CA.XUnit.Application.TodoItems.Queries.GetTodoItemsWithPagination;

public class TodoItemBriefDto : IMapFrom<TodoItem>
{
    public int Id { get; set; }

    public int ListId { get; set; }

    public string? Title { get; set; }

    public bool Done { get; set; }
}
