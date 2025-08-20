using Microsoft.AspNetCore.Mvc;
using User.Application.UseCases;
using User.Domain.DTOs;

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
    public IActionResult Create(CreateUserRequest user, [FromServices] CreateUser useCase)
    {
        useCase.Execute(user);
        
        return Ok("User created successfully.");
    }
}