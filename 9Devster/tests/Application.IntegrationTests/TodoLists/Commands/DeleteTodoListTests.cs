using _9Devster.Application.Common.Exceptions;
using _9Devster.Application.TodoLists.Commands.CreateTodoList;
using _9Devster.Application.TodoLists.Commands.DeleteTodoList;
using _9Devster.Domain.Entities;
using FluentAssertions;
using NUnit.Framework;

using static Testing;

namespace _9Devster.Application.IntegrationTests.TodoLists.Commands;
public class DeleteTodoListTests : BaseTestFixture
{
    [Test]
    public async Task ShouldRequireValidTodoListId()
    {
        var command = new DeleteTodoListCommand(99);
        await FluentActions.Invoking(() => SendAsync(command)).Should().ThrowAsync<NotFoundException>();
    }

    [Test]
    public async Task ShouldDeleteTodoList()
    {
        var listId = await SendAsync(new CreateTodoListCommand
        {
            Title = "New List"
        });

        await SendAsync(new DeleteTodoListCommand(listId));

        var list = await FindAsync<TodoList>(listId);

        list.Should().BeNull();
    }
}
