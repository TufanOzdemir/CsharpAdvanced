using System;
using System.Collections.Generic;

namespace FunctionCreatorWithPredicate
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var f = new FunctionCreator<int, int>();
            f.CreateFunction(x => x * x, x => x < 0);
            f.CreateFunction(y => y * 2 + 1, y => y > 0);

            Console.WriteLine($"f(-2) = {f.Invoke(-2) } \n");
            Console.WriteLine($"f(2) = {f.Invoke(2) }");
            Console.ReadKey();
        }

        public class FunctionCreator<T, TResult>
        {
            private readonly List<(Func<T, TResult> Func, Predicate<T> Predicate)> Functions;

            public FunctionCreator()
            {
                Functions = new List<(Func<T, TResult>, Predicate<T>)>();
            }
            public void CreateFunction(Func<T, TResult> Func, Predicate<T> predicate = null)
            {
                Functions.Add((Func, predicate));
            }
            public TResult Invoke(T x)
            {
                foreach (var function in Functions)
                {
                    if (function.Predicate == null || function.Predicate(x))
                    {
                        if (function.Func == null)
                        {
                            return default(TResult);
                        }
                        return function.Func(x);
                    }
                }
                return default(TResult);
            }
        }
    }
}
