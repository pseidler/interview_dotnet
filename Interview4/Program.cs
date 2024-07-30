using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interview5
{
    class Program
    {
        static void Main(string[] args)
        {
            object lock1 = new object();
            object lock2 = new object();
            var task1 = Task.Run(() => // queue work in new thread
            {
                lock(lock1)
                {
                    Thread.Sleep(50);
                    lock(lock2)
                    {
                        Console.WriteLine("Task 1");
                    }
                }
            });

            var task2 = Task.Run(() =>
            {
                lock(lock2)
                {
                    Thread.Sleep(50);
                    lock(lock1)
                    {
                        Console.WriteLine("Task 2");
                    }
                }
            });

            Task.WaitAll(task1, task2);
            Console.WriteLine("Fini!");
            Console.ReadKey();
        }
    }
}
