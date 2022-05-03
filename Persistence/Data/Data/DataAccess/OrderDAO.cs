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
        return fileContext.Orders.First(t => t.orderId == id);
    }

    public async Task<Order> AddAsync(Order order)
    {
        int largestId = fileContext.Orders.Max(t => t.orderId);
        int nextId = largestId + 1;
        order.orderId = nextId;
        fileContext.Orders.Add(order);
        fileContext.SaveChanges();
        return order;
    }

    public async Task DeleteAsync(int id)
    {
        Order toDelete = fileContext.Orders.First(t => t.orderId == id);
        fileContext.Orders.Remove(toDelete);
        fileContext.SaveChanges();
    }

    public async Task UpdateAsync(Order order)
    {
        Order toUpdate = fileContext.Orders.First(t => t.orderId == order.orderId);
        toUpdate.iscompleted = order.iscompleted;
        toUpdate.orderId = order.orderId;
        fileContext.SaveChanges();
    }
}