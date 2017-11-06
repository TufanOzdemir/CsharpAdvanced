using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack[0] = 5;
            stack[1] = 4;
            stack[2] = 3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(stack[i]);
            }
            Console.Read();
        }
    }
}
