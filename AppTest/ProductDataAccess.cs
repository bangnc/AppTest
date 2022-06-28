using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    public class ProductDataAccess : IProductDataAccess
    {
        public bool CreateProduct(Product product)
        {
            Console.WriteLine("Vao");
            return false;
        }
    }
}
