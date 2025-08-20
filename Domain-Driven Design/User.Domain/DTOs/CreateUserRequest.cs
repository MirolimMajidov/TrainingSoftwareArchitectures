namespace User.Domain.DTOs;

public class CreateUserRequest
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}