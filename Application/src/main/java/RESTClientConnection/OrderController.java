package RESTClientConnection;


import Entities.Order;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
public class OrderController  {

    //Tested with Client
    @GetMapping( "/orders")
    public ResponseEntity<List<Order>> GetAllOrders() {
        //Make connection to logic class
        Order order1 = new Order(1,1,null,"Wheel",false);
        Order order2 = new Order(2,1,null,"Right Break",false);
        Order order3 = new Order(3,2,null,"Left Break",false);
        Order order4 = new Order(4,2,null,"Seat",true);
        List<Order> placeholder = new ArrayList<>();
        placeholder.add(order1);placeholder.add(order2);placeholder.add(order3);placeholder.add(order4);
        System.out.println("GetAllOrders, ResponseEntity: "+ ResponseEntity.ok(placeholder));
        return new ResponseEntity<>(placeholder, HttpStatus.OK);
    }


    //Tested with client
    @PostMapping(value = "/order/add",consumes = "application/json",produces = "application/json")
    public ResponseEntity addOrder(@RequestBody Order order) {
        //Make connection to logic class
        Order order1 = new Order(order.getOrderId(), order.getClientId(),order.get_products(), order.getItem(),order.isIscompleted());
        System.out.println("addOrder, ResponseEntity: "+ResponseEntity.ok(order1));
        return new ResponseEntity<Order>(order1, HttpStatus.OK);

    }

    //Tested with Client
    @GetMapping( "/{OrderId}/order")
    public ResponseEntity<Order> GetOrderById(@PathVariable("OrderId") int OrderId) {
        //Make connection to logic class
        System.out.println("GetOrderById, orderId: "+ OrderId);
        Order order = new Order(OrderId,1,null,"OrderId: "+OrderId,false);
        return new ResponseEntity<Order>(order, HttpStatus.OK);
    }


}
