using System;
using System.ServiceModel;
using com.devrockit.wcfsample1.Service;
using com.devrockit.wcfsample1.Service.Services;

namespace com.devrockit.wcfsample1.TcpConsoleHost
{
    class Program
    {
        private static void Main(string[] args)
        {
            var serviceHost = new ServiceHost(typeof (PolicyService));
            serviceHost.Open();
            Console.WriteLine("Service running.  Please 'Enter' to exit...");
            Console.ReadLine();
        }
    }
}