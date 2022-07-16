using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.OOP
{
    static class OOPExample
    {
        internal static void Run()
        {
            Parent parent = new Child();
            Child child = new Child();

            parent.Print(); //The Parent variable will unhide the "Print" method of the Parent class

            child.Print(); //The Child object hides access to the "Print" method of the Parent class

            parent.VirtualPrint(); //The Child object overrides the definition of the "VirtualPrint" method in the Parent class 

            child.VirtualPrint(); //The Child object overrides the definition of the "VirtualPrint" method in the Parent class
        }
    }
}
