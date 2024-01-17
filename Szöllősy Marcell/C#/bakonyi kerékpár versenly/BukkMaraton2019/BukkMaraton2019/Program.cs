using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BukkMaraton2019
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

            Console.WriteLine($"4.feladat: Versenytávok nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            int noiVersenyzokRovidTavon = 0;
            foreach (var v in versenyzok) 
            { 
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzokRovidTavon++;
                }
                
            }
           
            Console.WriteLine($"5. Feladat: Női versenyzők száma a rövidtávú versenyen: {noiVersenyzokRovidTavon} fő");
            


        }
    }
}
