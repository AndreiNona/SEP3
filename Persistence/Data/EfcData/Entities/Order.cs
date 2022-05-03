using System.ComponentModel.DataAnnotations;

namespace EfcData.Entities;

public class Order
{
    [Key]
    public int orderId { get; set; }
    
    public int clientId { get; set; }
    
    //public Item[] Items { get; set; }
    public string item { get; set; }
    
    public bool iscompleted { get; set; }
    
    public Order() { }
    
    public Order(int clientId, string item)
    {
        this.clientId = clientId;
        //Items = items;
        this.item = item;
    }
    public override string ToString()
    {
        return "Order{" +
               "OrderId=" + orderId +
               ", ClientId=" + clientId +
               ", Item='" + item + '\'' +
               ", ISCompleted=" + iscompleted +
               '}';
    }
}