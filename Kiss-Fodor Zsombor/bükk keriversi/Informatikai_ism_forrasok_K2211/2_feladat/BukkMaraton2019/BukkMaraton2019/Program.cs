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
            List<Versenyzo> versenyzok = new List<Versenyzo>();
            foreach (var sor in File.ReadAllLines("bukkm2019.txt").Skip(1))
            {
                versenyzok.Add(new Versenyzo(sor));
            }


            Console.WriteLine($"4.feladat: Versenytávot nem teljesítők: {(1 - versenyzok.Count / 691.0) * 100}%");

            Console.ReadKey();
        }
    }
}
