using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using OrderService.UseCases;

namespace OrderService.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController() : ControllerBase
{
    [HttpGet]
    public IResult Get([FromServices] GetOrders useCase)
    {
        return useCase.Execute();
    }
    
    [HttpGet("GetById")]
    public IResult GetUserById(int id, [FromServices] GetOrderById useCase)
    {
        return useCase.Execute(id);
    }
    
    [HttpPost]
    public IResult Create(Order order, [FromServices] CreateOrder useCase)
    {
        return useCase.Execute(order);
    }
}