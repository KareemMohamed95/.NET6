using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Asyncronous_Programming
{
    internal class SynchronousWait
    {
        public static void Run()
        {
            Task task = Task.Run(() =>
            {
                Task.Delay(3000).Wait();
            });
            task.Wait(); //Will block the current thread until this finishes
            Console.WriteLine("Synchronous waiting is finished");
            return;
        }
    }
}
