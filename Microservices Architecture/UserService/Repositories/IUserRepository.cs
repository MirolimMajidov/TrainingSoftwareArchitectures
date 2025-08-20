using UserService.Models;

namespace UserService.Repositories;

public interface IUserRepository
{
    public List<User> GetUsers();
    
    public User GetUserById(int id);
    
    public void AddUser(User user);
}