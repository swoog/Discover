using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Discover
{
    public class DiscoverClient
    {
        public void Start()
        {
            var client = new UdpClient();
            var requestData = Encoding.ASCII.GetBytes("SomeRequestData");
            var serverEp = new IPEndPoint(IPAddress.Any, 0);

            client.EnableBroadcast = true;
            client.Send(requestData, requestData.Length, new IPEndPoint(IPAddress.Broadcast, 8888));

            var serverResponseData = client.Receive(ref serverEp);
            var serverResponse = Encoding.ASCII.GetString(serverResponseData);
            Console.WriteLine("Recived {0} from {1}", serverResponse, serverEp.Address.ToString());

            client.Close();
        }
    }
}