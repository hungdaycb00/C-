using Snippet8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session8
{
    class Program
    {
        static void Main(string[] args) { 

            Snippet11();
            Console.ReadLine();
        }
        static void Snippet1and2()
        {
            Lion objLion = new Lion();
            objLion.AnimalSound();
            objLion.Eat();
            
        }

        static void Snippet6()
        {
            Crocodile cr = new Crocodile();
            cr.Swim();
            cr.Eat();
        }
        static void Snippet7()
        {
            Crocodile objCro = new Crocodile();
            string terCroc = objCro.EatTerrestrial();
            Console.WriteLine(terCroc);
            string marCoc = objCro.EatMarine();
            Console.WriteLine(marCoc);
        }
        static void Snippet8()
        {
            Crocodile objCrocodile = new Crocodile();
            Console.WriteLine(objCrocodile.GetType().Name);
            objCrocodile.Habitat();
            objCrocodile.Eat();
            objCrocodile.Drink();
        }
        static void Snippet9()
        {
            Sphere sp = new Sphere();
            sp.Main9();
        }
        static void Snippet10()
        {
            Rectangle objRec = new Rectangle(10.2f, 20.3f);
            if (objRec is ICalcilate)
            {
                Console.WriteLine("Area of rectangle : {0:F2}", objRec.Area());
            }
            else
            {
                Console.WriteLine("Interface method not implemented");
            }
        }
        static void Snippet11()
        {
            Employee objEmp = new Employee();
            objEmp.AcceptDetails(10, "Jack");
            IGet objGet = objEmp as IGet;
            if(objGet != null)
            {
                objGet.Display();
            }
            else
            {
                Console.WriteLine("Invalid casting occurred");
            }
        }
    }
}
