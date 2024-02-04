using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace b2b.App.NativeSocketServer
{
    public class Server
    { 
        private IPEndPoint _serverEndPoint1 = new IPEndPoint(IPAddress.Any, 11000);
        private IPEndPoint _serverEndPoint2 = new IPEndPoint(IPAddress.Any, 11001);
        private IPEndPoint _serverEndPoint3 = new IPEndPoint(IPAddress.Any, 11002);

        private Socket socket { get; set; }

        public Server() { }

        public async void InitServer()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            socket.Bind(_serverEndPoint1);
            socket.Listen(100);

            Console.WriteLine("server initialization completed");
            Console.WriteLine("waiting for connections ... ");
            
            while (true)
            {
                Socket client = socket.Accept();
                Console.WriteLine($"Адрес подключенного клиента: {client.RemoteEndPoint}");
            }

        }
    }
}
