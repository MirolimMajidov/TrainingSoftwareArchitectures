using OrderService.Models;

namespace OrderService.Repositories;

public interface IOrderRepository
{
    public List<Order> GetOrders();
    
    public Order GetOrderById(int id);
    
    public void AddOrder(Order order);
}