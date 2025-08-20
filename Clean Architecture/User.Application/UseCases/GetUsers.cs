using User.Domain.Repositories;

namespace User.Application.UseCases;
using Domain.Models;

public class GetUsers (IUserRepository userRepository)
{
    public List<User> Execute()
    {
        var users = userRepository.GetUsers();
        return users;
    }
}