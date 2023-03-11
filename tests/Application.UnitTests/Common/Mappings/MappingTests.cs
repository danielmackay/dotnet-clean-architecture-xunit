using System.Runtime.Serialization;
using AutoMapper;
using CA.XUnit.Application.Common.Mappings;
using CA.XUnit.Application.Common.Models;
using CA.XUnit.Application.TodoLists.Queries.GetTodos;
using CA.XUnit.Domain.Entities;
using Xunit;

namespace CA.XUnit.Application.UnitFacts.Common.Mappings;

public class MappingFacts
{
    private readonly IConfigurationProvider _configuration;
    private readonly IMapper _mapper;

    public MappingFacts()
    {
        _configuration = new MapperConfiguration(config => 
            config.AddProfile<MappingProfile>());

        _mapper = _configuration.CreateMapper();
    }

    [Fact]
    public void ShouldHaveValidConfiguration()
    {
        _configuration.AssertConfigurationIsValid();
    }

    [Theory]
    [InlineData(typeof(TodoList), typeof(TodoListDto))]
    [InlineData(typeof(TodoItem), typeof(TodoItemDto))]
    [InlineData(typeof(TodoList), typeof(LookupDto))]
    [InlineData(typeof(TodoItem), typeof(LookupDto))]
    public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
    {
        var instance = GetInstanceOf(source);

        _mapper.Map(instance, source, destination);
    }

    private object GetInstanceOf(Type type)
    {
        if (type.GetConstructor(Type.EmptyTypes) != null)
            return Activator.CreateInstance(type)!;

        // Type without parameterless constructor
        return FormatterServices.GetUninitializedObject(type);
    }
}
