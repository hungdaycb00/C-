using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Numbers
    {
        private int[] num = new int[3];
        public int this[int index]
        {
            get
            {
                return num[index];
            }
            set
            {
                num[index] = value;
            }
        }
    }
}
