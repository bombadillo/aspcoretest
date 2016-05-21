namespace AspCoreTest.Tests
{
    using Xunit;
    using System.Collections.Generic;
    
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
    }    
}