using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    class Student
    {
        
        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var students = new[]
            {
              new {Name = "Juan", Address = "Uranus" },
              new {Name = "Wangwang", Address = "Lalaland"},
              new {Name = "Maria", Address = "Bethlehem"}
           };

            var query = from student in students
                        orderby student.Name
                        select student;

            foreach (var s in query)
                Console.WriteLine("Name = {0}, Address = {1}",s.Name,s.Address);




            */

            XDocument employeeDoc =
                new XDocument(
                    new XElement("Employees",
                        new XElement("Employee",
                            new XElement("Name", "Madam Bertud"),
                            new XElement("Address", "Hollywood")))
                );

            Console.WriteLine(employeeDoc);



            Console.ReadLine();



        }
    }
}
