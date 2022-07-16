using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Polymorphism
{
    internal class Parent
    {
        public string ParentProperty { get; set; }
        public Parent() : this("ParentProp")
        {

        }
        public Parent(string _ParentProperty)
        {
            ParentProperty = _ParentProperty;
        }
        public void Print()
        {
            Console.WriteLine("This is the parent print");
        }
        public virtual void VirtualPrint()
        {
            Console.WriteLine("This is the virtual parent print");
        }
    }
}
