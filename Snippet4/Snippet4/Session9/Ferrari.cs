using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session9
{
    class Ferrari : Car
    {
        public override string CarType {
            get
            {
                return base.CarType;
            }
            set
            {
                base.CarType = value;
                
            }
        }
    }
}
