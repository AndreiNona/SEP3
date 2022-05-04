using System.Text;
using System.Text.Json;
using Contracts;
using Entities;

namespace RESTClient;

public class ProductHttpClientImpl : IProductService
{
    public async Task<IList<Product>> GetProductsAsync()
    {
        using HttpClient client = new ();
        HttpResponseMessage response = await client.GetAsync("http://localhost:9292/products");
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }

        IList<Product> products = JsonSerializer.Deserialize<IList<Product>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        Console.WriteLine("GetProductsAsync returned: " + products); //Console line
        return products;
    }

    public async Task<Product> GetProductById(int id)
    {
        using HttpClient client = new ();
        HttpResponseMessage response = await client.GetAsync($"http://localhost:9292/id/{id}/product");
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }

        Product product = JsonSerializer.Deserialize<Product>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        Console.WriteLine("GetProductById returned: " + product); //Console line
        return product;
    }

    public async Task AddProductAsync(Product product)
    {
        using HttpClient client = new ();
        //CamelCase for application 
        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        };
        string UserAsJson = JsonSerializer.Serialize(product,options);

        StringContent usercontent = new(UserAsJson, Encoding.UTF8, "application/json");
        
        HttpResponseMessage response = await client.PostAsync($"http://localhost:9292/product/add",usercontent);
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }
        Product returned = JsonSerializer.Deserialize<Product>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        
        Console.WriteLine("AddProductAsync returned: " + returned); //Console line
    }

    public Task DeleteProductAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProductAsync(Product product)
    {
        throw new NotImplementedException();
    }
}