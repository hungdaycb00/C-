using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Dog : IAnimal, IWork
    {
        
        public void Habitat()
        {
            Console.WriteLine("Can be housed with human being");

        }

        public void AnimalType()
        {
            Console.WriteLine("house");
        }
        public void WorkAnimal()
        {
            Console.WriteLine("Protect house");
        }
        public void Drink()
        {
            Console.WriteLine("drink water");
        }


    }
}
