package SocketDatabaseConnection.Networking;

import Entities.Order;

import java.beans.PropertyChangeEvent;
import java.io.Console;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.net.Socket;
import java.util.List;

public class SocketHandler implements Runnable {

    private Socket socket;
    private Order order;

    private ObjectOutputStream outToClient;
    private ObjectInputStream inFromClient;

    public SocketHandler(Socket socket, Order order) {
        this.socket = socket;
        this.order = order;

        try {
            outToClient = new ObjectOutputStream(socket.getOutputStream());
            inFromClient = new ObjectInputStream(socket.getInputStream());
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    @Override
    public void run() {
        try {
            Order order = (Order) inFromClient.readObject();
            outToClient.writeObject(order.getOrderId());
            System.out.print("Server running test");
        } catch (IOException | ClassNotFoundException e) {
            e.printStackTrace();
        }
    }
}
