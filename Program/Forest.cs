using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Forest : Terrain, ICoverable, ITraversable
    {
        public Forest() 
        {
            width = 75;
            height = 20;
        }

        public override void Activate()
        {
            Cover();

            Console.WriteLine("Traverse : " + Traverse());
        }

        public void Cover()
        {
            Console.WriteLine("hide behind a tree");
        }

        public override void Describe()
        {
            Console.WriteLine("Dense tree coverag");
        }

        public bool Traverse()
        {
            return false;
        }
    }
}
