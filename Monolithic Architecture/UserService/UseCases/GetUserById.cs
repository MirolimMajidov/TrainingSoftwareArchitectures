using UserService.Repositories;

namespace UserService.UseCases;

public class GetUserById (IUserRepository userRepository)
{
    public IResult Execute(int id)
    {
        var user = userRepository.GetUserById(id);
        if (user == null)
            return Results.NotFound($"User with ID {id} not found.");

        return Results.Ok(user);
    }
}