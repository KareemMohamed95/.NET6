using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Variance
{
    internal class InVariance
    {
        internal class Parent { }
        internal class ChildA : Parent { }
        internal class ChildB : Parent { }
        internal static void Run()
        {
            // This InVariance code will not compile because of type safety

            // List<Parent> ParentList = new List<ChildA>();
            // ParentList.Add(new ChildB());
        }
    }
}
