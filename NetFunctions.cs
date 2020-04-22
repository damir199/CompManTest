using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

namespace CompManTest
{
    class NetFunctions
    {

        public static void pScan()
        {
            Console.Clear();
            string IP = DeviceFunctions.getIP();
           // TcpClient scan = new TcpClient();
            foreach(int s in Ports)
            {
                using (TcpClient scan = new TcpClient()){
                    try
                    {
                        scan.Connect(IP, s);
                        Console.WriteLine($"[{s}] | OPEN ");
                    }
                    catch
                    {

                        Console.WriteLine($"[{s}] | CLOSED ");

                    } 
                }
            }

        }



        private static int[] Ports = new int[]
        {
           // 25,
            //80,
            //443,
            //20,
            //21,
            //22,
            //23,
            //3389,
            //4200,
            4201,
            3000,

        };

    }
}
