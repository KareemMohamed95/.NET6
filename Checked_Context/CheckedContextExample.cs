using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Checked_Context
{
    internal class CheckedContextExample
    {
        internal static void Run()
        {
            checked
            {
                try
                {
                    int x = int.MaxValue;
                    x = x + 1; //This line will through exception because of overflow
                }
                catch(Exception e)
                {
                    Console.WriteLine("Overflow exception");
                }
            }
        }
    }
}
