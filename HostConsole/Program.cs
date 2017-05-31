using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WcfCinema;
using System.ServiceModel;
using System.Threading.Tasks;

namespace HostConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Service));

            host.Open();

            Console.WriteLine("host is running");

            Console.Read();

            host.Close();

        }
    }
}
