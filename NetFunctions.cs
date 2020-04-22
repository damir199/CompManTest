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




            Console.Clear();
            string IP = "192.168.0.1";
            // TcpClient scan = new TcpClient();
            using(TcpClient scan = new TcpClient())
            foreach (int s in Ports)
            {
                    try
                    {
                        scan.Connect(IP, s);
                        Console.WriteLine($"[{s}] | OPEN");
                    }
                    catch
                    {
                        Console.WriteLine($"[{s}] | CLOSED");
                    }

                


            }
        }
                
            

        



                private static int[] Ports = new int[]
                {
                   // 25,
                    80,
                    //443,
                    //20,
                    //21,
                    //22,
                    //23,
                    //3389,
                    4200,
                    8080,
                    4201,
                    3000,

                };

    }
    
}

