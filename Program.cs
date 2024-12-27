using System.Net.NetworkInformation;
using System.Text;

Ping pingSender = new Ping();
PingOptions pingOptions = new PingOptions();
pingOptions.DontFragment = true;

string data = "Learning to code";

byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";
PingReply reply = pingSender.Send(address , timeout ,buffer ,pingOptions);
if(reply.Status == IPStatus.Success)
{
    Console.WriteLine($"Response : {reply.Status.ToString()}");
    Console.WriteLine($"RoundTrip : {reply.RoundtripTime}");
}   