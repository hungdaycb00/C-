using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination
{
    class ScoreReport1
    {
        public string Subject = "Science";
        public int Marks = 60;
        static void Display()
        {
            Students.StudentDetails st = new Students.StudentDetails();
            ScoreReport objReport = new ScoreReport();
            Console.WriteLine("Subject: " + objReport.Subject);
            Console.WriteLine("Marks: " + objReport.Marks);

        }
    }
}
