using System;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.Text;

namespace CompManTest
{
    class NetFunctions
    {

        public static void pScan()
        {



            var openports = new List<string>();
            Console.Clear();
            string IP = "192.168.0.1";
            using(TcpClient scan = new TcpClient())
            foreach (int s in Ports)
            {
                    try
                    {
                        scan.Connect(IP, s);
                        openports.Add("port:" + $"[{s}] | OPEN " + "At IP: " + IP);
                        Console.WriteLine($"[{s}] | OPEN");

                    }
                    catch
                    {
                        openports.Add("port:" + $"[{s}] | CLOSED " + "At IP: " + IP);
                        Console.WriteLine($"[{s}] | CLOSED");
                    }

            }
            for(int i = 0;  i < openports.Count; i++)
            {
                Console.WriteLine(openports[i]);
            }
            
        }
                
            

        



                private static int[] Ports = new int[]
                {
                    25,
                    80,
                    443,
                    20,
                    21,
                    22,
                    23,
                    3389,
                    4200,
                    8080,
                    4201,
                    3000,

                };

    }
    
}

