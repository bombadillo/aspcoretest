namespace AspCoreTest
{
    using Xunit;
    using System.Collections.Generic;
    
    using Controllers;
    using Models;
    
    public class TestSomething
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