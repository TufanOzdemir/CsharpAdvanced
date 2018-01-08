using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            var t1 = new Task(() =>
            {
                Console.WriteLine("task 1 is begining.");
                Thread.Sleep(2000);
                Console.WriteLine("task 1 is completed.");
            });
            t1.ContinueWith((prevTask) =>
            {
                Console.WriteLine("task 1 is stopped.");
            });
            t1.Start();

            //Method 2
            var t2 = new Task(() => Job(2, 1500));
            t2.Start();

            //Method 3
            var t3 = Task.Factory.StartNew(() => Job(3, 3000)).ContinueWith((prevTask) => JobContinue(3));

            //Tasks wait
            List<Task> taskList = new List<Task>() { t1, t2, t3 };
            Task.WaitAll(taskList.ToArray());

            var intList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Parallel.ForEach(intList,(id)=> Console.WriteLine(id));

            Console.WriteLine("Please any key to quit. ");
            Console.Read();
        }

        static void Job(int id, int sleep)
        {
            Console.WriteLine($"task {id} is begining.");
            Thread.Sleep(sleep);
            Console.WriteLine($"task {id} is completed.");
        }

        static void JobContinue(int id)
        {
            Console.WriteLine($"task {id} is stopped.");
        }
    }
}
