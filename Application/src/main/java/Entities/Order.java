package Entities;

import java.io.Serializable;

public class Order implements Serializable {
    private int OrderId;
    private int ClientId;
    private String Item;
    private boolean ISCompleted;

    public Order() {}

    public Order(int orderId, int clientId, String item, boolean ISCompleted) {
        OrderId = orderId;
        ClientId = clientId;
        Item = item;
        this.ISCompleted = ISCompleted;
    }

    public int getOrderId() {
        return OrderId;
    }

    public void setOrderId(int orderId) {
        OrderId = orderId;
    }

    public int getClientId() {
        return ClientId;
    }

    public void setClientId(int clientId) {
        ClientId = clientId;
    }

    public String getItem() {
        return Item;
    }

    public void setItem(String item) {
        Item = item;
    }

    public boolean isISCompleted() {
        return ISCompleted;
    }

    public void setISCompleted(boolean ISCompleted) {
        this.ISCompleted = ISCompleted;
    }
}
