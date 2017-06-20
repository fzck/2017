using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisTest
{
    class MyClass
    {
        int Var1 = 10;

        public int ReturnMaxSum(int Var1)
        {
            return Var1 > this.Var1
                        ? Var1
                        : this.Var1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();

            Console.WriteLine("Max: " + mc.ReturnMaxSum(30));
            Console.WriteLine("Max: " + mc.ReturnMaxSum(5));
        }
    }
}
