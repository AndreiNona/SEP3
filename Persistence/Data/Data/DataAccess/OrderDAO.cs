using Data.Contracts;
using Data.Entities;

namespace Data.DataAccess;

public class OrderDAO : IOrderService
{
    private FileContext fileContext;

    public OrderDAO(FileContext fileContext)
    {
        this.fileContext = fileContext;
    }

    public async Task<ICollection<Order>> GetAsync()
    {
        ICollection<Order> todos = fileContext.Orders;
        return todos;
    }

    public async Task<Order> GetById(int id)
    {
        return fileContext.Orders.First(t => t.OrderId == id);
    }

    public async Task<Order> AddAsync(Order order)
    {
        int largestId = fileContext.Orders.Max(t => t.OrderId);
        int nextId = largestId + 1;
        order.OrderId = nextId;
        fileContext.Orders.Add(order);
        fileContext.SaveChanges();
        return order;
    }

    public async Task DeleteAsync(int id)
    {
        Order toDelete = fileContext.Orders.First(t => t.OrderId == id);
        fileContext.Orders.Remove(toDelete);
        fileContext.SaveChanges();
    }

    public async Task UpdateAsync(Order order)
    {
        Order toUpdate = fileContext.Orders.First(t => t.OrderId == order.OrderId);
        toUpdate.IsCompleted = order.IsCompleted;
        toUpdate.OrderId = order.OrderId;
        fileContext.SaveChanges();
    }
}