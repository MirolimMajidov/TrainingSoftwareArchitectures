using OrderService.Repositories;

namespace OrderService.UseCases;

public class GetOrders (IOrderRepository orderRepository)
{
    public IResult Execute()
    {
        var users = orderRepository.GetOrders();
        return Results.Ok(users);
    }
}