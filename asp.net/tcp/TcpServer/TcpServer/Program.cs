using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace TcpServer
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener server = new TcpListener(IPAddress.Any, 50000);
            server.Start();

            using (TcpClient serverClient = server.AcceptTcpClient())
            {
                using (NetworkStream stream = serverClient.GetStream())
                {
                    Console.WriteLine(stream.ReadByte());
                }
            }
            server.Stop();
        }
    }
}
