using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Asyncronous_Programming
{
    internal class AsyncronousProgrammingExample
    {
        public static void Run()
        {
            Task AsyncTask = AsynchronousWait.Run(); //will continue here after hitting await in this method
            Console.WriteLine("Asynchronously waiting for the Async Task to finish");
            SynchronousWait.Run();
            AsyncTask.Wait();
            return;
        }
    }
}
