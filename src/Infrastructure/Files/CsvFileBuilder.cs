using System.Globalization;
using CA.XUnit.Application.Common.Interfaces;
using CA.XUnit.Application.TodoLists.Queries.ExportTodos;
using CA.XUnit.Infrastructure.Files.Maps;
using CsvHelper;

namespace CA.XUnit.Infrastructure.Files;

public class CsvFileBuilder : ICsvFileBuilder
{
    public byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records)
    {
        using var memoryStream = new MemoryStream();
        using (var streamWriter = new StreamWriter(memoryStream))
        {
            using var csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);

            csvWriter.Context.RegisterClassMap<TodoItemRecordMap>();
            csvWriter.WriteRecords(records);
        }

        return memoryStream.ToArray();
    }
}
