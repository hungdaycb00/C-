using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Utility_Vehicle.Car;
using Utility_Vehicle = Automotive.Vehicle.Jeep;
namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
            class Category1
            {
                string category;
                public void Display()
                {
                    Console.WriteLine("Jeep category: " + category);
                }
                public Category1()
                {
                category = "ulti Utility Vehicle";
                }
            }
        }
    }
    
}
//namespace Utility_Vehicle
//{
//    namespace Car
//    {
//        class Category
//        {
//            string category;
//            public Category()
//            {
//                category = "luxury veihicle";
//            }
//            public void Display()
//            {
//                Console.WriteLine("Car Category " + category);
//            }
//        }
//    }
//}
