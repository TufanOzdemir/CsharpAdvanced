using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    public class Gun
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
        
        //You must add static and 2 parameter.
        public static Gun operator +(Gun gun1, Gun gun2)
        {
            Gun gun = new Gun();
            gun.Capacity = gun1.Capacity + gun2.Capacity;
            gun.Name = gun1.Name + " " + gun2.Name;
            return gun;
        }
    }
}
