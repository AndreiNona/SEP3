package Contracts;

import Entities.Product;

import java.util.ArrayList;

public interface IProductService {

    public ArrayList<Product> GetAllProducts();
    public Product GetProductById(int id);
    public void AddProduct(Product product); //TODO
    public void DeleteProductByIdAsync(int id);
    public void UpdateProductAsync(Product product);

}
