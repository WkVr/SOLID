using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //This class make use of dependency injection. a;thpugh tje class does not apply the Single Responsibility Principal
    //This class also use the Liskov Substitution Principle by accesing the FooBar class with the ICount interface
    internal class Dependency
    {
        Bar _bar;

        public int FooBar { get; set; }

        public Dependency(Bar bar)
        {
            _bar = bar;
        }

        public void sumInts()
        {
            FooBar = _bar.addInts(1,2);
        }

        public List<int> generateFooBarCountList(List<ICount> fooBars)
        {
            var list = new List<int>();
            foreach (var fooBar in fooBars)
                list.Add(fooBar.Count());

            return list;
        }
    }
}
