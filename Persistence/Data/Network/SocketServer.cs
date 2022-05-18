using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using Entities;

namespace Network;

public class SocketServer
{
    public SocketServer()
    {
    }

    public  void ExecuteServer(TcpListener listener)
{
    using TcpClient client = listener.AcceptTcpClient();

    Console.WriteLine("Client connected");
    NetworkStream stream = client.GetStream();

    // read
    byte[] dataFromClient = new byte[1024];
    int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
    string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
    

    // respond
    byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
    stream.Write(dataToClient, 0, dataToClient.Length);
    }
    
    private T Deserialize<T>(byte[] param)
    {
        using (MemoryStream ms = new MemoryStream(param))
        {
            IFormatter br = new BinaryFormatter();
            return (T)br.Deserialize(ms);
        }
    }
    
}
