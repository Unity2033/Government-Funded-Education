using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Swamp : Terrain, ITraversable
    {
        public Swamp() 
        {
            width = 30;
            height = 5;
        }

        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }

        public override void Describe()
        {
            Console.WriteLine("Often flooded or saturated with water.");
        }

        public bool Traverse()
        {
            return true;
        }
    }
}
