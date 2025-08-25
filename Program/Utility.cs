using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Utility
    {
        public void Pause()
        {
            Console.WriteLine("Pause....");
        }

        public void Swap(ref int x, ref int y)
        {
            int temporary = x;

            x = y;

            y = temporary;
        }

        public int Absolute(in int value)
        {
            return value < 0 ? -value : value; 
        }
    }
}
