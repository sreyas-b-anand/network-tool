namespace PingService
{
    class Program
    {
        static void Main(string[] args)
        {
            PingService pingService = new PingService(); //you can modify your constructor to take in the address, timeout , data and buffer
            var res = pingService.sendPing();
            Console.WriteLine(res);
        }
    }
}