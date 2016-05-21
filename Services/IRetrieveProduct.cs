namespace AspCoreTest.Services
{
    using System.Collections.Generic;
    
    using Models;
    
    public interface IRetrieveProduct
    {
        List<Product> Retrieve();
    }
}