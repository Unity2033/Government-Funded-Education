using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    public struct Vector2
    {
        public int x; 
        public int y;
    
        public Vector2(int x, int y) 
        {
            this.x = x;
            this.y = y;
        }
    }

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

        public void Magnitude(Vector2 vector2, out float length)
        {
            length = (float)Math.Sqrt(vector2.x * vector2.x + vector2.y * vector2.y);
        }
    }
}
