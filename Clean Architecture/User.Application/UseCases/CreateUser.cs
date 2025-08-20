using User.Domain.Repositories;

namespace User.Application.UseCases;

public class CreateUser (IUserRepository userRepository)
{
    public void Execute(Domain.Models.User user)
    {
        userRepository.AddUser(user);
    }
}