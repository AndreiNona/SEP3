using Entities;
using Microsoft.EntityFrameworkCore;

namespace EfcDataBase;

public class Context : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(@"Data Source = C:\Users\antom\RiderProjects\SEP3\Persistence\Data\EfcDataBase\Storage.db");
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>().HasKey(user => user.userId);
        modelBuilder.Entity<Product>().HasKey(product => product.productId);
        modelBuilder.Entity<Order>().HasKey(order => order.orderId);
        modelBuilder.Entity<Address>().HasKey(address => new{ address.firsLine, address.secondLine});
    }

    public void Seed()
    {
        Console.WriteLine("Seed accessed");

        User[] seedUsers =
        {
        new User(1,"Test","Test1","Andrei","Ein","AndrEin@yahoo.com",1),
        new User(2,"Duck","Test2","Johm","Ioanas","Johmio@yahoo.com",1),
        new User(3,"fsdf","Test3","Andrei","Ioanas","Andrio@yahoo.com",1),
        new User(4,"fdsfs","Test4","Vlad","Iaros","VladIaros@yahoo.com",1)
        };
        Console.WriteLine("Seed AddRange");
        Users.AddRange(seedUsers);
        Console.WriteLine("Seed SaveChanges");
        SaveChanges();
        
        //Add all a lot of random stuff here
    }
}