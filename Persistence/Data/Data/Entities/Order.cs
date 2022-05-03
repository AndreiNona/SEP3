using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Data.Entities;

public class Order
{   
    public int orderId { get; set; }
    
    public int clientId { get; set; }
    
    public string item { get; set; }
    
    public bool iscompleted { get; set; }
    
    public Order() { }
    
    public Order(int orderId, int clientId, string item, bool iscompleted)
    {
        this.orderId = orderId;
        this.clientId = clientId;
        this.item = item;
        this.iscompleted = iscompleted;
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