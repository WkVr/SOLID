using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    //This class is using the Single Responsibility Principal bacause it is only generating FooBar
    //This class uses two Interfaces. These interfaces have different responsibilities. The interfaces are seperate in order ot use then seperately.
    internal class FooBar: Final, ICount, IGenerate
    {
        public string First { get; set; }
        public string Second { get; set; }

        public FooBar(string first, string second)
        {
            First = first;
            Second = second;
        }

        public override string generateFinal()
        {
            return string.Concat(First.Trim(), Second.Trim());
        }

        public int Count()
        {
            return First.Length + Second.Length;
        }

        public int CountFirst()
        {
            return First.Length;
        }

        public char GetFirstChar()
        {
            return First[0];
        }
    }
}
