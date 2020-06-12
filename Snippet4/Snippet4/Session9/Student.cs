using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Student
    {
        string[] stuName = new string[2];
        public virtual string this[int index]
        {
            get { return stuName[index]; }
            set { stuName[index] = value; }
        }
    }
}
