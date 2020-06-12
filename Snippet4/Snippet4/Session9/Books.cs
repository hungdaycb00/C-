using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Books
    {
        string bookName;
        long bookID;

        public Books(string name, int value)
        {
            bookName = name;
            bookID = value;
        }

        public string BookName
        {
            get { return bookName; }
           
        }
        public long BookId
        {
            get { return bookID; }

        }
    }
}
