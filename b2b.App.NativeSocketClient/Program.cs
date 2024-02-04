using System;
using System.Data;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace b2b.App.ClientNativeSocket
{
    public class Program
    {
        static void Main(string[] args)
        {
            Connect();
        }


        private static void Connect()
        {
            Socket tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            var host = "127.0.0.1";
            var port = 11000;
            try
            {
                tcpSocket.Connect(host, port);
                Console.WriteLine("Успех");
                Console.WriteLine($"{tcpSocket.RemoteEndPoint}");
                Console.WriteLine($"{tcpSocket.LocalEndPoint}");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
