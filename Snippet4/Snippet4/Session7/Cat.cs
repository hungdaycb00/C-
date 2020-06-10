using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Cat : Animal
    {
        public void SpecialDish()
        {
            Cat cat = new Cat();
            cat.food = "fish";
            cat.activity = "lazearound";
            Console.WriteLine(cat.food);
            Console.WriteLine(cat.activity);
        }
        public override void Eat()
        {
            Console.WriteLine("Cat love to eat the mouse");
        }
    }
}
