using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Asyncronous_Programming
{
    internal class AsynchronousWait
    {
        public static async Task Run()
        {
            Task task = Task.Run(() =>
            {
                Task.Delay(4000).Wait();
            });
            await task; //will suspend the current method and return control to the calling method until this finishes
            Console.WriteLine("ASynchronous waiting is finished");
            return;
        }
    }
}
