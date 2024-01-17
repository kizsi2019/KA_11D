using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BükkMaraton2019
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }
            Console.WriteLine($"Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            int FemaleRacersOnShortTrack = 0;
            foreach (var item in versenyzok)
            {
                if (item.FemaleRacer && item.Tav == "Rövid")
                {
                    FemaleRacersOnShortTrack++;
                }
            }
            Console.WriteLine($"Női versenyző száma a rövidtávú versenyen: {FemaleRacersOnShortTrack} fő");
            Console.ReadKey();
        }
    }
}