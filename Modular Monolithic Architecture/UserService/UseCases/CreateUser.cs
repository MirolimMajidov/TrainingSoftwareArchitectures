using UserService.Models;
using UserService.Repositories;

namespace UserService.UseCases;

public class CreateUser (IUserRepository userRepository)
{
    public IResult Execute(User user)
    {
        userRepository.AddUser(user);
        
        return Results.Ok("User created successfully.");
    }
}