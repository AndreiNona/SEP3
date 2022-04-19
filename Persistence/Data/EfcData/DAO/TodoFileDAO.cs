using EfcData.Contracts;
using EfcData.Entities;

namespace EfcData;

public class TodoFileDAO : IOrderService
{
    private readonly TodoContext context;
    
    public TodoFileDAO(TodoContext context)
    {
        this.context = context;
    }
    public Task<ICollection<Order>> GetAllOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrderById(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }
}