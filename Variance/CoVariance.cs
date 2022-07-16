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
            public List<T> list { get; set; }
            public Bag(List<T> InitializerList)
            {
                list = InitializerList;
            }
            public T Get(int index) => list[index];
            public void Add(T entity) => list.Add(entity);
        }
        internal class Parent 
        { 
            public string? Name { get; set; }
        }
        internal class Child : Parent { }
        internal static void Run()
        {
            IBag<Parent> children = new Bag<Child>(new() 
            { 
                new Child() { Name = "Covariance" } 
            });
            Child child = (Child)children.Get(0);
        }
    }
}
