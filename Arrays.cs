using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //1D array
            int[] myIntArray;
            myIntArray = new int[4];

            for (int i = 0; i < 4; i++)
                myIntArray[i] = i * 10;

            for (int i = 0; i < 4; i++)
                Console.WriteLine("Value of element {0} is {1}", i, myIntArray[i]);




            //2D array
            int[,] intArray = new int[,] { { 0, 0, 9 }, { 1, 2, 3 }};
            Console.WriteLine(intArray.Length);
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 3; j++)
                    Console.WriteLine("{0} {1} = {2}", i, j, intArray[i,j]);


            //jagged array
            int[][] arr = new int[3][];

            arr[0] = new int[] { 1,2,3,4};
            arr[1] = new int[] { 11, 22, 33, 44 };
            arr[2] = new int[] { 5, 6, 7 };

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < arr[i].Length; j++)
                    Console.WriteLine(arr[i][j]);
           
        }
    }
}
