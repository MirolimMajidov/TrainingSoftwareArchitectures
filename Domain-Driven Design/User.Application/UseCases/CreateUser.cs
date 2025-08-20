using User.Domain.DTOs;
using User.Domain.Repositories;

namespace User.Application.UseCases;

using User.Domain.Models;

public class CreateUser (IUserRepository userRepository)
{
    public void Execute(CreateUserRequest userRequest)
    {
        var user = User.Create(userRequest.Id, userRequest.FirstName, userRequest.LastName);
        userRepository.AddUser(user);
    }
}