using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //This class use the Open/Closed Principal because the method in FooBar trims the word and this method must use the word as in
    // thus ivveriding the method in FooBar
    internal class Foo: FooBar
    {
        public string FooBar { get; set; }
        public Foo(string first, string second) : base(first, second)
        {
            FooBar = generateFinal();
        }

        public override string generateFinal()
        {
            return string.Concat(Second, First);
        }
    }
}
