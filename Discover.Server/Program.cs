using System;
using System.Threading;

namespace Discover.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            var discoverServer = new Discover.DiscoverServer();
            
            discoverServer.Start(new CancellationToken());
        }
    }
}