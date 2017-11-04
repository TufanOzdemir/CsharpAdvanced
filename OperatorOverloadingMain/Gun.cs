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
        
        //if there == then you must write !=
        public static bool operator ==(Gun gun1, Gun gun2)
        {
            return gun1.Capacity == gun2.Capacity;
        }

        public static bool operator !=(Gun gun1, Gun gun2)
        {
            return gun1.Capacity != gun2.Capacity;
        }

        //int x = gun cast return gun.Capacity
        public static implicit operator int(Gun gun)
        {
            return gun.Capacity;
        }

        //int x = (string)gun cast return gun.Capacity
        public static explicit operator string(Gun gun)
        {
            return gun.Name;
        }
    }
}
