namespace User.Domain.Models;

public class User : IAggregate
{
    private User()
    {
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    
    public UserDocument Document { get; set; }

    public static User Create(int userId, string firstName, string lastName)
    {
        if(userId<0)
            throw new ArgumentException("User ID cannot be negative.", nameof(userId));
        
        if(string.IsNullOrWhiteSpace(firstName))
            throw new ArgumentException("First name cannot be null or empty.", nameof(firstName));
        
        return new User
        {
            Id = userId,
            FirstName = firstName,
            LastName = lastName
        };
    }
    
    public UserDocument AddDocument(string number, string type)
    {
        if(string.IsNullOrWhiteSpace(number))
            throw new ArgumentException("Document number cannot be null or empty.", nameof(number));
        
        if(string.IsNullOrWhiteSpace(type))
            throw new ArgumentException("Document type cannot be null or empty.", nameof(type));

        var document = new UserDocument
        {
            UserId = Id,
            User = this,
            Number = number,
            Type = type
        };

        return document;
    }
}