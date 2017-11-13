using System;
using System.Reflection;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Console.WriteLine("Assembly Name : " + assembly.FullName);

            Type[] types = assembly.GetTypes();
            Console.WriteLine("\nTypes : ");
            foreach (var type in types)
            {
                Console.WriteLine("\t" + type.Name);

                //Properties
                var props = type.GetProperties();
                if(props.Length > 0)
                {
                    Console.WriteLine("\t\tProperties : ");
                }
                foreach (var prop in props)
                {
                    Console.WriteLine("\t\t\t" + prop.Name + "(" + prop.PropertyType + ")");
                }

                //Fields
                var fields = type.GetFields();
                if(fields.Length > 0)
                {
                    Console.WriteLine("\t\tFields : ");
                }
                foreach (var field in fields)
                {
                    Console.WriteLine("\t\t\t" + field.Name + "(" + field.FieldType + ")");
                }

                //Methods
                var methods = type.GetMethods();
                if (methods.Length > 0)
                {
                    Console.WriteLine("\t\tMethods : ");
                }
                foreach (var method in methods)
                {
                    Console.WriteLine("\t\t\t" + method.Name + "(" + method.ReturnType + ")");
                }
            }

            //Type Instance
            var sampleType = typeof(TryClass1);

            //Method Instance
            var myMethod = sampleType.GetMethod("WriteMethod");
            var myObject = myMethod.Invoke(new TryClass1(), null);

            Console.WriteLine("myObject : " + myObject.ToString());
            Console.Read();
        }
    }
}
