using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;

namespace Examples.System.Net.NetworkInformation.PingTest

{
    public class PingExample
    {
        public static void Main (string[] args)
        {
			string ip;
			
			Console.WriteLine("Enter IP address to ping: ");
			ip = Console.ReadLine();
		
			
			Ping ping = new Ping();
			PingReply pingReply = ping.Send(ip);
			//while(1==1){ //Just for fun, if you wanted to conduct a one machine DoS!
				Console.WriteLine("-------------");
				Console.WriteLine("Address: {0}", pingReply.Address);
				Console.WriteLine("Time in miliseconds: {0}", pingReply.RoundtripTime);
				Console.WriteLine("Status: {0}", pingReply.Status);
				Console.WriteLine("-------------");
				
			//}
			


        }
    }
}
