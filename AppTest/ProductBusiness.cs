using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    public class ProductBusiness
    {
        private readonly IProductDataAccess _productDataAccess;

        public ProductBusiness(IProductDataAccess productDataAccess)
        {
            _productDataAccess = productDataAccess;
        }

        public bool CreateProduct(Product newProduct)
        {
            bool result = _productDataAccess.CreateProduct(newProduct);
            return result;
        }
        public bool UpdateProduct(Product newProduct)
        {
            bool result = _productDataAccess.CreateProduct(newProduct);
            return false;
        }
    }
}
