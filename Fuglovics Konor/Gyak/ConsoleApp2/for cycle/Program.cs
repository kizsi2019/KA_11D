using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_cycle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=100; i>=0; i -= 4)
            {
                Console.Write("{0}, ", i);
            }
            Console.ReadKey();
        }
    }
}
