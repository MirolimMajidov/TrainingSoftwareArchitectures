using OrderService.Models;
using OrderService.Repositories;

namespace OrderService.UseCases;

public class CreateOrder (IOrderRepository orderRepository)
{
    public IResult Execute(Order order)
    {
        orderRepository.AddOrder(order);
        
        return Results.Ok("User created successfully.");
    }
}