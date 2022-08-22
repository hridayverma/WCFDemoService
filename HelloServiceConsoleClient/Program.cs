using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloServiceConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyHelloService.HelloServiceClient client = new
                                    MyHelloService.
                                    HelloServiceClient("NetTcpBinding_IHelloService");
            client.DoWork();
            Console.WriteLine("Sum:"+client.Addition(20,30));

            client.Close();
        }
    }
}
