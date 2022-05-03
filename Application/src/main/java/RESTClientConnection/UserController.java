package RESTClientConnection;

import Entities.Order;
import Entities.User;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.ArrayList;
import java.util.List;

@RestController
public class UserController {

    //Tested with client
    @GetMapping( "/users")
    public ResponseEntity<List<User>> GetAllOrders() {
        //Make connection to logic class
        User user1 = new User(1,"Test","Test1","Andrei","Ein","AndrEin@yahoo.com",1);
        User user2 = new User(2,"Duck","Test2","Johm","Ioanas","Johmio@yahoo.com",1);
        User user3 = new User(2,"fsdf","Test3","Andrei","Ioanas","Andrio@yahoo.com",1);
        User user4 = new User(2,"fdsfs","Test4","Vlad","Iaros","VladIaros@yahoo.com",1);
        List<User> placeholder = new ArrayList<>();
        placeholder.add(user1);placeholder.add(user2);placeholder.add(user3);placeholder.add(user4);
        System.out.println("GetAllOrders, ResponseEntity: "+ ResponseEntity.ok(placeholder));
        return new ResponseEntity<>(placeholder, HttpStatus.OK);
    }


    //Tested with client
    @PostMapping(value = "/user/add",consumes = "application/json",produces = "application/json")
    public ResponseEntity addUser(@RequestBody User user) {
        //Make connection to logic class
        User user1 = new User(user.getUserId(), user.getPassword(), user.getUsername(), user.getFirstName(), user.getLastName(),user.getEmail(),user.getSecurityLevel()+10);
        System.out.println("addOrder, ResponseEntity: "+ResponseEntity.ok(user1));
        return new ResponseEntity<User>(user1, HttpStatus.OK);

    }

    //Tested with client
    @GetMapping( "/{username}/user")
    public ResponseEntity<User> GetOrderByUsername(@PathVariable("username") String username) {
        //Make connection to logic class
        System.out.println("GetOrderById, orderId: "+ username);
        if(username.equals("test")){
            User user = new User(1,"test","test","Andrei","Ein","AndrEin@yahoo.com",1);
            return new ResponseEntity<User>(user, HttpStatus.OK);
        }else
            return new ResponseEntity<User>(HttpStatus.UNAUTHORIZED);

    }

    //Tested with client
    @GetMapping( "/id/{userId}/user")
    public ResponseEntity<User> GetOrderById(@PathVariable("userId") int OrderId) {
        //Make connection to logic class
        System.out.println("GetOrderById, orderId: "+ OrderId);
        User user = new User(1,"Test","Test1","Andrei","Ein","AndrEin@yahoo.com",1);
        return new ResponseEntity<User>(user, HttpStatus.OK);
    }

}
