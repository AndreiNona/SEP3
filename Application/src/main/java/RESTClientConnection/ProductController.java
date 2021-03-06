package RESTClientConnection;

import Entities.Order;
import Entities.Product;
import Entities.User;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
public class ProductController {

    //Tested with client
    @GetMapping( "/products")
    public ResponseEntity<List<Product>> GetAllProducts() {
        //Make connection to logic class
        Product Product1 = new Product(1,"Wheel front","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://www.cyclebrother.com/images/28099-3forhjul.jpg",100,100,10,90,90);
        Product Product2 = new Product(2,"Wheel back","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://www.cyclebrother.com/images/28099-3forhjul.jpg",300,150,10,120,120);
        Product Product3 = new Product(3,"Breaking front","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://sc01.alicdn.com/kf/HTB1J0vtLXXXXXXbXVXXq6xXFXXX9.jpg",600,70,5,15,25);
        Product Product4 = new Product(4,"Breaking back","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://sc01.alicdn.com/kf/HTB1J0vtLXXXXXXbXVXXq6xXFXXX9.jpg",700,75,10,20,30);
        List<Product> placeholder = new ArrayList<>();
        placeholder.add(Product1);placeholder.add(Product2);placeholder.add(Product3);placeholder.add(Product4);
        System.out.println("GetAllProducts, ResponseEntity: "+ ResponseEntity.ok(placeholder));
        return new ResponseEntity<>(placeholder, HttpStatus.OK);
    }

    //Tested with client
    @PostMapping(value = "/product/add",consumes = "application/json",produces = "application/json")
    public ResponseEntity addProduct(@RequestBody Product product) {
        //Make connection to logic class
        Product product1 = new Product(product.getProductId(),product.getName(), product.getDescription(), product.getUrl(), product.getValue(),product.getWeight(),product.getWidth(),product.getLength(),product.getHeight());
        System.out.println("addProduct, ResponseEntity: "+ResponseEntity.ok(product1));
        return new ResponseEntity<Product>(product1, HttpStatus.OK);
    }

    //Tested with client
    @GetMapping( "/id/{ProductId}/product")
    public ResponseEntity<Product> GetProductById(@PathVariable("ProductId") int ProductId) {
        //Make connection to logic class
        System.out.println("GetProductById, orderId: "+ ProductId);
        Product product = new Product(ProductId,"Test","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://sc01.alicdn.com/kf/HTB1J0vtLXXXXXXbXVXXq6xXFXXX9.jpg",999,999,999,999,1);
        return new ResponseEntity<Product>(product, HttpStatus.OK);
    }

    @DeleteMapping( "/id/{ProductId}/product/remove")
    public ResponseEntity DeleteProduct(@PathVariable("ProductId") int ProductId) {
        //Make connection to logic class
        System.out.println("DeleteProduct, removed product with id: "+ ProductId);
        return new ResponseEntity( HttpStatus.OK);
    }
    //Tested with Client
    @PatchMapping( "/product/update")
    public ResponseEntity UpdateProduct(@RequestBody Product product) {
        //Make connection to logic class
        System.out.println("UpdateProduct, updated to: "+ product.toString());
        return new ResponseEntity( HttpStatus.OK);
    }

    @PostMapping( "/product/{orderId}/addtocart")
    public ResponseEntity AddProductToCart(@PathVariable("orderId") int orderId,@RequestBody Product product) {
        //Make connection to logic class
        //Request order with orderId, update order to include the product
        Order order = new Order(orderId,1,null,false);
        order.add_product(product);
        System.out.println("AddProductToCart, product added to: "+ order.toString());
        return new ResponseEntity(order, HttpStatus.OK);
    }
}
