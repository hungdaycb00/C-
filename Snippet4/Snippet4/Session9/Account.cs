using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Account
    {
        string[,] accountDetails = new string[4, 2];
        public string this[int pos, int column]
        {
            get
            {
                return accountDetails[pos, column];
            }
            set
            {
                accountDetails[pos, column] = value;
            }
        }
    }
}
