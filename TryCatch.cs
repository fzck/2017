using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            try
            {
                int y = 0;
                x /= y;
            }
            catch
            {
                Console.WriteLine("Handling all exceptions. Keep on running.");
                Console.ReadLine();
            }
        }
    }
}
