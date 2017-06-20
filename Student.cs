using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListing
{
    class Student
    {

        public string Name { get; set; }
        public string Course { get; set; }
        public string StudentNumber { get; set; }


        public Student() { }

        public Student(string name, string course, string studentNumber)
        {
            Name = name;
            Course = course;
            StudentNumber = studentNumber;
        }

        public override String ToString()
        {
            String s = ("Name: "+Name + "\nCourse: " + Course + "\nStudent Number " + StudentNumber + "\n");
            return s;
        }
    }
}
