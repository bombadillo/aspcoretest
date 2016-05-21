namespace AspCoreTest
{
    using System;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.DependencyInjection;
    
    using Services;
    
    public class Startup
    {
        
        public void ConfigureServices(IServiceCollection services)
        { 
            services.AddMvcCore()
                    .AddJsonFormatters();
                    
            services.AddTransient<IRetrieveProduct, ProductRetriever>();
        }
        
        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
        }
    }
}