using System;

namespace Discover.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var discoverServer = new Discover.DiscoverClient();

            discoverServer.Start();
        }
    }
}