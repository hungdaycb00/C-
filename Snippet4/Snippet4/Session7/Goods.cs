using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Goods 
    {
        public void CreatGoods()
        {
            Product product = new Product();
            product.cost = 75;
            product.quality = 50;
            Console.WriteLine("Quantity of the Product: " + product.quality);
            Console.WriteLine("Cost of the Product: " + product.cost);
        }
        
        
    }
}
