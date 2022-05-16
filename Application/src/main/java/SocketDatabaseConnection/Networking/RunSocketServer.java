package SocketDatabaseConnection.Networking;

import Entities.Order;

public class RunSocketServer {
    public static void main(String[] args)
    {
        SocketServer socketServer = new SocketServer(new Order());
        socketServer.startServer();
    }
}
