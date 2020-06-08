using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Car
    {
        public string make, model, color;
        public int yearBuilt;

        public void Start()
        {
            System.Console.WriteLine(model + " started");

        }
        public void Stop()
        {
            System.Console.WriteLine(model + " stopped");

        }
    }
}
