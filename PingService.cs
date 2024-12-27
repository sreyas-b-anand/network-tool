using System;
namespace Pinger{
    public class PingService
    {
        public int Data { get; set; };
        public byte[] Buffer { get; set; };
        public string Address { get; set; };
        public int Timeout { get; set; };
        public Ping pingSender { get; set; };
        public PingOptions pingOptions { get; set; };

        public PingService()//can modify the constructor to take in the address, timeout , data and buffer
        {
            pingSender = new Ping();
            pingOptions = new PingOptions();
            pingOptions.DontFragment = true;//Set the DontFragment option to true
            Data = "Learning to code";//Data to send
            Buffer = Encoding.ASCII.GetBytes(Data);//Convert data to byte array
            Timeout = 120;//Convert data to byte array
            Address = "";//Your address goes here
        }
        public bool sendPing()
        {
            PingReply reply = pingSender.Send(Address, Timeout, Buffer, pingOptions);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine($"Response : {reply.Status.ToString()}");
                Console.WriteLine($"RoundTrip : {reply.RoundtripTime}");
                return true;
            }
            return false;
        }
    }


}

