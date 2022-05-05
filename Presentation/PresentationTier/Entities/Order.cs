namespace Entities;

public class Order
{


    public int orderId { get; set; }
    
    public int clientId { get; set; }
    public int Value{ get; set; }

    public IList<Product> _products{ get; set; }
    public string item { get; set; }
    
    public bool iscompleted { get; set; }
    
    public Order() { }
    
    public Order(int clientId, string item)
    {
        this.clientId = clientId;
        this.item = item;
    }

    public Order(IList<Product> products, int orderId, int clientId, int value, string item, bool iscompleted)
    {
        _products = products;
        this.orderId = orderId;
        this.clientId = clientId;
        Value = value;
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