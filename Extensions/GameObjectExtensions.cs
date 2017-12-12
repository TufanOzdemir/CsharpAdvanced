using System;
using System.Collections.Generic;
using System.Text;

namespace Extensions
{
    public static class GameObjectExtensions
    {
        public static string Information(this GameObject gameObject)
        {
            return gameObject.Name + " " + gameObject.ID + " " + gameObject.X + " " + gameObject.Y + " " + gameObject.Z;
        }

        public static string Information(this GameObject gameObject,GameObject gameObject2)
        {
            return gameObject.Name + " " + gameObject2.Name;
        }
    }
}
