using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace karacsonyCLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Napimunka> napiMunkaLista = new List<Napimunka>();
            foreach(string sor in File.ReadAllLines("diszek.txt"))
            {
                napiMunkaLista.Add(new Napimunka(sor));
            }

            Console.WriteLine($"4.feladat: Összesen {Napimunka.KeszultDb} darab dísz készült");
            Console.ReadKey();
        }
    }
}
