using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Types_Comparison
{
    internal static class TypesComparisonExample
    {
        internal static void Run()
        {
            Person[] people = new Person[]
            {
                new Person(){Name = "Ahmed"},
                new Person(){Name = "Ali"},
                new Person(){Name = "Mohamed"}
            };
            Array.Sort(people);
            foreach(Person person in people)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
