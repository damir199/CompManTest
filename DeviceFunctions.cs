using System;
using System.Net;


namespace CompManTest
{
    class DeviceFunctions
    {
        public static string getIP()
        {
            var host = Dns.GetHostName().ToString();
            string systemIP;

            //Fethes IPv4 address by using index [1] of AddressList.           
            //TO-DO: 
            //Create a loop for addresslist that selects the ipv4 address instead of selecting the index.
            systemIP = Dns.GetHostEntry(Dns.GetHostName().ToString()).AddressList[1].ToString();

            //                  ----TESTING------
            Console.WriteLine(systemIP.ToString());

            //return the IP as string to use with rest of program.
            return systemIP;

        }
    }
}
