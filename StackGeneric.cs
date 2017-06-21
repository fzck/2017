using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericStack.cs
{
    class Stack<T>
    {
        T[] StackArray;
        int StackPointer = 0;

        public void Push(T x)
        {
            if (!IsStackFull)
                StackArray[StackPointer++] = x;
        }

        public T Pop()
        {
            return (!IsStackEmpty)
                ? StackArray[StackPointer--]
                : StackArray[0];
        }

        const int MaxStack = 10;
        bool IsStackFull { get { return StackPointer >= MaxStack; } }
        bool IsStackEmpty { get { return StackPointer <= 0; } }

        public Stack()
        {
            StackArray = new T[MaxStack];
        }

        public void Print()
        {
            for (int i = StackPointer - 1; i >= 0; i--)
                Console.WriteLine("Value: " + StackArray[i]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> StackInt = new Stack<int>();
            Stack<string> StackString = new Stack<string>();

            StackInt.Push(3);
            StackInt.Push(4);
            StackInt.Print();

            Stack<object> StackObject = new Stack<object>();
            StackObject.Push(4);
            StackObject.Push("Minute");
            StackObject.Push("Hello");
            StackObject.Print();


        }
    }
}
