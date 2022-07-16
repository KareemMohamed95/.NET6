using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Variance
{
    internal class ContraVariance
    {
        internal interface IBag<in T>
        {
            void Add(T t);
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
            IBag<ChildA> children = new Bag<Parent>(new(){ new Parent() });
            children.Add(new ChildA ());
        }
    }
}
