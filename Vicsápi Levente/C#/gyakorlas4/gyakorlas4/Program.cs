using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyakorlas4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int szam = -1;
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
                }
            }
            while ((szam < 1) || (szam > 10) || ((szam % 2) != 0));

            Console.WriteLine("A megadott szám: {0}", szam);
            */

            /*
            var abc = "abcdefghijklmnopqrstuvwxyz";
            foreach (var betu in abc)
            {
                Console.Write("{0}, ", betu);
            }
            */


            Console.WriteLine("Break példa");
            for (int i = 0; i < 100; i++)
            {
                Console.Write("{0} ", i);
                if (i == 10)
                {
                    break;
                }
            }

            Console.WriteLine("Continue példa");
            int j = 30;
            while (j-- > 0)
            {
                if (j % 3 == 0)
                {
                    continue;
                }
                Console.Write("{0} ", j);
            }


            Console.ReadKey();
        }
    }
}
