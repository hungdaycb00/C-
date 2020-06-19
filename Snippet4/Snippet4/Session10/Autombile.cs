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
            class Autombile
            {
                public void Display()
                {
                    Category1 objCat = new Category1();
                    
                    objCat.Display();
                    Utility_Vehicle.Category1 category = new Utility_Vehicle.Category1();
                    category.Display();
                }
            }
        }
        
    }
    
}
