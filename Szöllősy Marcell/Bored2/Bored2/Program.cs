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

            /* int i = 5;
            while (1 <= 120)
            {
                Console.WriteLine(i);
                i += 5;

                Console.ReadKey();
            }*/
            /*int szam = -1;
            do
            {
                try
                {
                    Console.WriteLine("Adjon meg egy 1 és 10 közötti páros számot!");
                    string szoveg = Console.ReadLine();
                    szam = Convert.ToInt32(szoveg);
                }
                catch (Exception)
                {
                    szam = -1;
                }*/
            /*}
            while ((szam < 1) || (szam > 10) || ((szam % 2) != 0)) ;

            Console.WriteLine("A megadott szám: {0}", szam);
            Console.ReadKey();*/

            var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var betu in abc)
            {
                Console.Write("{0}, ", betu);
            }
            Console.ReadKey();*/
        }
    }
}
