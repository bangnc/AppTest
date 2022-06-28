using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTest
{
    public class Calculate: ICalculate
    {
        public decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public decimal Sub(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
