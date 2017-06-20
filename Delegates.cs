using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate void PrintFunction();
    class Test
    {
        public void Print1()
        { Console.WriteLine("Print 1 -- instance"); }

        public void Print2()
        { Console.WriteLine("Print 2 -- static"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();
            PrintFunction pf;

            pf = t.Print1;

            pf += t.Print2;
            pf += t.Print1;
            pf += t.Print2;

            if (null != pf)
                pf();
            else
                Console.WriteLine("Delegate is empty.");
        }
    }
}
