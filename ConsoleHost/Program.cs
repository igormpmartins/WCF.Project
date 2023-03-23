using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Description;
using MultiplicationServiceLibrary;

namespace ConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tcpBaseUrl = "net.tcp://localhost:6789";
            var tcpBaseAddress = new Uri(tcpBaseUrl);

            var httpBaseUrl = "http://localhost:6790/MyHttpEndpoint";
            var httpBaseAddress = new Uri(httpBaseUrl);

            var serviceHost = new ServiceHost(typeof(MultiplicationService), new Uri[] { tcpBaseAddress, httpBaseAddress });

            var tcpServiceEndpoint = serviceHost.AddServiceEndpoint(typeof(IMultiplicationService), new NetTcpBinding(), tcpBaseAddress);
            var httpServiceEndpoint = serviceHost.AddServiceEndpoint(typeof(IMultiplicationService), new WSHttpBinding(), httpBaseAddress);

            var serviceMetaBehavior = new ServiceMetadataBehavior();
            serviceMetaBehavior.HttpGetEnabled = false;
            serviceHost.Description.Behaviors.Add(serviceMetaBehavior);

            var httpServiceEndpointMex = serviceHost.AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexHttpBinding(), $"{httpBaseUrl}/mex");

            var tcpServiceEndpointMex = serviceHost.AddServiceEndpoint(typeof(IMetadataExchange),
                MetadataExchangeBindings.CreateMexTcpBinding(), $"{tcpBaseUrl}/mex");

            serviceHost.Open();

            Console.WriteLine("Service Started...");

            foreach (var item in serviceHost.Description.Endpoints)
            {
                Console.WriteLine($"Address: {item.Address}");
                Console.WriteLine($"Binding: {item.Binding}");
                Console.WriteLine($"Contract: {item.Contract.Name}");
            }

            Console.ReadLine();

            serviceHost.Close();
        }
    }
}
