using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareTest.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareWidget sq = new SquareWidget();
            sq.SideLength = 5.0;
            Console.WriteLine(sq.Area);
            Console.ReadLine();
        }
    }
}
