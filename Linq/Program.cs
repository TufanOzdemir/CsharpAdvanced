using Linq.Linq101;
using System;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initialize
            BaseClass baseClass = new BaseClass();

            //Linq101
            new SelectAnonymousType();

            /*string text = "Created by Tufan Ozdemir";

            var result = from k in text.ToLower()
                         where k == 'a' || k == 'e' || k == 'i' || k == 'o'
                         orderby k
                         group k by k;

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} - {item.Count()}");
            }*/
            Console.Read();
        }
    }
}
