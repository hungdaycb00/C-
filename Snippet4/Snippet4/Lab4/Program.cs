using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Part4();
            
            Console.ReadLine();
        }
        static void Lab4_1()
        {
            Circle cl = new Circle(2.5, "Blue", 23);
            Console.WriteLine("Circle before change: " + cl.ToString());

            cl.Pcolor = "Red";
            cl.PWeight = 2.56;
            Console.WriteLine("Circle after change: " + cl.ToString());
           
        }
        static void IndexerDemo()
        {
            int i, j = 0;
            IndexerExample indexTest = new IndexerExample();
            for(i = 1; i < 10; i += 2)
            {
                indexTest[j] = i;
                j++;
            }
            for (i = 0; i < 5; i++)
            { Console.WriteLine("indexTest [{0}] is {1}", i, indexTest[i]); }
        }
        static void Part4()
        {
            Faculty fc1 = new Faculty("Oke", "12345444", "dsa@oooo.com", "Math", 99993.99, DateTime.Parse("20/02/2012"), true);
            
            Console.WriteLine(fc1.ToString() + "\nBonus: " + fc1.CalculateBonus() + "Rest week: " + fc1.CalculateVacation());
            
            
        }
    }
}
