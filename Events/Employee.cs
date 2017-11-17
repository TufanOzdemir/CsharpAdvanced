using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public TryEvent TryEventObject { get; set; }

        public Employee()
        {
            TryEventObject = new TryEvent();
            TryEventObject.tryEvent += (object sender, TryEventArgs e) =>
            {
                Employee employee = (Employee)sender;
                switch (e.Time)
                {
                    case 8:
                        Console.WriteLine($"{employee.ID} {employee.Name} Login.");
                        break;
                    case 18:
                        Console.WriteLine($"{employee.ID} {employee.Name} Logout.");
                        break;
                    default:
                        break;
                }
            };
        }
    }
}
