using UserService.Models;

namespace UserService.Repositories;

public class UserRepository: IUserRepository
{
    private static List<User> _users = new List<User>()
    {
        new User { Id = 1, FirstName = "John", LastName = "Doe" },
        new User { Id = 2, FirstName = "Jane", LastName = "Smith" },
        new User { Id = 3, FirstName = "Alice", LastName = "Johnson" }
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