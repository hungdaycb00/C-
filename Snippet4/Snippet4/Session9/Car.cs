using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Car
    {
        string carType;
        public virtual string CarType
        {
            get { return carType; }
            set { carType = value; }
        }
    }
}
