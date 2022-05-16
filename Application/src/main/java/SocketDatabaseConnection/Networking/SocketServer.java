package SocketDatabaseConnection.Networking;

import Entities.Order;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class SocketServer {

    private Order order;

    public SocketServer(Order order) {
        this.order = order;
    }

    public void startServer() {
        try {
            ServerSocket welcomeSocket = new ServerSocket(2910);

            while(true) {
                Socket socket = welcomeSocket.accept();
                new Thread(new SocketHandler(socket, order)).start();
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}
