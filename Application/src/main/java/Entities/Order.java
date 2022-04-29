package Entities;

import java.io.Serializable;

public class Order implements Serializable {
    private int orderId;
    private int clientId;
    private String item;
    private boolean iscompleted;

    public Order() {}

    public Order(int orderId, int clientId, String item, boolean iscompleted) {
        this.orderId = orderId;
        this.clientId = clientId;
        this.item = item;
        this.iscompleted = iscompleted;
    }

    public int getOrderId() {
        return orderId;
    }

    public void setOrderId(int orderId) {
        this.orderId = orderId;
    }

    public int getClientId() {
        return clientId;
    }

    public void setClientId(int clientId) {
        this.clientId = clientId;
    }

    public String getItem() {
        return item;
    }

    public void setItem(String item) {
        this.item = item;
    }

    public boolean isIscompleted() {
        return iscompleted;
    }

    public void setIscompleted(boolean iscompleted) {
        this.iscompleted = iscompleted;
    }

    @Override
    public String toString() {
        return "Order{" +
                "OrderId=" + orderId +
                ", ClientId=" + clientId +
                ", Item='" + item + '\'' +
                ", ISCompleted=" + iscompleted +
                '}';
    }
}
