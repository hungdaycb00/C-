using System;
using System.Collections.Generic;
using System.Text;

namespace ManhHung
{
    class Book
    {
        private string name;
        private string author;
        private int pages;

        public Book(string name, string author, int pages)
        {
            this.name = name;
            this.author = author;
            this.pages = pages;
        }

        
        public void SetName(string name)
        {
            this.name = name;
        }

       
        public string GetName()
        {
            return this.name;
        }
        public string tooString()
        {
            return name + "-" + author + "-" + pages;
        }
    

    }
}
