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
            Console.WriteLine($"Versenytávot nem teljesítôk: {(1 - versenyzok.Count / 691.0) * 100}%");

            int FemaleRacersOnShortTrack = 0;
            foreach (var item in versenyzok)
            {
                if (item.FemaleRacer && item.Tav == "Rövid")
                {
                    FemaleRacersOnShortTrack++;
                }
            }
            Console.WriteLine($"Nôi versenyzô száma a rövidtávú versenyen: {FemaleRacersOnShortTrack} fô");

            bool MoreThan6Hours = false;
            foreach (var item in versenyzok)
            {
                if (item.MoreThan6Hours)
                {
                    MoreThan6Hours = true;
                    break;
                }
            }
            Console.WriteLine($"{(MoreThan6Hours ? "Volt" : "Nem Volt")} ilyen versenyzô");

            Console.WriteLine($"A felnôtt férfi (ff) kategória gyôztese rövid távon:");
            Versenyzo WinnerMaleOnShortLength = null;
            foreach (var v in versenyzok)
            {
                if(v.Tav == "Rövid" && v.Kategoria == "ff")
                {
                    if (WinnerMaleOnShortLength == null)
                    {
                        WinnerMaleOnShortLength = v;
                    }
                    else
                    {
                        if(v.Ido < WinnerMaleOnShortLength.Ido)
                        {
                            WinnerMaleOnShortLength = v;
                        }
                    }
                }
            }
            Console.WriteLine($"\tRajtszám: {WinnerMaleOnShortLength.Rajtszam}");
            Console.WriteLine($"\tNév: {WinnerMaleOnShortLength.Nev}");
            Console.WriteLine($"\tEgyesület: {WinnerMaleOnShortLength.Egyesulet}");
            Console.WriteLine($"\tIdô: {WinnerMaleOnShortLength.Ido}");

            Console.WriteLine("Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var item in versenyzok)
            {
                if (!item.FemaleRacer)
                {
                    if (stat.ContainsKey(item.Kategoria))
                    {
                        stat[item.Kategoria]++;
                    }
                    else
                    {
                        stat.Add(item.Kategoria, 1);
                    }
                }
            }

            foreach (var item in stat)
            {
                Console.WriteLine($"\t{item.Key} - {item.Value} fô");
            }

            Console.ReadKey();
        }
    }
}