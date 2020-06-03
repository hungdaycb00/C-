using System;
using System.Collections.Generic;
using System.Text;

namespace ManhHung
{
    class Student
    {
        private string name;
        private string major;
        private double gpa;
        public static int songCount = 0;

        public Student(string name, string major, double gpa)
        {
            this.name = name;
            this.major = major;
            this.gpa = gpa;
            songCount++;
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public int getSongCount
        {
            get { return songCount; }
        }
        public void Hi()
        {
            Console.WriteLine("Hello");
        }
    }
}
