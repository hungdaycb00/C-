using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Result : Student
    {
        string[] result = new string[2];
        public override string this[int index]
        {
            get { return base[index]; }
            set { base[index] = value; }
        }
    }
}
