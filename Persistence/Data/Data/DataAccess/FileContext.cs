using System.Text.Json;
using Data.Entities;

namespace Data.DataAccess;

public class FileContext
{
    private string todoFilePath = "Orders.json";

    private ICollection<Order>? orders;

    public ICollection<Order> Orders
    {
        get
        {
            if (orders == null)
            {
                LoadData();
            }

            return orders!;
        }
    }

    public FileContext()
    {
        if (!File.Exists(todoFilePath))
        {
            Seed();
        }
    }

    private void Seed()
    {
        Order[] ts =
        {
            new Order(1, 1, "Item1",false),

            new Order(2, 2, "Item2",false),
 
            new Order(3, 3, "Item2",false),

            new Order(4,4 , "Item2",true),

            new Order(5, 5, "Item2",false),

        };
        orders = ts.ToList();
        SaveChanges();
    }

    public void SaveChanges()
    {
        string serialize = JsonSerializer.Serialize(Orders);
        File.WriteAllText(todoFilePath, serialize);
        orders = null;
    }

    private void LoadData()
    {
        string content = File.ReadAllText(todoFilePath);
        orders = JsonSerializer.Deserialize<List<Order>>(content);
    }
}