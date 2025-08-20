using Microsoft.AspNetCore.Mvc;
using UserService.Models;
using UserService.Repositories;
using UserService.UseCases;

namespace UserService.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController() : ControllerBase
{
    [HttpGet]
    public IResult Get([FromServices] GetUsers useCase)
    {
        return useCase.Execute();
    }
    
    [HttpGet("GetById")]
    public IResult GetUserById(int id, [FromServices] GetUserById useCase)
    {
        return useCase.Execute(id);
    }
    
    [HttpPost]
    public IResult Create(User user, [FromServices] CreateUser useCase)
    {
        return useCase.Execute(user);
    }
}