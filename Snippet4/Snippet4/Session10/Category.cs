using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    class Category
    {
        string category;
        public Category()
        {
            category = "Multi Utility Vehicle";
        }
        public void Display()
        {
            Console.WriteLine("Category: " + category);
        }
    }
}
