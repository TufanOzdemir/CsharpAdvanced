using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            GameObject gameObject = new GameObject() { ID = 1, Name = "Cube", X = 0, Y = 0, Z = 0 };
            GameObject gameObject2 = new GameObject() { ID = 2, Name = "Sphere", X = 1, Y = 1, Z = 1 };
            Console.WriteLine(gameObject.Information());
            Console.WriteLine(gameObject.Information(gameObject2));
            Console.Read();
        }
    }
}
