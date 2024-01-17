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
             Console.ReadLine();

        }

    }
}
