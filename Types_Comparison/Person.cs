using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET6.Types_Comparison
{
    internal class Person : IComparable<Person>
    {
        public string Name { get; set; }

        public int CompareTo(Person? other)
        {
            int result = (new CaseInsensitiveComparer()).Compare(other?.Name, this.Name);
            return result;
        }
    }
}
