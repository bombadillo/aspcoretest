using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;

namespace AspCoreTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Server starting");
            
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .Build();

            host.Run();            
        }
    }
}
