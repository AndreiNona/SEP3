namespace Entities;

public class Product
{
    public int productId { get; set; }
    public string name { get; set; }
    public double value { get; set; }
    public double weight { get; set; }
    public double width { get; set; }
    public double length { get; set; }
    public double height { get; set; }

    public Product()
    {
    }

    public Product(int productId, string name, double value, double weight)
    {
        this.productId = productId;
        this.name = name;
        this.value = value;
        this.weight = weight;
    }

    public Product(string name, double value, double weight, double width, double lenght, double height)
    {
        this.name = name;
        this.value = value;
        this.weight = weight;
        this.width = width;
        this.length = lenght;
        this.height = height;

    }
}