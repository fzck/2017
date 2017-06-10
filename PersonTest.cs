using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class PersonTest
    {
        static void Main(string[] args)
        {
            IList < Person > persons = new List<Person>();

            persons.Add(new Person("Mary Jane", 420, "Jamaica"));
            persons.Add(new Person("Kim Jong Un", 69, "North Korea"));
            persons.Add(new Person("Mao Ze Dong", 199, "China"));

            for (int i = 0; i < persons.Count; i++)
                Console.WriteLine(persons[i].Name+" "+persons[i].Age+" "+persons[i].Address);

            Console.ReadLine();

        }
    }
}
