using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        public static string value = "Waiting...";
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CallValueGenerator();
            while (true)
            {
                Console.Clear();
                Console.Write(value);
                Thread.Sleep(100);
            }
        }

        public async void CallValueGenerator()
        {
            value = await TaskValueGenerator("Continue");
        }

        Task<string> TaskValueGenerator(string text)
        {
            return Task.Factory.StartNew(() => ValueGenerator(text));
        }

        string ValueGenerator(string text)
        {
            Thread.Sleep(2000);
            return text;
        }
    }
}
