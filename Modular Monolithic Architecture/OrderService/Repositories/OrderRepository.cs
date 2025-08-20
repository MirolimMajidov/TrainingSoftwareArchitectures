using OrderService.Models;

namespace OrderService.Repositories;

public class OrderRepository: IOrderRepository
{
    private static List<Order> _items = new List<Order>()
    {
        new Order { Id = 1, Number = "11", UserName = "Doe" },
        new Order { Id = 2, Number = "22", UserName = "Smith" },
        new Order { Id = 3, Number = "33", UserName = "Johnson" }
    };
    
    public List<Order> GetOrders()
    {
        return _items;
    }

    public Order GetOrderById(int id)
    {
        return _items.FirstOrDefault(u=> u.Id == id);
    }

    public void AddOrder(Order order)
    {
        _items.Add(order);
    }
}