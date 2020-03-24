using System;
using System.Net;

namespace CompManTest
{
    class Program
    {
        

        public static void getIP()
        {
            var host = Dns.GetHostName().ToString();
            string systemIP;

            systemIP = Dns.GetHostEntry(host).AddressList[0].ToString();



           Console.WriteLine(systemIP.ToString());
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            getIP();

        }


    }
}
