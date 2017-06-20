using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    delegate double MyDel(int par);
    class Program
    {
        static void Main(string[] args)
        {
            MyDel del = delegate (int x) { return x + 1; }; //anonymous method

            MyDel le1 = (int x) => { return x + 1 ; };
            MyDel le2 = (x) => { return x + 1; };
            MyDel le3 = x => { return x + 1; };
            int le4 =+ 1;
            MyDel le5 = x => x + 1;


            Console.WriteLine(le1(12));
            Console.WriteLine(del(12));
            Console.WriteLine(le2(12));
            Console.WriteLine(le3(12));
            Console.WriteLine(le4);
            Console.WriteLine(le5(12));


        }
    }
}
