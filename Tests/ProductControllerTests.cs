namespace AspCoreTest.Tests
{
    using Xunit;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    
    using Controllers;
    using Models;
    
    public class ProductControllerTests
    {
        [Fact]
        public void Get_ReturnsListOfProducts()
        {
            var sut = new ProductsController();
            
            var result = sut.Get();
            
            Assert.IsType<List<Product>> (result);
        }        
        
        [Fact]
        public void GetWithId_ReturnsOneProduct()
        {
            var sut = new ProductsController();
            
            var result = sut.Get(1);
            
            Assert.IsType<OkObjectResult> (result);
        }
    }    
}