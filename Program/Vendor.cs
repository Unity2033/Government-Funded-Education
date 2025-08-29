using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Vendor : ITradable
    {
        public void Deal()
        {
            Console.WriteLine("Shop Open");
        }
    }
}
