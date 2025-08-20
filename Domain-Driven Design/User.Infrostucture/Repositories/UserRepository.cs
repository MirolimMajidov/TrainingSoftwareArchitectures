using User.Domain.Repositories;

namespace User.Infrostucture.Repositories;

using Domain.Models;

public class UserRepository: IUserRepository
{
    private static List<User> _users = new List<User>()
    {
        User.Create(1, "John", "Doe"),
        User.Create(2, "Jane", "Smith")
    };
    
    public List<User> GetUsers()
    {
        return _users;
    }

    public User GetUserById(int id)
    {
        return _users.FirstOrDefault(u=> u.Id == id);
    }

    public void AddUser(User user)
    {
        _users.Add(user);
    }
}