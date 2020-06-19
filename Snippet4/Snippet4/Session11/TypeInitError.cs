using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session11
{
    class TypeInitError
    {
        static TypeInitError()
        {
            throw new ApplicationException("This program throws TypeInitializationException error.");
        }
    }
}
