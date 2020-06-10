using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Snippet13();
            Console.ReadKey();
        }
        static void Snippet1()
        {
            Dog objDog = new Dog();
            objDog.Eat();
            objDog.Feature();
            objDog.Noise();
            
        }
        static void Snippet2()
        {
            Cat objCat = new Cat();
            objCat.Eat();
           // objCat.DoSomething();
            objCat.SpecialDish();
        }
        static void Snippet5()
        {

            Department.Main1();
        }
        static void Snippet6()
        {
            Canine canine = new Canine();
            
        }
        static void Snippet7()
        {
            Automobiles objMobile = new Automobiles("Chassies");
        }
        static void Snippet8()
        {
            Cat objCat = new Cat();
            objCat.Eat();
           
        }
        static void Snippet9()
        {
            Student objStudent = new Student();
            Grade grade = new Grade();
            objStudent.PrintDetails();
            grade.PrintDetails();
        }
        static void Snippet10()
        {
            Goods goods = new Goods();
            goods.CreatGoods();
        }
        static void Snippet11()
        {
            SealedSystem objSealed = new SealedSystem();
            objSealed.Print();
        }
        static void Snippet12()
        {
            int length = 10;
            int breadth = 22;
            double tbase = 2.5;
            double theight = 1.5;
            Area area = new Area();
            Console.WriteLine("Area of Rectangle: " + area.CalculateArea(length, breadth));
            Console.WriteLine("Area of triangle: " + area.CalculateArea(tbase, theight));
        }
        static void Snippet13()
        {
            Circle objRunOne = new Circle();
            Console.WriteLine("Area is: " +objRunOne.Area());
            Circle objRunTwo = new Cone();
            Console.WriteLine("Area is: " +objRunTwo.Area());
        }
    }
}
