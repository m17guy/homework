using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
namespace FileServer1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int DIR = 1;
            const int DOWNLOAD = 2;
            const int OK=1;
            const int FAIL=2;
            TcpListener server = new TcpListener(IPAddress.Any, 50000);
            server.Start();
            while (true)
            {
                using (TcpClient serverClient = server.AcceptTcpClient())
                {
                    NetworkStream ns = serverClient.GetStream();
                    BinaryWriter bw = new BinaryWriter(ns);
                    BinaryReader br = new BinaryReader(ns);
                    int action = br.ReadInt32();
                    if (action == DIR)
                    {
                        string[] fileNames = Directory.GetFiles(@"C:\Users\hackeru\Downloads");
                        bw.Write(fileNames.Length);
                        bw.Flush();
                        foreach (string file in fileNames)
                          bw.Write(Path.GetFileName(file));
                        bw.Flush();

                    }
                    if (action == DOWNLOAD)
                    {
                        string fileName = br.ReadString();
             
                        string filePath = @"C:\Users\hackeru\Downloads\" + fileName;
                        if (!File.Exists(filePath))
                        {
                            bw.Write(FAIL);
                            bw.Flush();
                        }
                        else
                        {
                            bw.Write(OK);
                            bw.Flush();
                            using (FileStream fs = new FileStream(filePath, FileMode.Open))
                            {
                                int theByte;
                                while((theByte=fs.ReadByte())!=-1)
                                    ns.WriteByte((byte)theByte);
                                ns.Flush();
                            }
                        }
                    }
                    bw.Close();
                    br.Close();
                }
            }
            server.Stop();
        }
    }
}
