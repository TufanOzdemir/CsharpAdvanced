using System;

namespace AnonymousMethodsAndTypes
{
    class Program
    {
        delegate void Operation(int number);
        static void Main(string[] args)
        {
            //Anonymous Methods
            Operation operation = delegate (int num) { Console.WriteLine($"{num}"); };
            operation(5);

            //Lambda Expressions
            Operation operation2 = num => { Console.WriteLine($"{num}"); };
            operation2(4);

            //parameter , parameter , .... Action do return void.
            Action<int> action = num => { Console.WriteLine($"{num}"); };
            action(3);

            //parameter , parameter => result <int,int,int,......> Func is can't return void.
            Func<int,int,int> func = (x,y) => { return x * y; };
            Console.WriteLine(func(3,5));

            //Anonymous Types
            var anonymousType = new { TryProp = "Try", ID = 1 };
            Console.WriteLine($"{anonymousType.ID} {anonymousType.TryProp}");

            Console.Read();
        }
    }
}
