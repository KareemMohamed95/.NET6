using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Dynamic_Objects
{
    internal class DynamicObjectsExample
    {
        internal static void Run()
        {
            dynamic obj = new ExpandoObject();
            //Will dynamically add properties as if it is a Javascript object
            obj.Id = 4;
            obj.Name = "dynamic object";
            obj.Age = obj.Id * 6;
            Console.WriteLine($"Dynamic object Id = {obj.Id}, Name = {obj.Name}, Age = {obj.Age}");
        }
    }
}
