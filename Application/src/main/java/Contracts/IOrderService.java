package Contracts;

import Entities.Order;

import java.util.ArrayList;

public interface IOrderService {
    public ArrayList<Order> GetAllOrders();
    public Order GetOrderById(int id);
    public void AddOrder(Order order); //TODO
    public void DeleteOrderByIdAsync(int id);
    public void UpdateOrderAsync(Order order);
}
