using Entities;

namespace Contracts;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAllOrdersAsync();
    public Task<Order> GetOrderById(int id);
    public Task AddOrderAsync(Order order);
    public Task DeleteOrderByIdAsync(int id);
    public Task UpdateOrderAsync(Order order);
}