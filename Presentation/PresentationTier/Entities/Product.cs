namespace Entities;

public class Product
{
    public string name { get; set; }
    public double value { get; set; }
    public double weight { get; set; }
    public double[] VolumeWidthLenghtHeight { get; set; }

    public Product(){}
    
    public Product(string name, double value, double weight, double[] volumeWidthLenghtHeight)
    {
        this.name = name;
        this.value = value;
        this.weight = weight;
        VolumeWidthLenghtHeight = volumeWidthLenghtHeight;
    }
}