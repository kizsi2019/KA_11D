using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bored2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Goto példa. Kilépés: CTRL+C");
        eleje:
            Console.WriteLine("Add meg a neved");
            var nev = Console.ReadLine();
            Console.WriteLine($"Szia {nev}!");
            goto eleje;

            Console.ReadKey();
            */

            /* Console.WriteLine("\n100 -> 0, minden 4.");
            for (int i = 100; i >= 0; i += 4)
            {
                Console.Write("{0}, ", i);
            }*/

            int i = 5;
            while (1 <= 120)
            {
                Console.WriteLine(i);
                i += 5;

                Console.ReadKey();
            }
            
        }
    }
}
