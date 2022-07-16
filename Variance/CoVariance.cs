using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Variance
{
    internal class CoVariance
    {
        internal interface IBag<out T>
        {
            T Get(int index);
        }
        internal class Bag<T> : IBag<T>
        {
            public List<T> _List { get; set; } = new();
            public Bag(List<T> InitializerList)
            {
                _List = InitializerList;
            }
            public T Get(int index) => _List[index];
            public void Add(T entity) => _List.Add(entity);
        }
        internal class Parent { }
        internal class ChildA : Parent { }
        internal static void Run()
        {
            IBag<Parent> children = new Bag<ChildA>(new() { new ChildA()});
            ChildA child = (ChildA)children.Get(0);
        }
    }
}
