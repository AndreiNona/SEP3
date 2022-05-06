package Entities;

import java.io.Serializable;
import java.util.List;

public class Order implements Serializable {
    private int orderId;
    private int clientId;
    private List<Product> _products;

    private boolean iscompleted;

    public Order() {}

    public Order(int orderId, int clientId,List<Product> _products,  boolean iscompleted) {
        this.orderId = orderId;
        this.clientId = clientId;
        this._products = _products;

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

    public List<Product> get_products() {
        return _products;
    }

    public void set_products(List<Product> _products) {
        this._products = _products;
    }

    public void add_product(Product product) {_products.add(product) ;}//Returns error

    public void remove_product(Product product) {_products.remove(product) ;}

    public boolean isIscompleted() {
        return iscompleted;
    }

    public void setIscompleted(boolean iscompleted) {
        this.iscompleted = iscompleted;
    }

    @Override
    public String toString() {
        return "Order{" +
                "orderId=" + orderId +
                ", clientId=" + clientId +
                ", _products=" + _products +
                ", iscompleted=" + iscompleted +
                '}';
    }
}
