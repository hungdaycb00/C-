using System;
using System.Text;
using System.Threading.Tasks;

namespace ManhHung
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1999,12,11);
            Console.WriteLine(date.ToString("dd/MM/yyyy"));
            Console.WriteLine(date.Month);
            Console.ReadKey();
        }

       

    }
}
