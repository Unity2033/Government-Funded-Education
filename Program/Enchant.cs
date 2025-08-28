using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Enchant
    {
        public void Enhance(Item item)
        {
            if(item.Name == "Sword")
            {
                item.Strength = 10;
            }
            else if(item.Name == "Necklace")
            {
                item.Intelligence = 10;
            }
            else if(item.Name == "Shoes")
            {
                item.Dexterity = 10;
            }
        }
    }
}
