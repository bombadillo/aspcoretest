namespace AspCoreTest.Services
{
    using System.Collections.Generic;
    
    using Models;
    
    public class ProductRetriever : IRetrieveProduct
    {
        public List<Product> Retrieve()
        {            
            return new List<Product>(new[] {
                new Product() { Id = 1, Name = "Computer" },
                new Product() { Id = 2, Name = "Radio" },
                new Product() { Id = 3, Name = "Apple" },
            });
        }
    }
}