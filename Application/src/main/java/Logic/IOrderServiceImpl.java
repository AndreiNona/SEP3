package Logic;

import Contracts.IOrderService;
import Entities.Order;

import java.util.ArrayList;

public class IOrderServiceImpl implements IOrderService {
    @Override
    public ArrayList<Order> GetAllOrders() {
        return null;
    }

    @Override
    public Order GetOrderById(int id) {
        return null;
    }

    @Override
    public void AddOrder(Order order) {

    }

    @Override
    public void DeleteOrderByIdAsync(int id) {

    }

    @Override
    public void UpdateOrderAsync(Order order) {

    }
}
