using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session6
{
    class Book
    {
        private string bookName;
       

        public string PrintBook()
        {
            return bookName;
        }
        public void InputBookName(string name)
        {
            bookName = name;
        }
        public void PrintNameAuthor(string firstName, string lastName)
        {
            Console.WriteLine("First Name = {0}, Last name = {1}", firstName, lastName);
        }
        public void printMessage(string message = "Hello")
        {
            Console.WriteLine(message);
        }

    }
}
