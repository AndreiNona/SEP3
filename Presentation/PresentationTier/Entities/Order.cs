namespace Entities;

public class Order
{
    public int OrderId { get; set; }
    
    public int ClientId { get; set; }
    
    //public Item[] Items { get; set; }
    public string Item { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public Order() { }
    
    public Order(int clientId, string item)
    {
        ClientId = clientId;
        //Items = items;
        Item = item;
    }
}