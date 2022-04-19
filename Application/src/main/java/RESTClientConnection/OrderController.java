package RESTClientConnection;


import Entities.Order;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/data")
public class OrderController {

    @GetMapping("/order")
    public ResponseEntity<Order> get() {
        Order order = new Order(1,1,"Received",false);
        return new ResponseEntity<Order>(order, HttpStatus.OK);
    }


}
