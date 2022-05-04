package Contracts;

import Entities.Order;
import Entities.User;

import java.util.ArrayList;

public interface IUserService {
    public ArrayList<User> GetAllUsers();
    public User GetUserById(int id);
    public void AddUser(User user); //TODO
    public void DeleteUserByIdAsync(int id);
    public void UpdateUserAsync(User user);
}
