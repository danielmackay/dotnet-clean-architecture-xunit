using CA.XUnit.Application.TodoLists.Queries.ExportTodos;

namespace CA.XUnit.Application.Common.Interfaces;

public interface ICsvFileBuilder
{
    byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
}
