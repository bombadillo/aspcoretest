namespace AspCoreTest.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Models;
    using Services;
    using Options;

    [Route("/api/products")]
    public class ProductsController
    {
        private readonly IRetrieveProduct ProductRetriever;     

        private Config Config;  

        public ProductsController(IRetrieveProduct productRetriever, IOptions<Config> config)
        {
            ProductRetriever = productRetriever;
            Config = config.Value;
        }

        public IEnumerable<Product> Get()
        {
            Console.WriteLine(Config.Foo);
            return ProductRetriever.Retrieve();            
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {            
            var product = ProductRetriever.Retrieve().FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return new NotFoundResult();
            }

            return new OkObjectResult(product);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product)
        {
            return new OkObjectResult(product);
        }
        
        
    }
}