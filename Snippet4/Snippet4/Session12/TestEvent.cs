using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Session12
{
    class TestEvent
    {
        public delegate void PrintDetails();
        event PrintDetails Print;
        void Show()
        {
            Console.WriteLine("This program illustrate how to subscribe objects to an event");
            Console.WriteLine("This method will not execute since the event has not been raised");

            void Display()
            {
                TestEvent objTestEvent = new TestEvent();
                objTestEvent.Print += new PrintDetails(objTestEvent.Show);
            }
        }
    }
}


