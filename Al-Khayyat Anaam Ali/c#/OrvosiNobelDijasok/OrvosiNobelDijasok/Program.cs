using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OrvosiNobeldijasok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. feladat
            List<Dijazott> dijazottak = new List<Dijazott>();
            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1))
            {
                dijazottak.Add(new Dijazott(i));
            }
            // 3. feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");

            // 4. feladat
            int utolsoEv = dijazottak.First().Év;
            foreach (var i in dijazottak)
            {
                if (i.Év > utolsoEv)
                {
                    utolsoEv = i.Év;
                }
            }
            Console.WriteLine($"4. feladat: Utolsó év {utolsoEv} ");

            // 5. feladat
            Console.Write("5. feladat: Kérem adja meg az oszág kódját:");
            string input0rszagKod = Console.ReadLine().ToUpper();
            List<Dijazott> inputOrszagDijazottjai = new List<Dijazott>();
            foreach (var i in dijazottak)
            {
                if (i.Országkód == input0rszagKod)
                {
                    inputOrszagDijazottjai.Add(i);
                }
            }
            if (inputOrszagDijazottjai.Count == 0)
            {
                Console.WriteLine("\tA megadott orszából nem volt díjazott!");
            }
            if (inputOrszagDijazottjai.Count == 1)
            {
                Console.WriteLine($"A megadott ország dijazottjai:");
                Console.WriteLine($"\tNév {inputOrszagDijazottjai.First().Név}");
                Console.WriteLine($"\tÉv {inputOrszagDijazottjai.First().Év}");
                Console.WriteLine($"\tSZ/H {inputOrszagDijazottjai.First().SzületésHalálozás}");
            }
            if (inputOrszagDijazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDijazottjai.Count} fő diazott volt");
            }
            // 6. feladat
            Console.WriteLine("6. feladat: statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Országkód))
                {
                    stat[i.Országkód]++;
                }
                else
                {
                    stat.Add(i.Országkód, 1);
            }
            foreach (var i in stat)
            {
                    if (i.Value > 5)
                    {
                        Console.WriteLine($"\t{i.Key} - {i.Value} fő");
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
