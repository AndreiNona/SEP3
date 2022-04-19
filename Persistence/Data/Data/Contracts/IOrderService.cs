using Data.Entities;

namespace Data.Contracts;

public interface IOrderService
{
    public Task<ICollection<Order>> GetAsync();
    public Task<Order> GetById(int id);
    public Task<Order> AddAsync(Order order);
    public Task DeleteAsync(int id);
    public Task UpdateAsync(Order order);
}