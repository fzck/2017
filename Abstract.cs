using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class AbClass                          //abstract class
    {
        public void IdentifyBase()                  //normal method
        { Console.WriteLine("I am AbClass"); }

        abstract public void IdentifyDerived();     //abstract method
    }

    class DerivedClass : AbClass                    //derived class
    {   
        public override void IdentifyDerived()      //implementation of abstract method
        {
            //throw new NotImplementedException();
            Console.WriteLine("I am DerivedClass");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //AbClass ab = new AbClass();             //error. cannot instantiate an abstract class
            //ab.IdentifyDerived();

            DerivedClass b = new DerivedClass();      //instantiate derived class
            b.IdentifyBase();                         //call inherited method
            b.IdentifyDerived();                      //call abstract method

        }
    }
}
