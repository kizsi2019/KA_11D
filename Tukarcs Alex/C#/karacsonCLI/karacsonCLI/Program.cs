using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace karacsonCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<NapiMunka> napiMunkaLista = new List<NapiMunka>();
            foreach (string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new NapiMunka(sor));
            }

            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készleten");

            Console.ReadKey();
        }
    }
}
