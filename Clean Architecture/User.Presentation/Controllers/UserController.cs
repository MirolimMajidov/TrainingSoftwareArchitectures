using Microsoft.AspNetCore.Mvc;
using User.Application.UseCases;

namespace User.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController() : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromServices] GetUsers useCase)
    {
        var users = useCase.Execute();
        return Ok(users);
    }
    
    [HttpGet("GetById")]
    public IActionResult GetUserById(int id, [FromServices] GetUserById useCase)
    {
        try
        {
            var user = useCase.Execute(id);
            return Ok(user);
        }
        catch (Exception e)
        {
            return NotFound(e.Message);
        }
    }
    
    [HttpPost]
    public IActionResult Create(User.Domain.Models.User user, [FromServices] CreateUser useCase)
    {
        useCase.Execute(user);
        
        return Ok("User created successfully.");
    }
}