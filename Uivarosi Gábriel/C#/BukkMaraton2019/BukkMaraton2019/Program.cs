using System;
using System.Collections.Generic;
using System.IO;
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
          //3 mas Feladat
          List<Versenyzo> Versenyzok = new List<Versenyzo>(); 
            
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1)) 
            {
                Versenyzok.Add(new Versenyzo(sor));
                


            }


            Console.WriteLine($"4.feladat: Versenytávot nem teljesítők: {(1 - Versenyzok.Count / 691.0) * 100}%");
            // 5. feladat
            int noiVersenyzikRovidTavon = 0;
            foreach (var v in Versenyzok)
            {
                if (v.NoiVersenyzo && v.Tav == "Rövid")
                {
                    noiVersenyzikRovidTavon++;
                        }
            }
            Console.WriteLine($"5.feladat: Női versenyzők száma a rövidtávú versenyen:{ noiVersenyzikRovidTavon}" );
            // 6 os feladat több mint hat?
            bool tobbMinthat = false;
            foreach (var v in Versenyzok) 
            {
                if (v.TobbmintHat) {
                    tobbMinthat = true;
                        break; }
            }
            Console.WriteLine($"6. Feladat: {(tobbMinthat ? "Volt" : "Nem volt")} ");
            Console.ReadKey();
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9vCb_ZopT4A");
        }

    }
}
