using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Polymorphism
{
    internal class Child : Parent
    {
        public string ChildProperty { get; set; }
        public Child() : this("ParentProp", "ChildProp")
        {

        }
        public Child(string _ParentProperty, string _ChildProperty) : base(_ParentProperty)
        {
            ChildProperty = _ChildProperty;
        }
        public new void Print()
        {
            Console.WriteLine("This is the child print");
        }
        public override void VirtualPrint()
        {
            Console.WriteLine("This is the child virtual print");
        }
    }
}
