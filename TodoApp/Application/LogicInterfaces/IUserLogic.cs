using Domain.DTOs;
using Domain.Models;

namespace Application.LogicInterfaces;

public interface IUserLogic
{
    Task<User> CreateAsync(UserCreationDto userToCreate);
    Task<User?> GetByIdAsync(int id);
    Task<IEnumerable<User>> GetAsync(SearchUserParametersDto searchParameters);
}