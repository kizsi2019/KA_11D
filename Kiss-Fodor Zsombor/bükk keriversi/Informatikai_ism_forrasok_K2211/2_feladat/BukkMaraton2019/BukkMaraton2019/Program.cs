using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BukkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }


            Console.WriteLine($"4.feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            //5. feladat
            int noiversenzokRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiversenzokRovidTavon++;
                }
            }

            Console.WriteLine($"5. feladat: Női versenyzők száma a rövidtávú versenyen: {noiversenzokRovidTavon}");

            //6. feladat
            bool tobbMintHat = false;
            foreach (var v in versenyzok)
            {
                if (v.tobbMintHat)
                {
                    tobbMintHat = true;
                    break;
                }
            }
            Console.WriteLine($"6. feladat: {(tobbMintHat ? "Volt" : "Nem Volt")} Ilyen versenyző");

            Console.ReadKey();
        }
    }
}