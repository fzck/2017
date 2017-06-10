using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Person() {}

        public Person(string name)
        {
            Name = name;
        }

        public Person( string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;
        }
    }
}
