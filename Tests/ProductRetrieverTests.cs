namespace AspCoreTest.Tests
{
    using Xunit;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    
    using Models;
    using Services;
 
    public class ProductRetrieverTests
    {
        [Fact]
        public void Retrieve_ReturnsListOfProducts()
        {
            var sut = new ProductRetriever();
            
            var result = sut.Retrieve();
            
            Assert.IsType<List<Product>> (result);            
        }
    }
    
}