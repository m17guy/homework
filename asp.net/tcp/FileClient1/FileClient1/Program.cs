using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace FileClient1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIR = 1;
            const int DOWNLOAD = 2;
            const int OK = 1;
            const int FAIL = 2;
            Console.WriteLine("What would you like to do:\n1. List server directory.\n2. Download file.");
            int action=int.Parse(Console.ReadLine());
            String fileName = "";
            if (action == DOWNLOAD)
            {
                Console.WriteLine("Please enter the name of the file to download");
                fileName = Console.ReadLine();
            }
            using (TcpClient client = new TcpClient("127.0.0.1", 50000))
            {
                NetworkStream ns = client.GetStream();
                BinaryWriter bw = new BinaryWriter(ns);
                BinaryReader br = new BinaryReader(ns);
                bw.Write(action);
                if (action == DOWNLOAD)
                    bw.Write(fileName);
                bw.Flush();
                if (action == DIR)
                {
                    int size=br.ReadInt32();
                    for (int i = 0; i < size; i++)
                        Console.WriteLine(br.ReadString());
                }
                if (action == DOWNLOAD)
                {
                    int result = br.ReadInt32();
                    if (result == FAIL)
                        Console.WriteLine("No such file on the server!");
                    else
                    {
                       string filePath = @"c:\down\" + fileName;   
                       using (FileStream fs = new FileStream(filePath, FileMode.Create))
                       {
                           int theByte;
                           while ((theByte = ns.ReadByte()) != -1)
                               fs.WriteByte((byte)theByte);
                       } 
                    }
                }
                bw.Close();
                br.Close();
            }
        }
    }
}
