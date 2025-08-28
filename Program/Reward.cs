using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Reward
    {
        private int currency;
        private int experience;

        public Reward(int currency, int experience) 
        {
            this.currency = currency;
            this.experience = experience;
        }

        public void Describe()
        {
            Console.WriteLine("Currency : " + currency);
            Console.WriteLine("Experience : " + experience);
        }
    }
}
