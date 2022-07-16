using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Operator_Overloading
{
    internal class OperatorOverloadingExample
    {
        internal static void Run()
        {
            Point p1 = new() { x = 1, y = 3 };
            Point p2 = new() { x = 3, y = 6 };
            Point p3 = p1 + p2;
            Point p4 = 2 * p2;
            Console.WriteLine($"Point 3 is at x = {p3.x} and y = {p3.y}");
            Console.WriteLine($"Point 4 is at x = {p4[0]} and y = {p4[1]}");
        }
    }
}
