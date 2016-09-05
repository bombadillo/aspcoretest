namespace AspCoreTest
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Configuration;
    using Options;
    using Services;
    
    public class Startup
    {
        private IHostingEnvironment HostingEnvironment;   
        
        public Startup(IHostingEnvironment env)
        {
            HostingEnvironment = env;
        }        
        
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureSettings(services);
            services.AddMvcCore()
                    .AddJsonFormatters();
                                                  
            services.AddTransient<IRetrieveProduct, ProductRetriever>();
        }
        
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseMvc();

            if (env.IsDevelopment())
            {
                Console.WriteLine("test");
            }
        }

        public void ConfigureSettings(IServiceCollection services)
        {
            var configBuilder = new ConfigurationBuilder()
                .SetBasePath(HostingEnvironment.ContentRootPath)
                .AddJsonFile("config.json");

            var config = configBuilder.Build();

            services.Configure<Config>(config);
        }
    }
}