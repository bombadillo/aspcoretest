namespace AspCoreTest.Tests
{
    using Xunit;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using System.Linq;
    
    using Controllers;
    using Models;
    using Services;
    
    public class ProductControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfProducts()
        {
            var sut = new ProductsController(new ProductRetriever());
            
            var result = sut.Get();
            
            Assert.IsType<List<Product>> (result);
        }        
        
        [Fact]
        public void GetWithId_ReturnsOneProduct()
        {
            var sut = new ProductsController(new ProductRetriever());
            
            var result = sut.Get(1);
            
            Assert.IsType<OkObjectResult> (result);
        }
        
        [Fact]
        public void Post_AddsProductToProductsList()
        {
            var sut = new ProductsController(new ProductRetriever());
            var expected = sut.Get().Count() + 1;
            
            var result = sut.Post(new Product{ Id = 4, Name = "Banana"});                       
            
            Assert.IsType<OkObjectResult> (result);
        }
    }    
}