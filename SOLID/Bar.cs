using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //This class is not using the Single Responisbility Principle beacause the class has a function to add integers
    internal class Bar: FooBar
    {
        public string FooBar { get; set; }
        public Bar(string first, string second): base(first,second)
        {
            FooBar = generateFinal();
        }

        public int addInts(int first, int second)
        {
            return first + second;
        }
    }
}
