using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCFConsoleHost
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(WCFDemoService.HelloService));
            host.Open();
            Console.WriteLine($"Service Started at:{DateTime.Now.ToLongTimeString()}");
            Console.ReadKey(true);
        }
    }
}
