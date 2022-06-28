using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    public interface IProductDataAccess
    {
        bool CreateProduct(Product product);
    }

}
