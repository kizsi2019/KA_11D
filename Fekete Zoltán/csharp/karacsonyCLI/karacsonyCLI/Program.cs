using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> diszek = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                diszek.Add(new NapiMunka(sor));
            }
            // 4. feladat
            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült.");
            
            Console.ReadKey();
        }
    }
}
