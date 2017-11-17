using System;

namespace Delegates
{
    class Program
    {
        delegate void MyDelegate(int number);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = Number;
            ExecuteDelegate(5,myDelegate);
            Console.Read();
        }

        static void ExecuteDelegate(int number,MyDelegate myDelegate)
        {
            myDelegate += Number;
            myDelegate += Line;
            myDelegate -= Number;
            myDelegate(number);
        }

        static void Number(int number)
        {
            Console.WriteLine($"{number} added.");
        }

        static void Line(int line)
        {
            Console.WriteLine($"{line} line added.");
        }
    }
}
