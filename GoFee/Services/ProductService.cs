using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFee.Services
{
    internal class ProductService
    {
        HttpClient httpClient;
        public ProductService()
        {
            httpClient = new HttpClient();            
        }

        List<Product> productList = new ();

        public async Task <List<Product>> GetProducts()
        {
            if (productList?.Count > 0)
                return productList;

            return productList;
        }
    }
}
