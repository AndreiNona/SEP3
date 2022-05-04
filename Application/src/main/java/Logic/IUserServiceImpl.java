package Logic;

import Contracts.IUserService;
import Entities.User;

import java.util.ArrayList;

public class IUserServiceImpl implements IUserService {
    @Override
    public ArrayList<User> GetAllUsers() {
        return null;
    }

    @Override
    public User GetUserById(int id) {
        return null;
    }

    @Override
    public void AddUser(User user) {

    }

    @Override
    public void DeleteUserByIdAsync(int id) {

    }

    @Override
    public void UpdateUserAsync(User user) {

    }
}
