using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Item
    {
        private string name;
        private int strength;
        private int dexterity;
        private int intelligence;
        
        public string Name { get { return name; } }
        public int Strength { set { strength = value; } }
        public int Dexterity { set { dexterity = value; } }
        public int Intelligence { set { intelligence = value; } }

        public Item(string name, int strength, int dexterity, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
        }
    }
}
