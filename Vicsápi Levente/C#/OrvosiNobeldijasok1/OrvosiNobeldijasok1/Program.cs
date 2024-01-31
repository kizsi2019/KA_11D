using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrvosiNobeldijasok1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Díjazott> dijazottak = new List<Díjazott>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Díjazott(i));
            }

            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count}fő");
            int utosoEv = dijazottak.First().Év;
            foreach (var i in dijazottak) 
            {
                if (i.Év > utosoEv)
                {
                    utosoEv = i.Év;

                }
            }
            Console.WriteLine($"4. feladat: Utolsó év: {utosoEv}");

            Console.WriteLine("5. feladat: Kérem adja meg ar ország kódját:");
            string inputOrszagKod = Console.ReadLine().ToUpper();
            List<Díjazott> inputOrszagDíazottjai = new List<Díjazott>();
            foreach (var i in dijazottak) {
                if (i.Orszagkod == inputOrszagKod)
                {
                    inputOrszagDíazottjai.Add(i);
                }
            }
            if (inputOrszagDíazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott országból nem volt díjazott!");

            }
            if (inputOrszagDíazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország díjazottjai:");
                Console.WriteLine($"\tNév {inputOrszagDíazottjai.First().Nev}");
                Console.WriteLine($"\tÉv {inputOrszagDíazottjai.First().Év}");
                Console.WriteLine($"\tSZ/H {inputOrszagDíazottjai.First().SzuletesHalalozas}");
            }
            if (inputOrszagDíazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDíazottjai.Count} fő díjazott volt");
            }
            Console.ReadKey();
        }
        }
    }
