using Contracts;
using Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace EfcDataBase.SqliteDAO;

public class ProductSqliteDAO : IProductService
{
    
    private readonly Context context;
    
    public ProductSqliteDAO(Context context)
    {
        this.context = context;
    }
    public async Task<IList<Product>> GetAllProductsAsync()
    {
        IList<Product> products = await context.Products.ToListAsync();
        return products; //Unsure if casting works
    }

    public async Task<Product> GetProductById(int id)
    {
        Product? product = await context.Products.FindAsync(id); //Works as long as the ID is a the only primary key for User
        return product;
    }

    public async Task AddProductAsync(Product product)
    {
        EntityEntry<Product> added = await context.AddAsync(product);
        await context.SaveChangesAsync();
        //return added.Entity; // For data about the result
    }

    public async Task DeleteProductByIdAsync(int id)
    {
        Product? existing = await context.Products.FindAsync(id);
        if (existing is null)
        {
            throw new Exception($"Could not find product with id {id}. Nothing was deleted");
        }

        context.Products.Remove(existing);
        await context.SaveChangesAsync();
    }

    public Task UpdateProductAsync(Product product)
    {
        context.Products.Update(product);
        return context.SaveChangesAsync();
    }
}