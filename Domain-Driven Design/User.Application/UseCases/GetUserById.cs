using User.Domain.Repositories;

namespace User.Application.UseCases;

public class GetUserById (IUserRepository userRepository)
{
    public Domain.Models.User Execute(int id)
    {
        var user = userRepository.GetUserById(id);
        if (user == null)
            throw new ApplicationException($"User with id {id} was not found.");

        return user;
    }
}