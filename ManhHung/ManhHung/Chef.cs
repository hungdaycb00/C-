using System;
using System.Collections.Generic;
using System.Text;

namespace ManhHung
{
    class Chef
    {
        public void makechiken()
        {
            Console.WriteLine("Make chicken");
        }
        public void makeBBq()
        {
            Console.WriteLine("Make BBq");
        }
        public virtual void SpecialCook()
        {
            Console.WriteLine("Make fish");
        }
    }
}
