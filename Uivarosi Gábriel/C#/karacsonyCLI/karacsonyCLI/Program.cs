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
           
            List<NapiMunka> Beolvasot_lista = new List<NapiMunka>();
         foreach (string sor in File.ReadAllLines("diszek.txt")) 
            {
                Beolvasot_lista.Add(new NapiMunka(sor));
            }


            Console.WriteLine($"4.feladat: Összesen {NapiMunka.KeszultDb} darab dísz készűlt");
          
            Console.ReadKey();
        }
    }
}
