using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMath
{
    public class MyMath1
    {
        // static says I can call a method without having to create an object
        public static byte Add(byte x, byte y)
        {
            // this code will detect an overflow
            // will throw an exception for me
            checked
            {
                byte b = (byte)(x + y);
                return b;
            }
            // return (byte)(x + y);
            // return b;
        }
    }
}
