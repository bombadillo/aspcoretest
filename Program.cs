using System;
using Microsoft.AspNetCore.Hosting;

namespace AspCoreTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Server starting");
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();

            host.Run();            
        }
    }
}
