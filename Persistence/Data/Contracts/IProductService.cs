using Entities;

namespace Contracts;

public interface IProductService
{
    public Task<IList<Product>> GetAllProductsAsync();
    public Task<Product> GetProductById(int id);
    public Task AddProductAsync(Product product);
    public Task DeleteProductByIdAsync(int id);
    public Task UpdateProductAsync(Product product);
}