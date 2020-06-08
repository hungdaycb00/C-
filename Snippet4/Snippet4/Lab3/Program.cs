using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism();   
            Console.ReadLine();
        }
        static void MyCar()
        {
            Car myCar;
            System.Console.WriteLine("Creating a Car object and assigning "
                + "its memory location to myCar");
            myCar = new Car();
            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;
            // display the field values using myCar
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model= " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt=" + myCar.yearBuilt);
            // call the methods using myCar
            myCar.Start();
            myCar.Stop();
            System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to redPorsche");

            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;

            System.Console.WriteLine("redPorsche is a " + redPorsche.model);
            //change the object referenced by the myCar object //reference to the object referenced by redPorshe
            System.Console.WriteLine("Assigning redPorsche to myCar");
            myCar = redPorsche;
            System.Console.WriteLine("myCar details:");
            System.Console.WriteLine("myCar.make = " + myCar.make);
            System.Console.WriteLine("myCar.model = " + myCar.model);
            System.Console.WriteLine("myCar.color = " + myCar.color);
            System.Console.WriteLine("myCar.yearBuilt = " + myCar.yearBuilt);
            // assign null to myCar (myCar will no longer reference
            //an object)
            myCar = null;
        }
        static void Polymorphism()
        {
            Window win = new Window(1, 2);
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);

            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();
            Window[] winArray = new Window[3];
            winArray[0] = new Window(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);
            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}
