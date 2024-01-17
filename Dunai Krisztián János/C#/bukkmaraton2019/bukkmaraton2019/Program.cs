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

            //3. feladat
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkmaraton2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }

            Console.WriteLine($"4.feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            // 5. feladat
            int noiVersenyzokRovidTavon = 0;
            foreach (var v in versenyzok)
            {
                if (v.Noiversenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzokRovidTavon++;
                }

            }
            Console.WriteLine($"5.feladat: Női versenyzők száma a rövidtávú versenyen: {noiVersenyzokRovidTavon} fő");
            Console.ReadKey();
        }
    }
}