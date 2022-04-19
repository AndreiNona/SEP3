package RESTClientConnection;


import Contracts.IOrderService;
import Entities.Order;
import Logic.IOrderServiceImpl;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
public class OrderController  {

    @GetMapping("/orders")
    public ResponseEntity<Order> GetAllOrders() {
        //Make connection to logic class
        Order order = new Order(1,1,"Received",false);
        return new ResponseEntity<Order>(order, HttpStatus.OK);
    }


    @PostMapping("/orders")
    public String addOrder(@RequestBody Order order) {
        //Make connection to logic class
        System.out.println(order.toString());
        Order order1 = new Order(order.getOrderId(), order.getClientId(), order.getItem(),order.isISCompleted());
        return "Order has been successfully added !!" + order1.toString();

    }
    @GetMapping("/order")
    public ResponseEntity<Order> get() {
        //Make connection to logic class
        Order order = new Order(1,1,"Received",false);
        return new ResponseEntity<Order>(order, HttpStatus.OK);
    }


}
