using System;

namespace DynamicType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dynamic type convert process
            Example1();
            Example2();
            Console.Read();
        }

        public static void Example1()
        {
            //Error....
            //string test = "Tufan Ozdemir";
            //test = 5;

            dynamic test = "Tufan Ozdemir";
            test = 5;

            Console.WriteLine(test);
        }

        public static void Example2()
        {
            dynamic person = new Person() { Age = 10, Name = "Tufan" };
            person.Age = 10;

            Console.WriteLine($"Age : {person.Age} Name : {person.Name}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
