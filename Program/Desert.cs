using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Desert : Terrain, ITraversable
    {
        public Desert()
        {
            width = 100;
            height = 35;
        }

        public override void Activate()
        {
            Console.WriteLine("Traverse : " + Traverse());
        }

        public override void Describe()
        {
            Console.WriteLine("Usually less than 250 mm (10 inches) of rain per year."); 
        }

        public bool Traverse()
        {
            return true; ;
        }
    }
}
