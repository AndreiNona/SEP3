using EfcData.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfcData;

public class TodoContext : DbContext
{
    public DbSet<Order> order { get; set; }
    private ICollection<Order> orders;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = Data.db");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>().HasKey(todo => todo.orderId);
    }
    public void Seed()
    {
        if (orders.Any()) return;

        Order[] ts =
        {
            new Order(1, "Dishes"),
            new Order(1, "Walk the dog"),
            new Order(2, "Do DNP homework"),
            new Order(3, "Eat breakfast"),
            new Order(4, "Mow lawn"),
        };
       // orders.AddRange(ts);
        SaveChanges();
    }
}