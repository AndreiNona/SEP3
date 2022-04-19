using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Data.Entities;

public class Order
{
    public int OrderId { get; set; }
    
    public int ClientId { get; set; }
    
    //public Item[] Items { get; set; }
    public string Item { get; set; }
    
    public bool IsCompleted { get; set; }
    
    public Order() { }
    
    public Order(int orderId, string item)
    {
        OrderId = orderId;
        //Items = items;
        Item = item;
    }
    public Order(int orderId,int clientId, string item,bool isCompleted)
    {
        orderId = orderId;
        ClientId = clientId;
        Item = item;
        isCompleted = isCompleted;
    }
    
}