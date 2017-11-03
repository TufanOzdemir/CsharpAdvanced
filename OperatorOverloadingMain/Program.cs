using OperatorOverloading;
using System;

namespace OperatorOverloadingMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Gun gun1 = new Gun() { Name = "M4", Capacity = 40 };
            Gun gun2 = new Gun() { Name = "M16", Capacity = 30 };

            Gun gun = gun1 + gun2;

            int x = gun1;
            string y = (string)gun2;

            Console.WriteLine(gun.Name + " " + gun.Capacity);
            Console.WriteLine(x + " " + y);
            Console.Read();
        }
    }
}
