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
            //2.feladat
            List<Adatok> dijazottak = new List<Adatok>();

            foreach (var i in File.ReadAllLines("orvosi_nobeldijak.txt").Skip(1)) 
            {
                dijazottak.Add(new Adatok(i));
            }

            //3.feladat
            Console.WriteLine($"3. feladat: A díjazottak száma: {dijazottak.Count} fő");

            //4.feladat
            int utolsoEv = dijazottak.First().Ev;

            foreach (var i in dijazottak) 
            {
                if (i.Ev > utolsoEv) 
                {
                    utolsoEv = i.Ev;
                }
            }

            Console.WriteLine($"4.feladat: Utolsó ev: {utolsoEv}");

            //5.feladat
            Console.Write("5. feladat: Kérem adja meg ar ország kódját: ");
            string inputOrszagKod = Console.ReadLine().ToUpper();
            List<Adatok> inputOrszagDíazottjai = new List<Adatok>();
            foreach (var i in dijazottak)
            {
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
                Console.WriteLine($"\tÉv {inputOrszagDíazottjai.First().Ev}");
                Console.WriteLine($"\tSZ/H {inputOrszagDíazottjai.First().SzuletesHalalozas}");
            }
            if (inputOrszagDíazottjai.Count > 1)
            {
                Console.WriteLine($"\tA megadott országból {inputOrszagDíazottjai.Count} fő díjazott volt");
            }

            //6.feladat
            Console.WriteLine("6.feladat: Statisztika");
            Dictionary<string, int> stat = new Dictionary<string, int>();
            foreach (var i in dijazottak)
            {
                if (stat.ContainsKey(i.Orszagkod))
                {
                    stat[i.Orszagkod]++;
                }
                else
                {
                    stat.Add(i.Orszagkod, 1 );
                }
            }

            foreach(var i in stat)
            {
                if (i.Value > 5)
                {
                    Console.WriteLine($"\t{i.Key} - {i.Value}");
                }
            }
            //7.feladat
            int elethosszOsszeg = 0;
            int ismertElethosszFo = 0;
            foreach(var i in dijazottak)
            {
                Elethossz aktivDijazottakEletkora = new Elethossz(i.SzuletesHalalozas);
                if (aktivDijazottakEletkora.IsmertAzElethossz)
                {
                    elethosszOsszeg += aktivDijazottakEletkora.ElethosszEvekben;
                    ismertElethosszFo++;
                }
            }
            Console.WriteLine($"7.feladat: A keresett átlag {(double) elethosszOsszeg / ismertElethosszFo:F1} év");

            Console.ReadKey();
        }
    }
}
