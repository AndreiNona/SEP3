package Entities;

public class Product {
    private int productId;
    private String name;
    private double value;
    private double weight;
    private double width, length,height;

    public Product() {
    }

    public Product(int productId, String name, double value, double weight) {
        this.productId = productId;
        this.name = name;
        this.value = value;
        this.weight = weight;
    }

    public Product(int productId, String name, double value, double weight, double width, double lenght, double height) {
        this.productId = productId;
        this.name = name;
        this.value = value;
        this.weight = weight;
        this.width = width;
        this.length = lenght;
        this.height = height;
    }

    public int getProductId() {
        return productId;
    }

    public void setProductId(int productId) {
        this.productId = productId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public double getValue() {
        return value;
    }

    public void setValue(double value) {
        this.value = value;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        this.width = width;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    @Override
    public String toString() {
        return "Product{" +
                "productId=" + productId +
                ", name='" + name + '\'' +
                ", value=" + value +
                ", weight=" + weight +
                ", width=" + width +
                ", length=" + length +
                ", height=" + height +
                '}';
    }
}
