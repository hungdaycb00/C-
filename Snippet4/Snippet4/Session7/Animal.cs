using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Animal
    {
        protected string food;
        protected string activity;

        public Animal()
        {
            
            Console.WriteLine("Animal constructor without parameters");
        }
        public Animal(String name)
        {
            Console.WriteLine("Animal constructor with a string parameter");
        }
        public virtual void Eat()
        {
            Console.WriteLine("Every animal eats something.");
        }

       protected void DoSomething()
        {
            Console.WriteLine("Every animal does something.");

        }
    }
}
