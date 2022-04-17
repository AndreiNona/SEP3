using System.Text;
using System.Text.Json;
using Contracts;
using Entities;

namespace RESTClient;

public class OrderHttpClientImpl : IOrderService
{
    public async Task<ICollection<Order>> GetAllOrdersAsync()
    {
        using HttpClient client = new ();
        HttpResponseMessage response = await client.GetAsync("https://localhost:7211/Orders");
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }

        ICollection<Order> order = JsonSerializer.Deserialize<ICollection<Order>>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return order;
    }

    public async Task<Order> GetOrderById(int id)
    {
        
        using HttpClient client = new ();
        HttpResponseMessage response = await client.GetAsync($"https://localhost:7211/{id}/Order");
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }

        Order order = JsonSerializer.Deserialize<Order>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        return order;
    }

    public async Task AddOrderAsync(Order order)
    {
        
        using HttpClient client = new ();
        
        string postAsJson = JsonSerializer.Serialize(order);
        StringContent postcontent = new(postAsJson, Encoding.UTF8, "application/json");
        
        HttpResponseMessage response = await client.PostAsync($"https://localhost:7211/Order/Add",postcontent);
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }
        Order returned = JsonSerializer.Deserialize<Order>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        
    }

    public async Task DeleteOrderByIdAsync(int id)
    {
        using HttpClient client = new ();
        HttpResponseMessage response = await client.GetAsync($"https://localhost:7211/Order/{id}");
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }
    }

    public async Task UpdateOrderAsync(Order order)
    {
        using HttpClient client = new ();
        
        string OrderAsJson = JsonSerializer.Serialize(order);
        StringContent postcontent = new(OrderAsJson, Encoding.UTF8, "application/json");
        
        HttpResponseMessage response = await client.PostAsync($"https://localhost:7211/Order/update/",postcontent);
        string content = await response.Content.ReadAsStringAsync();

        if (!response.IsSuccessStatusCode)
        {
            throw new Exception($"Error: {response.StatusCode}, {content}");
        }
        Order returned = JsonSerializer.Deserialize<Order>(content, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        })!;
        
        Console.WriteLine("UpdateOrderAsync returned: " + returned); //Console line
    }
}