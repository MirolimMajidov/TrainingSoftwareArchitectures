using Microsoft.AspNetCore.Mvc;
using UserService.Repositories;

namespace UserService.UseCases;

public class GetUsers (IUserRepository userRepository)
{
    public IResult Execute()
    {
        var users = userRepository.GetUsers();
        return Results.Ok(users);
    }
}