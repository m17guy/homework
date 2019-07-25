using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press ENTER to send byte");
            Console.ReadLine();
            using (TcpClient client = new TcpClient("127.0.0.1", 50000))
            {
                using (NetworkStream stream = client.GetStream())
                {
					
                    stream.WriteByte(100);
                    stream.Flush();
                }
            }
        }
    }
}
