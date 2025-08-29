using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Necklace : Item, IEnhanceable
    {
        public Necklace() : base("Necklase",0, 5, 10)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Strength : " + strength);
            Console.WriteLine("Dexterity : " + dexterity);
            Console.WriteLine("Intelligence : " + intelligence);
        }

        public void Upgrade()
        {
            intelligence += 10;

            Console.WriteLine("Enhanced Abilities : " + intelligence);
        }
    }
}
