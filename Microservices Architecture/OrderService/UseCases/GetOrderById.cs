using OrderService.Repositories;

namespace OrderService.UseCases;

public class GetOrderById (IOrderRepository orderRepository)
{
    public IResult Execute(int id)
    {
        var user = orderRepository.GetOrderById(id);
        if (user == null)
            return Results.NotFound($"Order with ID {id} not found.");

        return Results.Ok(user);
    }
}