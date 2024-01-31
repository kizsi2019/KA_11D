using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace KaracsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napimunkalista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napimunkalista.Add(new NapiMunka(sor));
            }

            Console.WriteLine($"4. feladat: Összesen {NapiMunka.KeszultDb} darab dísz készült el");
            Console.ReadKey();
        }
    }
}
