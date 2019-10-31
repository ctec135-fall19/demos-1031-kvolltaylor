using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    class Program
    {
        static void Main(string[] args)
        {
            // casting 101 and 99 to bytes to make sure I'm sending bytes to method MyMath1
            Console.WriteLine("101 + 99 = {0}", MyMath1.Add((byte)101,(byte)99));
            // bytes are maximum 256, so if you add more than that it overflows and
            // disposes of the significant value and keeps the insignificant
            Console.WriteLine("101 + 201 = {0}", MyMath1.Add(101, 201));

        }
    }
}
