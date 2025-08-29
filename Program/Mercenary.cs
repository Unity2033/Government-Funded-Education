using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Mercenary : IDamageable, IMovable
    {
        public void Move()
        {
            Console.WriteLine("Mercenary Move");
        }

        public void TakeDamage(float attack)
        {
            Console.WriteLine("Damage : " + attack);
        }
    }
}
