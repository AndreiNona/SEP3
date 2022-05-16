using Entities;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Network;

public class SocketClient : IClient
{
    public void startClient()
    {
        byte[] bytes = new byte[1024];

        try
        {
            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ipAddress = host.AddressList[0];
            IPEndPoint remoteEP = new IPEndPoint(ipAddress, 2910);
            
            Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            
            try
            {
                sender.Connect(remoteEP);

                Console.WriteLine("Socket connected to {0}", sender.RemoteEndPoint.ToString());
                
                // byte[] msg = Encoding.ASCII.GetBytes("This is a test<EOF>");
                //
                // int bytesSent = sender.Send(msg);
                //
                // int bytesRec = sender.Receive(bytes);
                // Console.WriteLine("Echoed test = {0}", Encoding.ASCII.GetString(bytes, 0, bytesRec));
                //
                // sender.Shutdown(SocketShutdown.Both);
                // sender.Close();
                
                // ObjectOutputStream outToServer = new ObjectOutputStream(socket.getOutputStream());
                // ObjectInputStream inFromServer = new ObjectInputStream(socket.getInputStream());
                //
                // new Thread(() -> listenToServer(outToServer, inFromServer)).start();
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("ArgumentNullException : {0}", ane.ToString());
            }
            catch (SocketException se)
            {
                Console.WriteLine("SocketException : {0}", se.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected exception : {0}", e.ToString());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.ToString());
        }
    }
    
    // private void listenToServer(ObjectOutputStream outToServer, ObjectInputStream inFromServer) {
    //     try {
    //      outToServer.writeObject(new Request("Listener", null));
    //      while (true) {
    //          Request request = (Request) inFromServer.readObject();
    //          support.firePropertyChange(request.getType(), null, request.getArg());
    //      }
    //     } catch (IOException | ClassNotFoundException e) {
    //      e.printStackTrace();
    //     }
    // }
    
    public Task<IList<Order>> GetAllOrdersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrderById(int id)
    {
        throw new NotImplementedException();
    }

    public Task AddOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrderByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrderAsync(Order order)
    {
        throw new NotImplementedException();
    }
}

// package socketsuppercase.client.network;
//
// import socketsuppercase.shared.transferobjects.LogEntry;
// import socketsuppercase.shared.transferobjects.Request;
//
// import java.beans.PropertyChangeListener;
// import java.beans.PropertyChangeSupport;
// import java.io.IOException;
// import java.io.ObjectInputStream;
// import java.io.ObjectOutputStream;
// import java.net.Socket;
// import java.util.List;
//
// public class SocketClient implements Client {
//
//     private PropertyChangeSupport support;
//
//     public SocketClient() {
//         support = new PropertyChangeSupport(this);
//     }
//
//     public void startClient() {
//         try {
//             Socket socket = new Socket("localhost", 2910);
//             ObjectOutputStream outToServer = new ObjectOutputStream(socket.getOutputStream());
//             ObjectInputStream inFromServer = new ObjectInputStream(socket.getInputStream());
//
//             new Thread(() -> listenToServer(outToServer, inFromServer)).start();
//
//         } catch (IOException e) {
//             e.printStackTrace();
//         }
//     }
//
//     private void listenToServer(ObjectOutputStream outToServer, ObjectInputStream inFromServer) {
//         try {
//             outToServer.writeObject(new Request("Listener", null));
//             while (true) {
//                 Request request = (Request) inFromServer.readObject();
//                 support.firePropertyChange(request.getType(), null, request.getArg());
//             }
//         } catch (IOException | ClassNotFoundException e) {
//             e.printStackTrace();
//         }
//     }
//
//     @Override
//     public String toUppercase(String str) {
//         try {
//             Request response = request(str, "Uppercase");
//             return (String)response.getArg();
//         } catch (IOException | ClassNotFoundException e) {
//             e.printStackTrace();
//         }
//         return str;
//     }
//
//     @Override
//     public List<LogEntry> getLog() {
//         try {
//             Request response = request(null, "FetchLog");
//             return (List<LogEntry>) response.getArg();
//         } catch (IOException | ClassNotFoundException e) {
//             e.printStackTrace();
//         }
//         return null;
//     }
//
//     private Request request(String arg, String type) throws IOException, ClassNotFoundException {
//         Socket socket = new Socket("localhost", 2910);
//         ObjectOutputStream outToServer = new ObjectOutputStream(socket.getOutputStream());
//         ObjectInputStream inFromServer = new ObjectInputStream(socket.getInputStream());
//         outToServer.writeObject(new Request(type, arg));
//         return (Request) inFromServer.readObject();
//     }
//
//     @Override
//     public void addListener(String eventName, PropertyChangeListener listener) {
//         support.addPropertyChangeListener(eventName, listener);
//     }
//
//     @Override
//     public void removeListener(String eventName, PropertyChangeListener listener) {
//         support.removePropertyChangeListener(eventName, listener);
//     }
// }
