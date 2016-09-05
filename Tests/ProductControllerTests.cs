namespace AspCoreTest.Tests
{
    using Xunit;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    
    using Controllers;
    using Microsoft.Extensions.Options;
    using Models;
    using Options;
    using Services;
    
    public class ProductControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfProducts()
        {
            var sut = new ProductsController(new ProductRetriever(), Options.Create<Config>(null));
            
            var result = sut.Get();
            
            Assert.IsType<List<Product>> (result);
        }        
        
        [Fact]
        public void GetWithId_ReturnsOneProduct()
        {
            var sut = new ProductsController(new ProductRetriever(), Options.Create<Config>(null));

            var result = sut.Get(1);
            
            Assert.IsType<OkObjectResult> (result);
        }
        
        [Fact]
        public void Post_AddsProductToProductsList()
        {
            var sut = new ProductsController(new ProductRetriever(), Options.Create<Config>(null));
            
            var result = sut.Post(new Product{ Id = 4, Name = "Banana"});                       
            
            Assert.IsType<OkObjectResult> (result);
        }
    }    
}