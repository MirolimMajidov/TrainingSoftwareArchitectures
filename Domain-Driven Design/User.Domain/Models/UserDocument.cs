namespace User.Domain.Models;

public class UserDocument
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
    public string Number { get; set; }
    public string Type { get; set; }
}