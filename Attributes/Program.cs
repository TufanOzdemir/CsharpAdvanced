using System;
using System.Linq;
using System.Reflection;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var types = from t in Assembly.GetExecutingAssembly().GetTypes()
                        where t.GetCustomAttributes<SampleAttribute>().Count() > 0
                        select t;

            foreach (var item in types)
            {
                Console.WriteLine($"Class - {item.Name}");

                foreach (var prop in item.GetProperties())
                {
                    Console.WriteLine($"Property - {prop.Name}");
                }
            }

            Console.Read();
        }
    }
}
