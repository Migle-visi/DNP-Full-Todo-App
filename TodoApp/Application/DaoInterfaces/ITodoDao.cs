using Domain.DTOs;
using Domain.Models;

namespace Application.DaoInterfaces;

public interface ITodoDao
{
    Task<Todo> CreateAsync(Todo todo);
    Task<IEnumerable<Todo>> GetAsync(SearchTodoParametersDto searchParameters);
    Task UpdateAsync(Todo todo);
    Task<Todo?> GetByIdAsync(int todoId);
    
    //method not necessarry to filter it in the table view
    Task<IEnumerable<Todo>> GetTodosByUserIdAsync(int id);
    Task DeleteAsync(int id);
    
}