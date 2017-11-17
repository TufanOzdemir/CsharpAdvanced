using System;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.TryEventObject.TryOne();
            employee.TryEventObject.TryTwo();
            Console.Read();
        }
    }
}
