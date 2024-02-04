using System;

namespace b2b.App.NativeSocketServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var server = new Server();
            server.InitServer();
        }
    }
}
