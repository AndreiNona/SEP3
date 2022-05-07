package Entities;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

public class Order implements Serializable {
    private int orderId;
    private int clientId;
    private int value;
    protected  List<Product> _products;
    private boolean iscompleted;

    public Order() {}

    public Order(int orderId, int clientId,List<Product> _products,  boolean iscompleted) {
        this.orderId = orderId;
        this.clientId = clientId;
        this._products = _products;
        if(_products != null){
            this._products = _products;
            calculateValue();
        } else{
            _products = new ArrayList<Product>();
            value=0;
        }

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

    public int getValue() {
        return value;
    }

    public void setValue(int value) {
        this.value = value;
    }

    public List<Product> get_products() {
        return _products;
    }

    public void set_products(List<Product> _products) {
        this._products = _products;
        calculateValue();
    }

    public void add_product(Product product) {

        if(_products== null){
            List<Product> productList = new ArrayList<>();
            productList.add(product);
            set_products(productList);
        }else{
            _products.add(product);
            value+=product.getValue();
        }

    }//Returns error when using List.add(product)

    public void remove_product(Product product) {_products.remove(product) ;}

    public boolean isIscompleted() {
        return iscompleted;
    }

    public void setIscompleted(boolean iscompleted) {
        this.iscompleted = iscompleted;
    }
    public void calculateValue( ) {
        value=0;
        for (Product p:_products) {
            value+=p.getValue();
        }
    }
    @Override
    public String toString() {
        return "Order{" +
                "orderId=" + orderId +
                ", clientId=" + clientId +
                ", value=" + value +
                ", _products=" + _products +
                ", iscompleted=" + iscompleted +
                '}';
    }
}
