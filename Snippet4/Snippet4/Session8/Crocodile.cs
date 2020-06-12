using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class Crocodile : ITerrestriaAnimal, IMarineAnimal, IReptile
    {
        public void Eat()
        {
            Console.WriteLine("The Crocodile eats human ");
        }

        public void Swim()
        {
            Console.WriteLine("The Crocodile can swim four time faster than an Duck");
        }

        string ITerrestriaAnimal.Eat1() 
        {
            string terCroc = "Crocodile eats other animals";
            return terCroc;
        }

        string IMarineAnimal.Eat()
        {
            string marCroc = "Crocodile eats  fish and marine animals";
            return marCroc;
        }

        public string EatTerrestrial()
        {

            ITerrestriaAnimal objTerAnimal = this;
            return objTerAnimal.Eat1();
        }

        public string EatMarine()
        {
            IMarineAnimal objMarAnimal;
            objMarAnimal = this;
            return objMarAnimal.Eat();
        }

        public void Drink()
        {
            Console.WriteLine("Drink fresh water");
        }

        public void Habitat()
        {
            Console.WriteLine("Can stay in Water and Land");
        }


    }
}
