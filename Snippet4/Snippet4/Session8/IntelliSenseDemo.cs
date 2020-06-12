using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snippet8
{
    class IntelliSenseDemo : TimeZone
    {
        public override string DaylightName
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public override DaylightTime GetDaylightChanges(int year)
        {
            throw new Exception("The method or operation is not implemented.");

        }

        public override TimeSpan GetUtcOffset(DateTime time)
        {
            throw new NotImplementedException();
        }

        public override string StandardName
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }
    }
}
