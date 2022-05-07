package RESTClientConnection;


import Entities.Order;
import Entities.Product;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;
import java.util.function.Predicate;

@RestController
public class OrderController  {

    //Tested with Client
    @GetMapping( "/orders")
    public ResponseEntity<List<Order>> GetAllOrders() {
        //Make connection to logic class IOrderServiceImpl OrderService; OrderService.GetAllOrders();
        Product Product1 = new Product(1,"Wheel front","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://www.cyclebrother.com/images/28099-3forhjul.jpg",100,100,10,90,90);
        Product Product2 = new Product(2,"Wheel back","Lorem ipsum dolor sit amet, consectetur adipiscing elit","https://www.cyclebrother.com/images/28099-3forhjul.jpg",300,150,10,120,120);

        Order order1 = new Order(1,1,null,true);
       Order order2 = new Order(2,1,null,true);
        Order order3 = new Order(3,2,null,true);
        Order order4 = new Order(4,2,null,false);
        List<Product> productList = new ArrayList<>();
        productList.add(Product1);
        order1.set_products(productList);
        order2.set_products(productList);
        order3.set_products(productList);
        productList.add(Product2);
        order4.set_products(productList);
        List<Order> placeholder = new ArrayList<>();
        placeholder.add(order1);placeholder.add(order2);placeholder.add(order3);placeholder.add(order4);
        System.out.println("GetAllOrders, ResponseEntity: "+ ResponseEntity.ok(placeholder));
        return new ResponseEntity<>(placeholder, HttpStatus.OK);
    }


    //Tested with client
    @PostMapping(value = "/order/add",consumes = "application/json",produces = "application/json")
    public ResponseEntity addOrder(@RequestBody Order order) {
        //Make connection to logic class
        Order order1 = new Order(order.getOrderId(), order.getClientId(), order.get_products(),order.isIscompleted());
        System.out.println("addOrder, ResponseEntity: "+ResponseEntity.ok(order1));
        return new ResponseEntity<Order>(order1, HttpStatus.OK);
    }

    //Tested with Client
    @GetMapping( "/{OrderId}/order")
    public ResponseEntity<Order> GetOrderById(@PathVariable("OrderId") int OrderId) {
        //Make connection to logic class
        System.out.println("GetOrderById, orderId: "+ OrderId);
        Order order = new Order(OrderId,1,null,false);
        return new ResponseEntity<Order>(order, HttpStatus.OK);
    }

    //Tested with Client
    @PatchMapping( "/order/update")
    public ResponseEntity UpdateOrder(@RequestBody Order order) {
        //Make connection to logic class
        Order order1 = new Order(order.getOrderId(),order.getClientId(), order.get_products(), order.isIscompleted());
        System.out.println("UpdateOrder, orderId: "+ order1);
        return new ResponseEntity(order1, HttpStatus.OK);
    }
    //Tested with client
    @PostMapping(value = "/order/purchase",consumes = "application/json",produces = "application/json")
    public ResponseEntity RequestPurchase(@RequestBody Order order) {
        //Make connection to logic class
        System.out.println("RequestPurchase, Requested purchase for: "+order.toString());
        return new ResponseEntity<Order>(HttpStatus.OK);

    }
}
