using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Discover
{
    public class DiscoverServer
    {
        public async Task Start(CancellationToken cancellationToken)
        {
            var server = new UdpClient(8888);
            var responseData = Encoding.ASCII.GetBytes("SomeResponseData");

            while (true)
            {
                var clientEp = new IPEndPoint(IPAddress.Any, 0);
                var udpReceiveResult = await server.ReceiveAsync();
                var clientRequest = Encoding.ASCII.GetString(udpReceiveResult.Buffer);

                Console.WriteLine("Recived on {0} from {1}, sending response", clientEp.Address.ToString(), udpReceiveResult.RemoteEndPoint.Address.ToString(), clientRequest);
            }
        }
    }
}