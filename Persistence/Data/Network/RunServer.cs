using System.Net;
using System.Net.Sockets;

namespace Network;

public class RunServer
{
    static void Main(string[] args)
    {
        
  
        SocketServer server = new SocketServer();
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        TcpListener listener = new TcpListener(ip, 2911);
        listener.Start();

        Console.WriteLine("Server started..");

        while (true)
        {
            server.ExecuteServer(listener);
        }
    }
}