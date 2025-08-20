namespace User.Domain.Repositories;
using Models;

public interface IUserRepository
{
    public List<User> GetUsers();
    
    public User GetUserById(int id);
    
    public void AddUser(User user);
}