using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkmaraton2019.txt".Skip(1));
            {
                versenyzok.Add(new Versenyzo(sor));
            }

            Console.WriteLine($"4.feladat: Versenytávot nem teljesítők: {1 - versenyzok.Count / 691}");

            int noiVersenyzokRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzokRovidTavon++;
                }
                Console.WriteLine($"5. feladat: Női versenyzők a rövidtávú versenyen: {noiVersenyzokRovidTavon} fő");
            }




            Console.ReadKey();
        }
    }
}
