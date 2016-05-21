namespace AspCoreTest.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    
    using Models;
    using Services;

    [Route("/api/products")]
    public class ProductsController
    {
        private readonly IRetrieveProduct ProductRetriever;       

        public ProductsController(IRetrieveProduct productRetriever)
        {
            ProductRetriever = productRetriever;
        }

        public IEnumerable<Product> Get()
        {
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